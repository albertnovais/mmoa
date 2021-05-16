import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AuthenticadComponent } from './authenticad.component';

describe('AuthenticadComponent', () => {
  let component: AuthenticadComponent;
  let fixture: ComponentFixture<AuthenticadComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AuthenticadComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AuthenticadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
