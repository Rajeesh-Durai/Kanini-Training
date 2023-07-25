import { Component } from '@angular/core';
import { Product } from './Product';
import { ProductService } from './product.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'AngularService';
  products!: Product[];
  // productService;

  // constructor(){
  //   this.productService=new ProductService();
  // }

  constructor(private productService: ProductService) {}

  getProductsfromService() {
    this.products = this.productService.getProducts();
  }
}
