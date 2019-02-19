import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TaskConfigListFormComponent } from './task-config-list-form.component';

describe('TaskConfigListFormComponent', () => {
  let component: TaskConfigListFormComponent;
  let fixture: ComponentFixture<TaskConfigListFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TaskConfigListFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TaskConfigListFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
