import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TaskConfigFormComponent } from './task-config-form.component';

describe('TaskConfigFormComponent', () => {
  let component: TaskConfigFormComponent;
  let fixture: ComponentFixture<TaskConfigFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TaskConfigFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TaskConfigFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
