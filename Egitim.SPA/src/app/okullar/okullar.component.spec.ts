import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OkullarComponent } from './okullar.component';

describe('OkullarComponent', () => {
  let component: OkullarComponent;
  let fixture: ComponentFixture<OkullarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OkullarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OkullarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
