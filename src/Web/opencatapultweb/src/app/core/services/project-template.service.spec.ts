import { TestBed } from '@angular/core/testing';

import { ProjectTemplateService } from './project-template.service';

describe('ProjectTemplateService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ProjectTemplateService = TestBed.get(ProjectTemplateService);
    expect(service).toBeTruthy();
  });
});
