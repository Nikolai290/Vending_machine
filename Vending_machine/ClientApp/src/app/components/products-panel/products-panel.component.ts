import {Component, EventEmitter, Input, Output} from '@angular/core';
import {IProduct} from "../../Models/IProduct";

@Component({
  selector: 'app-products-panel',
  templateUrl: './products-panel.component.html',
  styleUrls: ['./products-panel.component.css']
})
export class ProductsPanelComponent {
  @Input() products: IProduct[] = [];
  @Output() onProductBuy = new EventEmitter<number>();

  productClickHandler(productId: number){
    this.onProductBuy.emit(productId)
  }
}
