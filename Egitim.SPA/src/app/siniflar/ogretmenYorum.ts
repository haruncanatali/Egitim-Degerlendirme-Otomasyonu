import { Ogretmen } from "./ogretmen";

export class OgretmenYorum{
    id!:number;
    ad!:string;
    soyad!:string;
    mail!:string;
    yorumIcerik!:string;
    puan!:number;
    ogretmenId!:number;
    ogretmeni:Ogretmen=new Ogretmen()
}