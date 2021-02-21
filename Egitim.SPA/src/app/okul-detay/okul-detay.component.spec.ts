import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OkulDetayComponent } from './okul-detay.component';

describe('OkulDetayComponent', () => {
  let component: OkulDetayComponent;
  let fixture: ComponentFixture<OkulDetayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OkulDetayComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OkulDetayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
