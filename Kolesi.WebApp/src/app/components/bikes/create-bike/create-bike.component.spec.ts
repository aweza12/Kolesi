import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateBikeComponent } from './create-bike.component';

describe('CreateBikeComponent', () => {
  let component: CreateBikeComponent;
  let fixture: ComponentFixture<CreateBikeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CreateBikeComponent]
    });
    fixture = TestBed.createComponent(CreateBikeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
