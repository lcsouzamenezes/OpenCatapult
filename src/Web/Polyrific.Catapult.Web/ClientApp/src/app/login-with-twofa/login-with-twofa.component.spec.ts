import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginWithTwofaComponent } from './login-with-twofa.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatProgressBarModule, MatInputModule, MatCardModule, MatIconModule } from '@angular/material';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterTestingModule } from '@angular/router/testing';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { AuthService } from '@app/core/auth/auth.service';

describe('LoginWithTwofaComponent', () => {
  let component: LoginWithTwofaComponent;
  let fixture: ComponentFixture<LoginWithTwofaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoginWithTwofaComponent ],
      imports: [
        BrowserAnimationsModule,
        MatProgressBarModule,
        ReactiveFormsModule,
        MatInputModule,
        MatCardModule,
        RouterTestingModule,
        HttpClientTestingModule,
        MatIconModule
      ],
      providers: [ AuthService ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginWithTwofaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
