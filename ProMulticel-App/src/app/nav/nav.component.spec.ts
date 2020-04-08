/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { navComponent } from './nav.component';

describe('navComponent', () => {
  let component: navComponent;
  let fixture: ComponentFixture<navComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ navComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(navComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
