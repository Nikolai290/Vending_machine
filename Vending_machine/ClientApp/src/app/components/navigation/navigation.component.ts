import {Component, Input} from '@angular/core';
import {INavigationData} from "./navigationData";

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent {
  @Input() navData: INavigationData[] = [];
}
