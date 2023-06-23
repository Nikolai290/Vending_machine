import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Observable, throwError} from "rxjs";
import { catchError, retry } from "rxjs";
import {Coin} from "../../Models/Coin";

@Injectable({
  providedIn: 'root'
})
export class HttpClientService {

  constructor(private http: HttpClient) { }

  getAllCoins() : Coin[] {
    

    return []
  }

}
