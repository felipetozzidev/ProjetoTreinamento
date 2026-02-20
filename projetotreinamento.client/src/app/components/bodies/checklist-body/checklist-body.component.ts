import { Component, OnInit } from '@angular/core';
import { TarefaService } from '../../../services/tarefas/tarefa.service';
import { TarefaType } from '../../../types/TarefaType';

@Component({
  selector: 'app-checklist-body',
  templateUrl: './checklist-body.component.html',
  styleUrl: './checklist-body.component.css',
})
export class ChecklistBodyComponent implements OnInit {

  tarefas: TarefaType[] = [

  ];

  constructor(private tarefaService: TarefaService) { }

  ngOnInit(): void {
    //this.carregarTarefas();
  }

  //carregarTarefas() {
  //  this.tarefaService.selectTarefaChildren(id).subscribe({
  //    next: (dados) => this.tarefas.push(...dados.retorno),
  //    error: (err) => console.error('Erro ao carregar tarefas', err)
  //  });
  //}
}
