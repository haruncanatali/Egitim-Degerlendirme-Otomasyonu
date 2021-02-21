import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { OkulYorum } from '../siniflar/okulYorum';

@Injectable({
  providedIn: 'root'
})
export class OkulyorumService {

  constructor(private httpServisi:HttpClient,private router:Router) { }

  path1 = "https://localhost:44379/api/okulYorum/yorumEkle"

  httpOptions = {
    headers:new HttpHeaders({
      'Content-Type':'application/json', 
      'Authorization':'Token' 
    })
  }


  yorumEkle(yorum:OkulYorum){
    return this.httpServisi.post<OkulYorum>(this.path1,yorum,this.httpOptions)
  }

}
