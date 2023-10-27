import { Component, Input } from '@angular/core';
import { Shift } from '../models/shift';

@Component({
  selector: 'app-day-card',
  templateUrl: './day-card.component.html',
  styleUrls: ['./day-card.component.css'],
})
export class DayCardComponent {
  @Input() shift: Shift | undefined;
  ngOnInit() {
    console.log(this.shift);
  }
}
