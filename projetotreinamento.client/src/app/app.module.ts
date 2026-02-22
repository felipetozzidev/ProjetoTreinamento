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
import { MatExpansionModule } from '@angular/material/expansion';
import { MatMenuModule } from '@angular/material/menu';
import { HomeComponent } from './components/pages/home/home.component';
import { TarefaComponent } from './components/pages/tarefa/tarefa.component';
import { MatIconModule } from '@angular/material/icon';
import { OptionsTarefaButtonComponent } from './components/buttons/options-tarefa-button/options-tarefa-button.component';
import { MatCheckboxModule } from '@angular/material/checkbox';

@NgModule({
  declarations: [
    AppComponent,
    AddTarefaButtonComponent,
    DefaultHeaderComponent,
    CardsBodyComponent,
    MarcarTarefaConcluidaComponent,
    TarefasBodyComponent,
    MarcarTarefaConcluidaIndigoComponent,
    HomeComponent,
    TarefaComponent,
    OptionsTarefaButtonComponent,
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, CommonModule,
    FormsModule, MatExpansionModule,
    MatMenuModule, MatIconModule,
    MatCheckboxModule,
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
