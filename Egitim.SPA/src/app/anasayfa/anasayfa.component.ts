import { Component, OnInit } from '@angular/core';
import * as Chart from 'chart.js';

@Component({
  selector: 'app-anasayfa',
  templateUrl: './anasayfa.component.html',
  styleUrls: ['./anasayfa.component.css']
})
export class AnasayfaComponent implements OnInit {

  canvas:any;
  ctx:any;

  asda!:string

  constructor() { }

  ngOnInit(): void {
  
    this.canvas  = document.getElementById('myChart');
  this.ctx = this.canvas.getContext('2d');
  const myChart = new Chart(this.ctx, {
      type: 'bar',
      data: {
      labels: ['Marmara Bölgesi', 'Karadeniz Bölgesi', 'Doğu Anadolu Bölgesi', 'Güneydoğu Anadolu Bölgesi', 'Akdeniz Bölgesi', 'Ege Bölgesi', 'İç Anadolu Bölgesi'],
        datasets: [{
          label: 'Bölgelere Göre Ulaşılan Üniversiteler',
          data: [41, 13, 14, 7, 10, 15,30],
          backgroundColor: ['red','orange','pink','cyan','yellow','blue','brown'],
          borderWidth: 1
        }]
      },
      options: {
      legend: {
      display: false
      },
      responsive: false,
      }
});
    
  }
}
