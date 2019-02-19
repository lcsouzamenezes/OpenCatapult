import { TestBed } from '@angular/core/testing';

import { ExternalServiceService } from './external-service.service';

describe('ExternalServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ExternalServiceService = TestBed.get(ExternalServiceService);
    expect(service).toBeTruthy();
  });
});
