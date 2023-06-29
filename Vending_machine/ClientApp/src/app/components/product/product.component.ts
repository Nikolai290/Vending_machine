import {Component, EventEmitter, Input, Output} from '@angular/core';
import {IProduct} from "../../Models/IProduct";

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  @Input() product: IProduct | undefined;
  @Output() onProductBuy = new EventEmitter<number>();

  onClickHandler(){
    if(this.product){
      this.onProductBuy.emit(this.product.id);
    }
  }
}
