import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-marcar-tarefa-concluida',
  templateUrl: './marcar-tarefa-concluida.component.html',
  styleUrl: './marcar-tarefa-concluida.component.css'
})
export class MarcarTarefaConcluidaComponent {
  @Input({ required: true })
  public idTarefa: number = 0;
  constructor(private route: Router) {

  }

  abrirTarefa() {
    this.route.navigate(["tarefa"], { state: { idTarefa: this.idTarefa } })
  }
}
