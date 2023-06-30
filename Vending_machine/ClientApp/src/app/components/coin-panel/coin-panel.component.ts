import {Component, EventEmitter, Input, Output} from '@angular/core';
import {ICoinShort} from "../../Models/ICoin";

@Component({
  selector: 'app-coin-panel',
  templateUrl: './coin-panel.component.html',
  styleUrls: ['./coin-panel.component.css']
})
export class CoinPanelComponent {
  @Input() coins: ICoinShort[] = [];
  @Output() onCoinClick = new EventEmitter<number>();


  coinClickHandler(coinId: number): void {
    this.onCoinClick.emit(coinId)
  }
}
