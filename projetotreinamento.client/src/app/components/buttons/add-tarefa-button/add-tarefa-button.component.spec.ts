import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddTarefaButtonComponent } from './add-tarefa-button.component';

describe('AddTarefaButtonComponent', () => {
  let component: AddTarefaButtonComponent;
  let fixture: ComponentFixture<AddTarefaButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AddTarefaButtonComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AddTarefaButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
