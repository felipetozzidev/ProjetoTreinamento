import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TarefaType } from '../../types/TarefaType';
import { APIResponse } from '../../types/APIResponse';
import { Observable } from 'rxjs';
import { ChecklistType } from '../../types/ChecklistType';

@Injectable({
  providedIn: 'root'
})
export class TarefaService {

  constructor(private http: HttpClient) { }

  listTarefas(): Observable<APIResponse<TarefaType[]>> {
    return this.http.get<APIResponse<TarefaType[]>>(`api/Tarefa/GetAll`)
  }

  getTarefa(id: number): Observable<APIResponse<TarefaType>> {
    return this.http.get<APIResponse<TarefaType>>(`api/Tarefa/GetById/${id}`)
  }

  addTarefa(tarefa: TarefaType): Observable<APIResponse<TarefaType>> {
    return this.http.post<APIResponse<TarefaType>>("api/Tarefa/CreateTarefa", tarefa)
  }

  deleteTarefa(id: number): Observable<void> {
    return this.http.delete<void>(`api/Tarefa/Delete/${id}`)
  }

  updateTarefa(id: number, tarefa: TarefaType): Observable<TarefaType> {
    return this.http.put<TarefaType>(`api/Tarefa/UpdateTarefa/${id}`, tarefa)
  }

  selectTarefaChildren(id: number): Observable<APIResponse<ChecklistType[]>> {
    return this.http.get <APIResponse<ChecklistType[]>>(`api/Tarefa/GetAllChildren/${id}`)
  }
}
