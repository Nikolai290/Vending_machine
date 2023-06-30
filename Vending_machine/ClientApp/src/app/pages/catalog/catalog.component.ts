import {Component, Input, OnDestroy, OnInit} from '@angular/core';
import {IFormField} from "./catalogInfo";
import {coinFields} from "../../Models/ICoin";
import {HttpClientService} from "../../services/httpClient/http-client.service";

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']
})
export class CatalogComponent implements OnInit{
  @Input() path: string | undefined;
  private readonly coinPath = "coins";
  private readonly productPath = "products";


  data: any[] = [];
  fieldsInfo: IFormField[] = [];

  constructor(private http: HttpClientService){
  }

  initCoinsCatalog(){
    this.http.getAllCoinFulls().subscribe(response => this.data = [...response]);
    this.fieldsInfo = coinFields;
  }

  initProductsCatalog() {

  }

  cleanCatalog(){
    this.fieldsInfo = [];
    this.data = [];
  }

  initByPath(): void {
    switch (this.path){
      case this.coinPath:
        this.initCoinsCatalog();
        return;
      case this.productPath:
        return;
      default:
        return;
    }
  }



  ngOnInit(): void {
    this.initByPath();
  }
}
