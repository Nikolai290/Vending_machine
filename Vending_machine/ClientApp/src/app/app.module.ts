import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './pages/main/main.component';
import { CoinPanelComponent } from './components/coin-panel/coin-panel.component';
import {HttpClientService} from "./services/httpClient/http-client.service";
import {HttpClient, HttpClientModule} from "@angular/common/http";
import { ProductsPanelComponent } from './components/products-panel/products-panel.component';
import { ProductComponent } from './components/product/product.component';
import { ModalWindowComponent } from './components/modal-window/modal-window.component';
import { MoneyChangeInfoComponent } from './components/money-change-info/money-change-info.component';
import { PurchasedProductComponent } from './components/purchased-product/purchased-product.component';
import { AdministatorPageComponent } from './pages/administator-page/administator-page.component';
import { NavigationComponent } from './components/navigation/navigation.component';
import { CatalogComponent } from './pages/catalog/catalog.component';
import { TableComponent } from './pages/catalog/components/table/table.component';
import { CoinsCatalogComponent } from './pages/coins-catalog/coins-catalog.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    CoinPanelComponent,
    ProductsPanelComponent,
    ProductComponent,
    ModalWindowComponent,
    MoneyChangeInfoComponent,
    PurchasedProductComponent,
    AdministatorPageComponent,
    NavigationComponent,
    CatalogComponent,
    TableComponent,
    CoinsCatalogComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [HttpClientService],
  bootstrap: [AppComponent]
})
export class AppModule { }
