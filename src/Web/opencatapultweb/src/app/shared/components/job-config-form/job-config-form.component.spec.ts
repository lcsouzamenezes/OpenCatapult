import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { JobConfigFormComponent } from './job-config-form.component';

describe('JobConfigFormComponent', () => {
  let component: JobConfigFormComponent;
  let fixture: ComponentFixture<JobConfigFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JobConfigFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JobConfigFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
