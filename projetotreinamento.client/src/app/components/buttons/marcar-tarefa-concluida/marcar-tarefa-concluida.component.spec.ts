import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MarcarTarefaConcluidaComponent } from './marcar-tarefa-concluida.component';

describe('MarcarTarefaConcluidaComponent', () => {
  let component: MarcarTarefaConcluidaComponent;
  let fixture: ComponentFixture<MarcarTarefaConcluidaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MarcarTarefaConcluidaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MarcarTarefaConcluidaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
