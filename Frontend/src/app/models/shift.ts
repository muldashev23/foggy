import { AppUser } from './appUser';

export interface Shift {
  id: number;
  dayNum: number;
  timeStart: number;
  weekNum: number;
  dateOfShift: string;
  appUserId: number;
  appUser: AppUser;
}
