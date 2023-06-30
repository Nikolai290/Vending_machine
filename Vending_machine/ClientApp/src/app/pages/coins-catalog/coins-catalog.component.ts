import {Component, OnInit} from '@angular/core';
import {HttpClientService} from "../../services/httpClient/http-client.service";
import {coinFields, ICoinFull} from "../../Models/ICoin";
import {IFormField} from "../catalog/catalogInfo";

@Component({
  selector: 'app-coins-catalog',
  templateUrl: './coins-catalog.component.html',
  styleUrls: ['./coins-catalog.component.css']
})
export class CoinsCatalogComponent implements OnInit{
  data: ICoinFull[] | undefined;
  fields: IFormField[] = coinFields;

  constructor(private http: HttpClientService) {
  }

  ngOnInit(): void {
    this.http.getAllCoinFulls().subscribe(response => {
      console.log("response", response)
      this.data = [...response]
    });
    console.log("this.data", this.data)
  }

}
