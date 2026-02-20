import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddTarefaButtonComponent } from './components/buttons/add-tarefa-button/add-tarefa-button.component';
import { DefaultHeaderComponent } from './components/headers/default-header/default-header.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { CardsBodyComponent } from './components/bodies/cards-body/cards-body.component';
import { MarcarTarefaConcluidaComponent } from './components/buttons/marcar-tarefa-concluida/marcar-tarefa-concluida.component';
import { TarefasBodyComponent } from './components/bodies/tarefas-body/tarefas-body.component';
import { MarcarTarefaConcluidaIndigoComponent } from './components/buttons/marcar-tarefa-concluida-indigo/marcar-tarefa-concluida-indigo.component';
import { ChecklistBodyComponent } from './components/bodies/checklist-body/checklist-body.component';

@NgModule({
  declarations: [
    AppComponent,
    AddTarefaButtonComponent,
    DefaultHeaderComponent,
    CardsBodyComponent,
    MarcarTarefaConcluidaComponent,
    TarefasBodyComponent,
    MarcarTarefaConcluidaIndigoComponent,
    ChecklistBodyComponent,
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, CommonModule,
    FormsModule,
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
