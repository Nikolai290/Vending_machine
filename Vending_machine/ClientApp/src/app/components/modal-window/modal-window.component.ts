import {Component, EventEmitter, Input, Output} from '@angular/core';

@Component({
  selector: 'app-modal-window',
  templateUrl: './modal-window.component.html',
  styleUrls: ['./modal-window.component.css']
})
export class ModalWindowComponent {
  @Input() message: string = "";
  @Input() isShow: boolean = false;
  @Output() showToggleEvent = new EventEmitter<boolean>();

  hideModal(){
    this.showToggleEvent.emit(false);
  }

}
