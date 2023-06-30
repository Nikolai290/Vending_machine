import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {MainComponent} from "./pages/main/main.component";
import {AdministatorPageComponent} from "./pages/administator-page/administator-page.component";
import {CatalogComponent} from "./pages/catalog/catalog.component";
import {CoinsCatalogComponent} from "./pages/coins-catalog/coins-catalog.component";

const adminRoutes = [
  {path: "coins", component: CoinsCatalogComponent},
  {path: "products", component: CatalogComponent},

]

const routes: Routes = [
  {path: "", component: MainComponent},
  {path: "admin", component: AdministatorPageComponent, children: adminRoutes},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
