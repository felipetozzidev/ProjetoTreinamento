import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChecklistBodyComponent } from './checklist-body.component';

describe('ChecklistBodyComponent', () => {
  let component: ChecklistBodyComponent;
  let fixture: ComponentFixture<ChecklistBodyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ChecklistBodyComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ChecklistBodyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
