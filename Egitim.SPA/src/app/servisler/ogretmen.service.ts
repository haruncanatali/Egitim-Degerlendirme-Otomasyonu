import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Ogretmen } from '../siniflar/ogretmen';

@Injectable({
  providedIn: 'root'
})
export class OgretmenService {
  
  id!:number
  path = "https://localhost:44379/api/ogretmen/ogretmenGetir"
  path1="https://localhost:44379/api/ogretmen/tumOgretmenleriListele"

  constructor(private httpServisi:HttpClient,private router:Router) { }

  httpOptions = {
    headers:new HttpHeaders({
      'Content-Type':'application/json', 
      'Authorization':'Token' 
    })
  }

  ogretmenYonlendirme(id:number){
    this.id = id
    this.router.navigateByUrl('/ogretmenDetay')
  }

  ogretmenGetir():Observable<Ogretmen>{
    return this.httpServisi.get<Ogretmen>(this.path+"?id="+this.id)
  }

  ogretmenleriGetir():Observable<Ogretmen[]>{
    return this.httpServisi.get<Ogretmen[]>(this.path1)
  }


}
