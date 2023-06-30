import {Component, Input} from '@angular/core';
import {IMoneyChangeResponse} from "../../Models/IMoneyChangeResponse";

@Component({
  selector: 'app-money-change-info',
  templateUrl: './money-change-info.component.html',
  styleUrls: ['./money-change-info.component.css']
})
export class MoneyChangeInfoComponent {
  @Input() moneyChangeInfo: IMoneyChangeResponse | undefined;

}
