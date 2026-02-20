import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MarcarTarefaConcluidaIndigoComponent } from './marcar-tarefa-concluida-indigo.component';

describe('MarcarTarefaConcluidaIndigoComponent', () => {
  let component: MarcarTarefaConcluidaIndigoComponent;
  let fixture: ComponentFixture<MarcarTarefaConcluidaIndigoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MarcarTarefaConcluidaIndigoComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MarcarTarefaConcluidaIndigoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
