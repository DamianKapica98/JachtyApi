import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JachtyComponent } from './jachty.component';

describe('JachtyComponent', () => {
  let component: JachtyComponent;
  let fixture: ComponentFixture<JachtyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JachtyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JachtyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
