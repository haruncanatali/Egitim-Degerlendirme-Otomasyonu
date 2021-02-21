import { TestBed } from '@angular/core/testing';

import { OgretmenService } from './ogretmen.service';

describe('OgretmenService', () => {
  let service: OgretmenService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OgretmenService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
