import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TarefasBodyComponent } from './tarefas-body.component';

describe('TarefasBodyComponent', () => {
  let component: TarefasBodyComponent;
  let fixture: ComponentFixture<TarefasBodyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TarefasBodyComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TarefasBodyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
