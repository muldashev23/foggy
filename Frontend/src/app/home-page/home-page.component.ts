import { Component, OnInit } from '@angular/core';
import { ShiftService } from '../_servises/shift.service';
import { Shift } from '../models/shift';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css'],
})
export class HomePageComponent implements OnInit {
  todaysShift: Shift[] = [];
  barmensShift: Shift[] = [];
  shishamensShift: Shift[] = [];
  dayOfWeek: string = 'Monday';

  constructor(private shiftService: ShiftService) {}
  ngOnInit(): void {
    this.loadTodaysShifts();
  }
  loadTodaysShifts() {
    this.shiftService.loadShifts().subscribe({
      next: (shifts) => {
        shifts = shifts.filter(
          (shift: Shift) =>
            new Date(shift.dateOfShift).toString() ===
            new Date('2023-10-30').toString()
        );
        this.todaysShift = shifts;
        this.barmensShift = this.todaysShift.filter(
          (shift: Shift) => shift.appUser.isBarmen
        );
        this.shishamensShift = this.todaysShift.filter(
          (shift: Shift) => shift.appUser.isShishaMaster
        );
      },
      error: (err) => console.error(err),
    });
  }
}
