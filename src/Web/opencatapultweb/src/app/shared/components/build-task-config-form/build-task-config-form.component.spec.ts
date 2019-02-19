import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BuildTaskConfigFormComponent } from './build-task-config-form.component';

describe('BuildTaskConfigFormComponent', () => {
  let component: BuildTaskConfigFormComponent;
  let fixture: ComponentFixture<BuildTaskConfigFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BuildTaskConfigFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BuildTaskConfigFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
