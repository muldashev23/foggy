import { AppUser } from './appUser';

export interface Shift {
  id: number;
  timeStart: number;
  dateOfShift: string;
  appUserId: number;
  appUser: AppUser;
}
