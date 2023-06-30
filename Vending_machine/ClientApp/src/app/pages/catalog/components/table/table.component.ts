import {Component, Input} from '@angular/core';
import {ITableColumns} from "../../catalogInfo";

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent {
  @Input() data: any[] = [];
  @Input() columnInfo: ITableColumns[] = [];
}
