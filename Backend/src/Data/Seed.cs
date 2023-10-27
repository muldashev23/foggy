using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Backend.Data.Entities;
using Backend.Data.Repositories;
using Backend.Models.DTOs;
using Backend.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public class Seed
{
    public static async Task SeedUsers(DataContext context)
    {
        if (await context.Users.AnyAsync())
            return;
        var userData = await File.ReadAllTextAsync("Data/UserSeedData.json");
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
        foreach (var user in users)
        {
            using var hmac = new HMACSHA512();
            user.FirstName = user.FirstName.ToLower();
            user.Email = user.Email.ToLower();
            user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("User1234"));
            user.PasswordSalt = hmac.Key;
            context.Users.Add(user);
        }
        await context.SaveChangesAsync();
    }

    public static async Task SeedShifts(DataContext context)
    {
        if (await context.Shifts.AnyAsync())
            return;
        var shiftsData = await File.ReadAllTextAsync("Data/ShiftSeedData.json");
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var shifts = JsonSerializer.Deserialize<List<ShiftRequestDTO>>(shiftsData);
        foreach (var shift in shifts)
        {
            var user = await context.Users.SingleOrDefaultAsync(user => user.Id == shift.UserId);
            var newShift = new Shift
            {
                DayNum = shift.DayNum,
                WeekNum = shift.WeekNum,
                TimeStart = shift.TimeStart,
                AppUser = user,
                DateOfShift = shift.DateOfShift
            };
            await context.Shifts.AddAsync(newShift);
            await context.SaveChangesAsync();
        }
        await context.SaveChangesAsync();
    }
}
