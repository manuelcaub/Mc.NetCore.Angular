import { Category } from '../enums';

export interface Product {
    name: string;
    description: string;
    category: Category;
}