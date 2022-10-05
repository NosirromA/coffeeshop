import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CoffeeProductsComponent } from './coffee-products.component';

describe('CoffeeProductsComponent', () => {
  let component: CoffeeProductsComponent;
  let fixture: ComponentFixture<CoffeeProductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CoffeeProductsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CoffeeProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
