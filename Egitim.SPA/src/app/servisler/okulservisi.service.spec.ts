import { TestBed } from '@angular/core/testing';

import { OkulservisiService } from './okulservisi.service';

describe('OkulservisiService', () => {
  let service: OkulservisiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OkulservisiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
