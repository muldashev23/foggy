import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { addShift } from '../models/addShift';
@Injectable({
  providedIn: 'root',
})
export class ShiftService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  loadShifts() {
    return this.http.get<any>(this.baseUrl + 'shift');
  }

  createWeekShift(weekshifts: addShift[]) {
    return this.http.post(this.baseUrl + 'shift/week', weekshifts);
  }
}
