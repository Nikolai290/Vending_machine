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

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    CoinPanelComponent,
    ProductsPanelComponent,
    ProductComponent,
    ModalWindowComponent
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
