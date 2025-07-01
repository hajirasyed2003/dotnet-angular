import { Category } from "./category.enum"

export interface Product
{
    ID:number;
    name:string;
    category:Category;
    price:number;
    stock:number;
}

