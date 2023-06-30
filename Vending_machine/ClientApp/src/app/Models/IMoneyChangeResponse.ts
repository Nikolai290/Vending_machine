import {IMoneyChange} from "./IMoneyChange";

export interface IMoneyChangeResponse
{
  moneyChangeSummary: number;
  moneyChange: IMoneyChange[]
}
