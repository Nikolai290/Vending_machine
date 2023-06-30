import {HttpClient} from "@angular/common/http";
import {ICoinShort, CreateCoin, UpdateCoin, ICoinFull} from "../../Models/ICoin";
import {Injectable} from "@angular/core";
import {Observable} from "rxjs";
import {IProduct} from "../../Models/IProduct";
import {IMoneyChangeResponse} from "../../Models/IMoneyChangeResponse";

@Injectable()
export class HttpClientService {

  readonly baseUrl: string = "http://localhost:5293";
  readonly coinControllerUrl: string = "/CoinType/"
  readonly productControllerUrl: string = "/Product/"
  readonly operationControllerUrl: string = "/Operation/"

  constructor(private http: HttpClient) { }

  getAllCoins() : Observable<ICoinShort[]> {
    return this.http.get<ICoinShort[]>(this.baseUrl.concat(this.coinControllerUrl, "GetAll"));
  }

  getAllCoinFulls() : Observable<ICoinFull[]> {
    return this.http.get<ICoinFull[]>(this.baseUrl.concat(this.coinControllerUrl, "GetAllFull"));
  }


  getCoinById(id:number) : Observable<ICoinShort> {
    return this.http.get<ICoinShort>(this.baseUrl.concat(this.coinControllerUrl, "GetById/", id.toString()))
  }

  createCoin(coin: CreateCoin) : Observable<any> {
    return this.http.post<any>(this.baseUrl.concat(this.coinControllerUrl, "Create"), coin);
  }

  updateCoin(id: number, coin:UpdateCoin) : Observable<any> {
    return this.http.put<any>(this.baseUrl.concat(this.coinControllerUrl, "Update/", id.toString()), coin);
  }

  deleteCoin(id: number){
    return this.http.delete<any>(this.baseUrl.concat(this.coinControllerUrl, "Delete/", id.toString()));
  }

  getAllProducts() : Observable<IProduct[]> {
    return this.http.get<IProduct[]>(this.baseUrl.concat(this.productControllerUrl, "GetAll"));
  }

  getCustomerBalance(): Observable<number> {
    return this.http.get<number>(this.baseUrl.concat(this.operationControllerUrl, "GetCustomerBalance"));
  }

  insertCoin(coinId: number) : Observable<any> {
    return this.http.post<any>(
      this.baseUrl.concat(this.operationControllerUrl, "InsertCoin/", coinId.toString()),
      null);
  }

  buyProduct(productId: number) : Observable<any> {
    return this.http.post<any>(
      this.baseUrl.concat(this.operationControllerUrl, "BuyProduct/", productId.toString()),
      null);
  }

  requestMoneyChange() : Observable<IMoneyChangeResponse> {
    return this.http.post<IMoneyChangeResponse>(
      this.baseUrl.concat(this.operationControllerUrl, "RequestMoneyChange"),
      null);
  }


}
