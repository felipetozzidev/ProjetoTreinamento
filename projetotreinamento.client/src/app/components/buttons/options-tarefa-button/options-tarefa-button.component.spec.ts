import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OptionsTarefaButtonComponent } from './options-tarefa-button.component';

describe('OptionsTarefaButtonComponent', () => {
  let component: OptionsTarefaButtonComponent;
  let fixture: ComponentFixture<OptionsTarefaButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [OptionsTarefaButtonComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(OptionsTarefaButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
