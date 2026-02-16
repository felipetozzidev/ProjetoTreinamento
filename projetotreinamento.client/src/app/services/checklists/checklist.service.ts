import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ChecklistType } from '../../types/ChecklistType';

@Injectable({
  providedIn: 'root'
})
export class ChecklistService {
  constructor(private http: HttpClient) { }

  listTarefas(): Observable<ChecklistType[]> {
    return this.http.get<ChecklistType[]>("api/TarefaController")
  }

  getTarefa(id: number): Observable<ChecklistType> {
    return this.http.get<ChecklistType>(`api/TarefaController/${id}`)
  }

  addTarefa(checklist: ChecklistType): Observable<ChecklistType> {
    return this.http.post<ChecklistType>("api/TarefaController", checklist)
  }

  deleteTarefa(id: number): Observable<void> {
    return this.http.delete<void>(`api/TarefaController/${id}`)
  }

  updateTarefa(id: number, checklist: ChecklistType): Observable<ChecklistType> {
    return this.http.put<ChecklistType>(`api/TarefaController/${id}`, checklist)
  }
}
