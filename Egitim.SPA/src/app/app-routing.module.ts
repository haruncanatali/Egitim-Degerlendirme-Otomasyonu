import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnasayfaComponent } from './anasayfa/anasayfa.component';
import { OgretmenDetayComponent } from './ogretmen-detay/ogretmen-detay.component';
import { OgretmenlerComponent } from './ogretmenler/ogretmenler.component';
import { OkulDetayComponent } from './okul-detay/okul-detay.component';
import { OkullarComponent } from './okullar/okullar.component';

const routes: Routes = [
  {path:"",pathMatch:"full",redirectTo:"index"},
  {path:"index",component:AnasayfaComponent},
  {path:"Okullar",component:OkullarComponent},
  {path:"Ogretmenler",component:OgretmenlerComponent},
  {path:"okulDetay",component:OkulDetayComponent},
  {path:"ogretmenDetay",component:OgretmenDetayComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
