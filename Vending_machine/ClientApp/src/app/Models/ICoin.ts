import {DataType, FieldType, IFormField} from "../pages/catalog/catalogInfo";

export interface ICoinShort {
  id: number;
  name: string;
  value: number
}

export interface ICoinFull {
  id: number;
  name: string;
  value: number;
  stock: number
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

export const coinFields: IFormField[] = [
  {
    humanName: "Идентификатор",
    fieldName: "id",
    dataType: DataType.number,
    fieldType: FieldType.number,
    editable: false
  },
  {
    humanName: "Название",
    fieldName: "name",
    dataType: DataType.string,
    fieldType: FieldType.Text,
    editable: true,
    validator: (value) => (value as string).length > 0,
    invalidMessage: "Введите название."
  },
  {
    humanName: "Ценность",
    fieldName: "value",
    dataType: DataType.number,
    fieldType: FieldType.number,
    editable: true,
    validator: (value) => value > 0,
    invalidMessage: "Значение должно быть больше 0."
  },
  {
    humanName: "Остаток",
    fieldName: "stock",
    dataType: DataType.number,
    fieldType: FieldType.number,
    editable: true,
    validator: (value) => value > 0,
    invalidMessage: "Значение должно быть больше 0."
  },
]
