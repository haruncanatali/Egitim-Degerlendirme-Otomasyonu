import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TanitimComponent } from './tanitim.component';

describe('TanitimComponent', () => {
  let component: TanitimComponent;
  let fixture: ComponentFixture<TanitimComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TanitimComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TanitimComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
