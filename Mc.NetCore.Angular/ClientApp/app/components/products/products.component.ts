import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Category } from '../../enums';
import { Product } from '../../interfaces';
import { HttpService } from '../../shared/services/http.service';

@Component({
    selector: 'products',
    templateUrl: './products.component.html'
})
export class ProductsComponent {
    private products: Product[];
    private category = Category;

    constructor(http: HttpService, @Inject('BASE_URL') baseUrl: string) {
        this.products = http.get<Product>(baseUrl + 'api/products');
    }
}
