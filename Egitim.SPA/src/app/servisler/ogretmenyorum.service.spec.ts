import { TestBed } from '@angular/core/testing';

import { OgretmenyorumService } from './ogretmenyorum.service';

describe('OgretmenyorumService', () => {
  let service: OgretmenyorumService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OgretmenyorumService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
