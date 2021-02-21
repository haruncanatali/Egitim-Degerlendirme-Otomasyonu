import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { OgretmenYorum } from '../siniflar/ogretmenYorum';

@Injectable({
  providedIn: 'root'
})
export class OgretmenyorumService {
  path = "https://localhost:44379/api/ogretmenYorum/yorumEkle"

  constructor(private httpServis:HttpClient) { }

  httpOptions = {
    headers:new HttpHeaders({
      'Content-Type':'application/json', 
      'Authorization':'Token' 
    })
  }

  yorumEkle(yorum:OgretmenYorum):Observable<OgretmenYorum>{
    return this.httpServis.post<OgretmenYorum>(this.path,yorum,this.httpOptions)
  }
}
