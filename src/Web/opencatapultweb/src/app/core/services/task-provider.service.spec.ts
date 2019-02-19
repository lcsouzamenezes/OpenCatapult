import { TestBed } from '@angular/core/testing';

import { TaskProviderService } from './task-provider.service';

describe('TaskProviderService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: TaskProviderService = TestBed.get(TaskProviderService);
    expect(service).toBeTruthy();
  });
});
