import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TarefaType } from '../../types/TarefaType';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TarefaService {

  constructor(private http: HttpClient) { }

  listTarefas(): Observable<TarefaType[]> {
    return this.http.get<TarefaType[]>("api/TarefaController")
  }

  getTarefa(id: number): Observable<TarefaType> {
    return this.http.get<TarefaType>(`api/TarefaController/${id}`)
  }

  addTarefa(tarefa: TarefaType): Observable<TarefaType> {
    return this.http.post<TarefaType>("api/TarefaController", tarefa)
  }

  deleteTarefa(id: number): Observable<void> {
    return this.http.delete<void>(`api/TarefaController/${id}`)
  }

  updateTarefa(id: number, tarefa: TarefaType): Observable<TarefaType> {
    return this.http.put<TarefaType>(`api/TarefaController/${id}`, tarefa)
  }
}
