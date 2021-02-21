import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OgretmenDetayComponent } from './ogretmen-detay.component';

describe('OgretmenDetayComponent', () => {
  let component: OgretmenDetayComponent;
  let fixture: ComponentFixture<OgretmenDetayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OgretmenDetayComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OgretmenDetayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
