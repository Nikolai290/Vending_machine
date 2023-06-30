import {Component, OnDestroy} from '@angular/core';
import {INavigationData} from "../../components/navigation/navigationData";


@Component({
  selector: 'app-administator-page',
  templateUrl: './administator-page.component.html',
  styleUrls: ['./administator-page.component.css']
})
export class AdministatorPageComponent {
  adminNavData: INavigationData[] = [
    {
      buttonText: "Монеты",
      path: "coins",
      routerLinkActiveOptionsExact: false
    },
    {
      buttonText: "Продукты",
      path: "products",
      routerLinkActiveOptionsExact: false
    },
  ]
}
