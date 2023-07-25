import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Qn1Component } from './qn1.component';

describe('Qn1Component', () => {
  let component: Qn1Component;
  let fixture: ComponentFixture<Qn1Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Qn1Component]
    });
    fixture = TestBed.createComponent(Qn1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
