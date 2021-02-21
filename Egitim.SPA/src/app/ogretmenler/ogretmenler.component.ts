import { Component, OnInit } from '@angular/core';
import { OgretmenService } from '../servisler/ogretmen.service';
import { Ogretmen } from '../siniflar/ogretmen';

@Component({
  selector: 'app-ogretmenler',
  templateUrl: './ogretmenler.component.html',
  styleUrls: ['./ogretmenler.component.css']
})
export class OgretmenlerComponent implements OnInit {

  ogretmenler : Ogretmen[] = []

  constructor(private ogretmenServisi:OgretmenService) { }

  ngOnInit(): void {
    this.ogretmenServisi.ogretmenleriGetir().subscribe(data=>{
      this.ogretmenler = data
    })
  }

  detayaGit(item:Ogretmen){
    this.ogretmenServisi.ogretmenYonlendirme(item.id)
  }

}
