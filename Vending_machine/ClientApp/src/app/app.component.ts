import { Component } from '@angular/core';
import {INavigationData} from "./components/navigation/navigationData";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'drink_vending';
  navData: INavigationData[] = [
    {
      buttonText: "Главная",
      path: "",
      routerLinkActiveOptionsExact: true
    },
    {
      buttonText: "Администрирование",
      path: "/admin",
      routerLinkActiveOptionsExact: false
    },
  ]

}
