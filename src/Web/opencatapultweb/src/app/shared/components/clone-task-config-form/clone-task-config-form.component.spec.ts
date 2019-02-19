import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CloneTaskConfigFormComponent } from './clone-task-config-form.component';

describe('CloneTaskConfigFormComponent', () => {
  let component: CloneTaskConfigFormComponent;
  let fixture: ComponentFixture<CloneTaskConfigFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CloneTaskConfigFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CloneTaskConfigFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
