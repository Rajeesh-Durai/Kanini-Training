import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Qn2Component } from './qn2.component';

describe('Qn2Component', () => {
  let component: Qn2Component;
  let fixture: ComponentFixture<Qn2Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Qn2Component]
    });
    fixture = TestBed.createComponent(Qn2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
