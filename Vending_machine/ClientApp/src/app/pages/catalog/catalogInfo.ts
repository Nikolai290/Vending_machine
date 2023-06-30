export interface ITableColumns {
  humanName: string;
  fieldName: string;
}

export interface IFormField extends ITableColumns {
  dataType: DataType;
  fieldType: FieldType;
  editable?: boolean;
  validator?: (value: any) => boolean,
  invalidMessage?: string
}

export enum DataType {
  string ,
  number,
  boolean
}

export enum FieldType {
  Text,
  TextField,
  number,
  Checkbox,
}
