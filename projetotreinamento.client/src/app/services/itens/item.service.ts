import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ItemType } from '../../types/ItemType';

@Injectable({
  providedIn: 'root'
})
export class ItemService {
  constructor(private http: HttpClient) { }

  listTarefas(): Observable<ItemType[]> {
    return this.http.get<ItemType[]>("api/TarefaController")
  }

  getTarefa(id: number): Observable<ItemType> {
    return this.http.get<ItemType>(`api/TarefaController/${id}`)
  }

  addTarefa(item: ItemType): Observable<ItemType> {
    return this.http.post<ItemType>("api/TarefaController", item)
  }

  deleteTarefa(id: number): Observable<void> {
    return this.http.delete<void>(`api/TarefaController/${id}`)
  }

  updateTarefa(id: number, item: ItemType): Observable<ItemType> {
    return this.http.put<ItemType>(`api/TarefaController/${id}`, item)
  }
}
