import { Component } from '@angular/core';

@Component({
  selector: 'app-tarefa',
  templateUrl: './tarefa.component.html',
  styleUrl: './tarefa.component.css'
})
export class TarefaComponent {

  id: number = 0;
  constructor() {
    this.id = history.state.idTarefa

    console.log(this.id)
  }
}
