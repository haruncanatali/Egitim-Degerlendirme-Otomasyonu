import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AnasayfaComponent } from './anasayfa/anasayfa.component';
import { TanitimComponent } from './tanitim/tanitim.component';
import { OkullarComponent } from './okullar/okullar.component';
import { OkulDetayComponent } from './okul-detay/okul-detay.component';
import { OgretmenlerComponent } from './ogretmenler/ogretmenler.component';
import { OgretmenDetayComponent } from './ogretmen-detay/ogretmen-detay.component';
import { NavComponent } from './nav/nav.component';
import {HttpClientModule} from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ChartsModule } from 'ng2-charts';


@NgModule({
  declarations: [
    AppComponent,
    AnasayfaComponent,
    TanitimComponent,
    OkullarComponent,
    OkulDetayComponent,
    OgretmenlerComponent,
    OgretmenDetayComponent,
    NavComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ChartsModule,
    HttpClientModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
