import { Component, OnInit } from '@angular/core';
import { OkulservisiService } from '../servisler/okulservisi.service';
import { Okul } from '../siniflar/okul';

@Component({
  selector: 'app-okullar',
  templateUrl: './okullar.component.html',
  styleUrls: ['./okullar.component.css']
})
export class OkullarComponent implements OnInit {

  constructor(private okulServis:OkulservisiService) { }

  okul:Okul[] = []

  ngOnInit(): void {
    this.okulServis.okullariListele().subscribe(data=>{
      this.okul = data
    })
  }

  detayaGit(item:Okul){
    this.okulServis.okulaGit(item)
  }

}
