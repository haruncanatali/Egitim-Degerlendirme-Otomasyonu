import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OgretmenlerComponent } from './ogretmenler.component';

describe('OgretmenlerComponent', () => {
  let component: OgretmenlerComponent;
  let fixture: ComponentFixture<OgretmenlerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OgretmenlerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OgretmenlerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
