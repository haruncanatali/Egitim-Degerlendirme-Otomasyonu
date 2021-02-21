import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { OgretmenService } from '../servisler/ogretmen.service';
import { OgretmenyorumService } from '../servisler/ogretmenyorum.service';
import { Ogretmen } from '../siniflar/ogretmen';
import { OgretmenYorum } from '../siniflar/ogretmenYorum';

@Component({
  selector: 'app-ogretmen-detay',
  templateUrl: './ogretmen-detay.component.html',
  styleUrls: ['./ogretmen-detay.component.css']
})
export class OgretmenDetayComponent implements OnInit {

  constructor(private ogretmenServisi:OgretmenService,private ogretmenYorumServis:OgretmenyorumService) { }

  ogretmen : Ogretmen = new Ogretmen()
  yorum : OgretmenYorum = new OgretmenYorum()

  ngOnInit(): void {
    this.atamaIslemi()
  }

  atamaIslemi(){
    this.ogretmenServisi.ogretmenGetir().subscribe(data=>{
      this.ogretmen = data
    })
  }

  yorumYap(form:NgForm){
    this.yorum.ogretmenId = this.ogretmen.id
    this.ogretmenYorumServis.yorumEkle(this.yorum).subscribe(
      (res:any)=>{
        this.atamaIslemi()
      },
      err=>{
        if(err.status == 400){
          alert("Güncelleme işlemi başarısız oldu")
        }
      }
    )
    form.resetForm();

  }

}
