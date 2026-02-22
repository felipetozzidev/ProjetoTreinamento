import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ChecklistType } from '../../types/ChecklistType';
import { APIResponse } from '../../types/APIResponse';
import { ItemType } from '../../types/ItemType';

@Injectable({
  providedIn: 'root'
})
export class ChecklistService {
  constructor(private http: HttpClient) { }

  listChecklist(): Observable<APIResponse<ChecklistType[]>> {
    return this.http.get<APIResponse<ChecklistType[]>>(`api/Checklist/GetAll`)
  }

  getChecklist(id: number): Observable<APIResponse<ChecklistType>> {
    return this.http.get<APIResponse<ChecklistType>>(`api/Checklist/GetById/${id}`)
  }

  addChecklist(checklist: ChecklistType): Observable<APIResponse<ChecklistType>> {
    return this.http.post<APIResponse<ChecklistType>>("api/Checklist/CreateTarefa", checklist)
  }

  deleteChecklist(id: number): Observable<void> {
    return this.http.delete<void>(`api/Checklist/Delete/${id}`)
  }

  updateChecklist(id: number, checklist: ChecklistType): Observable<APIResponse<ChecklistType>> {
    return this.http.put<APIResponse<ChecklistType>>(`api/Checklist/UpdateTarefa/${id}`, checklist)
  }

  listItemsChecklist(id: number): Observable<APIResponse<ItemType[]>> {
    return this.http.get<APIResponse<ItemType[]>>(`api/checklist/GetAllChildren/${id}`)
  }
}
