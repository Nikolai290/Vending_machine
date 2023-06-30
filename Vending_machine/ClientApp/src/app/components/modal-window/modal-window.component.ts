import {Component, ContentChild, ElementRef, EventEmitter, Input, Output} from '@angular/core';

@Component({
  selector: 'app-modal-window',
  templateUrl: './modal-window.component.html',
  styleUrls: ['./modal-window.component.css']
})
export class ModalWindowComponent {
  @Input() message: string = "";
  @Input() isShow: boolean = false;
  @Output() showToggleEvent = new EventEmitter<boolean>();

  @ContentChild("modalContent", {static:false})
  header: ElementRef|undefined;

  hideModal(){
    this.showToggleEvent.emit(false);
  }

}
