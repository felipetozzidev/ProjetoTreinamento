import { Component, Input } from '@angular/core';
import { ChecklistType } from '../../../types/ChecklistType';
import { TarefaService } from '../../../services/tarefas/tarefa.service';


@Component({
  selector: 'app-tarefas-body',
  templateUrl: './tarefas-body.component.html',
  styleUrl: './tarefas-body.component.css'
})
export class TarefasBodyComponent {
  @Input({ required: true })
  idTarefa: number = 0;


  tarefas: ChecklistType[] = [

  ];

  constructor(private tarefaService: TarefaService) { }

  ngOnInit(): void {
    this.carregarChecklists();
  }

  carregarChecklists() {
    this.tarefaService.selectTarefaChildren(this.idTarefa).subscribe({
      next: (dados) => { console.log(dados); this.tarefas.push(...dados.retorno) },
      error: (err) => console.error('Erro ao carregar tarefas', err)
    });
  }



}
