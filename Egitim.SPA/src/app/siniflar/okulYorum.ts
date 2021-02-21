import { Okul } from "./okul";

export class OkulYorum{
    id!:number;
    ad!:string;
    soyad!:string;
    mail!:string;
    yorumIcerik!:string;
    puan!:number;
    okulId!:number;
    okulu:Okul=new Okul()
}