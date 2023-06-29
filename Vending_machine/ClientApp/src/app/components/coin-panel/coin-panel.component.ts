import {Component, EventEmitter, Input, Output} from '@angular/core';
import {Coin} from "../../Models/Coin";

@Component({
  selector: 'app-coin-panel',
  templateUrl: './coin-panel.component.html',
  styleUrls: ['./coin-panel.component.css']
})
export class CoinPanelComponent {
  @Input() coins: Coin[] = [];
  @Output() onCoinClick = new EventEmitter<number>();


  coinClickHandler(coinId: number): void {
    this.onCoinClick.emit(coinId)
  }
}
