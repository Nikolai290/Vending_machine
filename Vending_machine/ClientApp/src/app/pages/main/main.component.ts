import {Component, OnInit} from '@angular/core';
import {HttpClientService} from "../../services/httpClient/http-client.service";
import {ICoinShort} from "../../Models/ICoin";
import {IProduct} from "../../Models/IProduct";
import {Sort} from "../../extensions/Sort";
import {IMoneyChangeResponse} from "../../Models/IMoneyChangeResponse";
@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit{

  coins: ICoinShort[] = [];
  products: IProduct[] = [];
  customerBalance: number = 0;
  moneyChangeInfo:IMoneyChangeResponse | undefined;
  isShowModal:boolean = false;
  purchasedProduct: IProduct | undefined;


  constructor(private httpClientService: HttpClientService) {
  }

  ngOnInit(): void {
    this.updateCoins();
    this.updateProducts();
    this.updateCustomerBalance();
  }

  coinClickHandler(coinId: number) {
    this.httpClientService.insertCoin(coinId).subscribe(() => this.updateCustomerBalance());
  }

  productClickHandler(productId: number) {
    this.httpClientService.buyProduct(productId).subscribe(response => {
      this.purchasedProduct = response;
      this.updateCustomerBalance();
      this.updateProducts();
      this.showModalHandler(true)
    })
  }

  requestMoneyChangeClickHandler(){
    this.httpClientService.requestMoneyChange().subscribe((response)=>{
      this.moneyChangeInfo = response;
      this.updateCustomerBalance();
      this.showModalHandler(true)
    })
  }

  showModalHandler(show: boolean) {
    if(show == false){
      this.moneyChangeInfo = undefined;
      this.purchasedProduct = undefined;
    }
    this.isShowModal = show;
  }

  updateCoins(){
    this.httpClientService.getAllCoins()
      .subscribe(data => this.coins = [...data.sort((a, b) => Sort.byAsc(a.value, b.value))]);
  }
  updateProducts(){
    this.httpClientService.getAllProducts()
      .subscribe(data =>
        this.products = [...data.sort((a, b) => Sort.byAlphabet(a.name, b.name))])
  }

  updateCustomerBalance(){
    this.httpClientService.getCustomerBalance()
      .subscribe(data => this.customerBalance = data);
  }
}
