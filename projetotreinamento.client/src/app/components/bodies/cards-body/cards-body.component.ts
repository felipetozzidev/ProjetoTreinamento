import { Component, OnInit } from '@angular/core';
import { TarefaService } from '../../../services/tarefas/tarefa.service';
import { TarefaType } from '../../../types/TarefaType';

@Component({
  selector: 'app-cards-body',
  templateUrl: './cards-body.component.html',
  styleUrl: './cards-body.component.css'
})
export class CardsBodyComponent implements OnInit {

  tarefas: TarefaType[] = [
      
  ];

  constructor(private tarefaService: TarefaService) { }

  ngOnInit(): void {
    this.carregarTarefas();
  }

  carregarTarefas() {
    this.tarefaService.listTarefas().subscribe({
      next: (dados) => this.tarefas.push(...dados.retorno),
      error: (err) => console.error('Erro ao carregar tarefas', err)
    });
  }
  
}
