import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainLayoutComponent } from './main-layout/main-layout.component';
import { NavComponent } from './main-layout/nav/nav.component';
import { SearchComponent } from './main-layout/nav/search/search.component';
import { HomeComponent } from './home/home.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { BasketComponent } from './basket/basket.component';
import { CoffeeProductsComponent } from './coffee-products/coffee-products.component';

@NgModule({
  declarations: [
    AppComponent,
    MainLayoutComponent,
    NavComponent,
    SearchComponent,
    HomeComponent,
    CheckoutComponent,
    BasketComponent,
    CoffeeProductsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
