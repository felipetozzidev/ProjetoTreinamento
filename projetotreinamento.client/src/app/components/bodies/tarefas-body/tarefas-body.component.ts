import { Component, Input } from '@angular/core';
import { ChecklistType } from '../../../types/ChecklistType';
import { TarefaService } from '../../../services/tarefas/tarefa.service';
import { ChecklistService } from '../../../services/checklists/checklist.service';
import { ItemType } from '../../../types/ItemType';


@Component({
  selector: 'app-tarefas-body',
  templateUrl: './tarefas-body.component.html',
  styleUrl: './tarefas-body.component.css'
})
export class TarefasBodyComponent {
  @Input({ required: true })
  idTarefa: number = 0;

  idChecklist: number = 1;


  checklists: ChecklistType[] = [

  ];

  items: ItemType[] = [

  ];

  

  constructor(private tarefaService: TarefaService, private checklistService: ChecklistService) { }

  ngOnInit(): void {
    this.carregarChecklists();
    this.carregarItens()
  }

  carregarChecklists() {
    this.tarefaService.selectTarefaChildren(this.idTarefa).subscribe({
      next: (dados) => { console.log(dados); this.checklists.push(...dados.retorno) },
      error: (err) => console.error('Erro ao carregar tarefas', err)
    });
  }

  carregarItens() {
    this.checklistService.listItemsChecklist(this.idChecklist).subscribe({
      next: (dados) => { console.log(dados); this.items.push(...dados.retorno) },
      error: (err) => console.error('Erro ao carregar itens', err)
    });
  }



}
