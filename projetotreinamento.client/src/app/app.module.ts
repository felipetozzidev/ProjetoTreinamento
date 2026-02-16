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

@NgModule({
  declarations: [
    AppComponent,
    AddTarefaButtonComponent,
    DefaultHeaderComponent,
    CardsBodyComponent,
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
