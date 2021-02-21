import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { StarRatingComponent } from 'ng-starrating';
import { OgretmenService } from '../servisler/ogretmen.service';
import { OkulservisiService } from '../servisler/okulservisi.service';
import { OkulyorumService } from '../servisler/okulyorum.service';
import { Okul } from '../siniflar/okul';
import { OkulYorum } from '../siniflar/okulYorum';

@Component({
  selector: 'app-okul-detay',
  templateUrl: './okul-detay.component.html',
  styleUrls: ['./okul-detay.component.css']
})
export class OkulDetayComponent implements OnInit {

  okul : Okul = new Okul()
  yorum : OkulYorum = new OkulYorum()
  currentRate = 0;

  constructor(private okulServis:OkulservisiService,private okulYorumServis:OkulyorumService,private ogretmenServisi:OgretmenService) {
    this.okul = new Okul()
    this.okul = this.okulServis.okul
    this.currentRate = this.okul.okulPuan
   }

  ngOnInit(): void {
  }

  ogretmeneGit(id:number){
    this.ogretmenServisi.ogretmenYonlendirme(id)
  }

  yorumYap(form:NgForm){
    this.yorum.okulId = this.okul.id
    this.okulYorumServis.yorumEkle(this.yorum).subscribe(
      (res:any)=>{
        this.okulServis.okulGetir(this.okul.id).subscribe(data=>{
          this.okul = data
        })
      },
      err=>{
        alert("Yorum yapma işlemi başarısız oldu");
      }
    )
    form.resetForm();
  }

  onRate($event:{oldValue:number, newValue:number, starRating:StarRatingComponent}) {
    alert(`Old Value:${$event.oldValue}, 
      New Value: ${$event.newValue}, 
      Checked Color: ${$event.starRating.checkedcolor}, 
      Unchecked Color: ${$event.starRating.uncheckedcolor}`);
  }

}
