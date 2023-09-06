import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadyBikesComponent } from './ready-bikes.component';

describe('ReadyBikesComponent', () => {
  let component: ReadyBikesComponent;
  let fixture: ComponentFixture<ReadyBikesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ReadyBikesComponent]
    });
    fixture = TestBed.createComponent(ReadyBikesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
