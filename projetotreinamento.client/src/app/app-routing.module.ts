import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/pages/home/home.component';
import { TarefaComponent } from './components/pages/tarefa/tarefa.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'tarefa', component: TarefaComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
