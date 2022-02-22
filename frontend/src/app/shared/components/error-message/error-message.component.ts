import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-error-message',
  templateUrl: './error-message.component.html',
  styleUrls: ['./error-message.component.scss'],
})
export class ErrorMessageComponent implements OnInit {
  @Input() message: string;
  @Input() field: AbstractControl;

  constructor() { }

  ngOnInit() {}


  shouldShowComponent() {
    if(this.field.touched && this.field.errors) return true;
    return false;
  }
}
