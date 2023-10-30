import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_servises/account.service';
import { AppUser } from '../models/appUser';
import { filter, map } from 'rxjs';
import { FormArray, FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Shift } from '../models/shift';
import { addShift } from '../models/addShift';
import { ShiftService } from '../_servises/shift.service';

@Component({
  selector: 'app-add-shift',
  templateUrl: './add-shift.component.html',
  styleUrls: ['./add-shift.component.css'],
})
export class AddShiftComponent implements OnInit {
  barmans: AppUser[] = [];
  barLength: number = 0;
  shiftForm: any = new FormArray([]);
  shiftArray: addShift[] = [];
  selectedDate: string = '';
  constructor(
    private accountService: AccountService,
    private shiftService: ShiftService
  ) {}
  ngOnInit(): void {
    this.accountService.getUsers().subscribe({
      next: (users: AppUser[]) => {
        users = users.filter((user: AppUser) => user.isBarmen === true);
        this.barLength = users.length;
        this.barmans = users;
        for (let i = 0; i < this.barLength; i++) {
          this.shiftForm.push(new FormArray([]));
          for (let j = 0; j < 7; j++) {
            (this.shiftForm.at(i) as FormArray).push(new FormControl());
          }
        }
      },
      error: (err) => console.error(err),
    });
  }

  loadBarmens() {}
  logA() {
    for (let day = 0; day < this.shiftForm?.value.length; day++) {
      let newShiftDate: Date = new Date(this.selectedDate);

      for (
        let worker = 0;
        worker < this.shiftForm?.value[day].length;
        worker++
      ) {
        newShiftDate.setDate(newShiftDate.getDate() + worker);
        if (this.shiftForm?.value[day][worker]) {
          let newDate = newShiftDate.toJSON().split('T')[0];
          let newShift: addShift = {
            timeStart: this.shiftForm?.value[day][worker],
            dateOfShift: newDate,
            userId: this.barmans[day].id,
          };
          this.shiftArray.push(newShift);
        }
      }
    }
    console.log(this.shiftArray);
    this.shiftService.createWeekShift(this.shiftArray).subscribe({
      next: (response) => {},
    });
  }
}
