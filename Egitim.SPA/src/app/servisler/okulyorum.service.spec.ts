import { TestBed } from '@angular/core/testing';

import { OkulyorumService } from './okulyorum.service';

describe('OkulyorumService', () => {
  let service: OkulyorumService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OkulyorumService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
