import { HttpClient, HttpClientModule, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Okul } from '../siniflar/okul';

@Injectable({
  providedIn: 'root'
})
export class OkulservisiService {

  okul : Okul = new Okul()
  path1 = "https://localhost:44379/api/okul/okulListele"
  path2 = "https://localhost:44379/api/okul/okulGetir"

  constructor(private httpServis:HttpClient,private router:Router) { }

  httpOptions = {
    headers:new HttpHeaders({
      'Content-Type':'application/json', 
      'Authorization':'Token' 
    })
  }

  okullariListele():Observable<Okul[]>{
    return this.httpServis.get<Okul[]>(this.path1)
  }
  okulGetir(id:number):Observable<Okul>{
    return this.httpServis.get<Okul>(this.path2+"?id="+id)
  }

  okulaGit(item:Okul){
    this.okul = item
    this.router.navigateByUrl('/okulDetay')
  }
  
}
