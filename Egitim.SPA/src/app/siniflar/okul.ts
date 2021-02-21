import { Ogretmen } from "./ogretmen";
import { OkulYorum } from "./okulYorum";

export class Okul{
    id!:number;
    okulAdi!:string;
    okulAciklama!:string;
    okulPuan!:number;
    fotoBaglantisi!:string;
    ogretmenler:Ogretmen[] = []
    yorumlar:OkulYorum[]=[]
}