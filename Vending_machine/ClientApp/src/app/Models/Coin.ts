export class Coin implements ICoin {
  id: number;
  name: string;
  value: number;

  constructor(
    id: number,
    name: string,
    value: number
  ) {
    this.id = id;
    this.name = name;
    this.value = value;
  }

}

export class CreateCoin {
  constructor(
    name: string,
    value: number,
    stock: number
  ) {
  }
}

export class UpdateCoin {
  constructor(
    name: string,
    value: number,
    stock: number
  ) {
  }
}

export interface ICoin {
  id: number;
  name: string;
  value: number
}
