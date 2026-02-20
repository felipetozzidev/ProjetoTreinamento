import { Component } from '@angular/core';
import { MatExpansionModule } from '@angular/material/expansion';

@Component({
  selector: 'app-checklist-body',
  templateUrl: './checklist-body.component.html',
  standalone: true,
  styleUrl: './checklist-body.component.css',
  imports: [
    MatExpansionModule
  ]
})
export class ChecklistBodyComponent {

}
