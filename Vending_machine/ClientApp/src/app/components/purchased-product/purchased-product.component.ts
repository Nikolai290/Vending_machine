import {Component, Input} from '@angular/core';
import {IProduct} from "../../Models/IProduct";

@Component({
  selector: 'app-purchased-product',
  templateUrl: './purchased-product.component.html',
  styleUrls: ['./purchased-product.component.css']
})
export class PurchasedProductComponent {
  @Input() purchasedProduct: IProduct | undefined;
}
