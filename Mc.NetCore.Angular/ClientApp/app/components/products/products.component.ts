import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Category } from '../../enums';
import { Product } from '../../interfaces';

@Component({
    selector: 'products',
    templateUrl: './products.component.html'
})
export class ProductsComponent {
    private products: Product[];
    private category = Category;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/products').subscribe(result => {
            this.products = result.json() as Product[];
        }, error => console.error(error));
    }
}
