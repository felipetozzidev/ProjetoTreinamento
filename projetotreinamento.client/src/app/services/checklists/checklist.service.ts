import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ChecklistType } from '../../types/ChecklistType';

@Injectable({
  providedIn: 'root'
})
export class ChecklistService {
  constructor(private http: HttpClient) { }

  listChecklist(): Observable<ChecklistType[]> {
    return this.http.get<ChecklistType[]>(`api/Checklist/GetAll`)
  }

  getChecklist(id: number): Observable<ChecklistType> {
    return this.http.get<ChecklistType>(`api/Checklist/GetById/${id}`)
  }

  addChecklist(checklist: ChecklistType): Observable<ChecklistType> {
    return this.http.post<ChecklistType>("api/Checklist/CreateTarefa", checklist)
  }

  deleteChecklist(id: number): Observable<void> {
    return this.http.delete<void>(`api/Checklist/Delete/${id}`)
  }

  updateChecklist(id: number, checklist: ChecklistType): Observable<ChecklistType> {
    return this.http.put<ChecklistType>(`api/Checklist/UpdateTarefa/${id}`, checklist)
  }
}
