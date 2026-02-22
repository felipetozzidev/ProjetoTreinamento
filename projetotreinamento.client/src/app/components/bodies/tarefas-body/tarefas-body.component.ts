import { Component, Input, ViewChildren, QueryList, ElementRef, AfterViewInit } from '@angular/core';
import { ChecklistType } from '../../../types/ChecklistType';
import { TarefaService } from '../../../services/tarefas/tarefa.service';
import { ChecklistService } from '../../../services/checklists/checklist.service';
import { ItemType } from '../../../types/ItemType';


@Component({
  selector: 'app-tarefas-body',
  templateUrl: './tarefas-body.component.html',
  styleUrl: './tarefas-body.component.css'
})
export class TarefasBodyComponent implements AfterViewInit {
  @Input({ required: true })
  idTarefa: number = 0;

  idChecklist: number = 0;


  checklists: ChecklistType[] = [

  ];

  itemsPorChecklist: Record<number, ItemType[]> = {};

  constructor(private tarefaService: TarefaService, private checklistService: ChecklistService) { }

  @ViewChildren('card') cards!: QueryList<ElementRef>;

  ngAfterViewInit(): void {
    this.cards.changes.subscribe(() => {
      const listaCards = this.cards.toArray();
      console.log('Cards renderizados:', listaCards);

      listaCards.forEach((card, index) => {
        const element = card.nativeElement;
        console.log(`Card ${index}:`, element.id, element.textContent);
        this.carregarItensPorChecklist;
      });
    });
  }

  ngOnInit(): void {
    this.carregarChecklists();

  }

  carregarChecklists() {
    this.tarefaService.selectTarefaChildren(this.idTarefa).subscribe({
      next: (dados) => {
        this.checklists = dados.retorno;

        // Agora carrega os itens do checklist de forma individual
        this.checklists.forEach(ch => {
          this.carregarItensPorChecklist(ch.id);
        });
      },
    });
  }

  carregarItensPorChecklist(idChecklist: number) {
    this.checklistService.listItemsChecklist(idChecklist).subscribe({
      next: (dados) => {
        this.itemsPorChecklist[idChecklist] = dados.retorno;
      },
      error: err => console.error('Erro ao carregar itens', err)
    });
  }



}
