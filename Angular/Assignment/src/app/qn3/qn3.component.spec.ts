import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Qn3Component } from './qn3.component';

describe('Qn3Component', () => {
  let component: Qn3Component;
  let fixture: ComponentFixture<Qn3Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Qn3Component]
    });
    fixture = TestBed.createComponent(Qn3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
