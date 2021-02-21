import { OgretmenYorum } from "./ogretmenYorum";
import { Okul } from "./okul";

export class Ogretmen{
    id!:number;
    ogretmenAdSoyad!:string;
    ogretmenBrans!:string;
    ogretmenAciklama!:string;
    ogretmenPuan!:number;
    fotoBaglantisi!:string;
    ogretmenPozisyon!:string;
    okulId!:number;
    okulu:Okul=new Okul()
    yorumlar:OgretmenYorum[]=[]
}