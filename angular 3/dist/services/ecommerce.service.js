"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ecommerceService = void 0;
const category_enum_1 = require("../models/category.enum");
class ecommerceService {
    constructor() {
        this.products = [];
        this.cartitems = [];
        this.products = [
            {
                ID: 1,
                name: "Laptop",
                category: category_enum_1.Category.Electronics,
                price: 45000,
                stock: 3
            },
            {
                ID: 2,
                name: "Jeans",
                category: category_enum_1.Category.Clothing,
                price: 1500,
                stock: 10
            },
            {
                ID: 3,
                name: "Rice-Bag",
                category: category_enum_1.Category.Grocery,
                price: 700,
                stock: 5
            }
        ];
    }
    viewProducts() {
        console.log("Available Products:\n");
        for (const p of this.products) {
            console.log(`${p.ID} | ${p.name} 
                | Category : ${p.category} | ${p.price} | In Stock : ${p.stock}`);
        }
        console.log("\n");
    }
    addToCart(pID, qty) {
        const product = this.products.find(p => p.ID == pID);
        if (!product) {
            console.log("Product not found");
            return;
        }
        if (product.stock < qty) {
            console.log("Stock not available");
            return;
        }
        const citem = this.cartitems.find(c => c.product.ID == product.ID);
        if (citem) {
            citem.qty += qty;
        }
        else {
            this.cartitems.push({ product, qty });
        }
        product.stock -= qty;
        console.log(`${product.name} x ${qty} added to cart`);
    }
    removeFromCart(pID) {
        const index = this.cartitems.findIndex(c => c.product.ID == pID);
        if (index != -1) {
            const item = this.cartitems[index];
            item.product.stock += item.qty;
            this.cartitems.splice(index, 1);
            console.log(`${item.product.name} removed from cart`);
        }
        else {
            console.log("Product not found in cart");
        }
    }
    viewCartSummary() {
        if (this.cartitems.length == 0) {
            console.log("Cart is Empty");
            return;
        }
        let total = 0;
        for (const ci of this.cartitems) {
            console.log(`${ci.product.name} - ${ci.product.price} x ${ci.qty}`);
            total = ci.product.price * ci.qty;
        }
        const discount = (total >= 10000) ? 0.15 : (total >= 5000) ? 0.10 : 0;
        const dtotal = total - (discount * total);
        console.log(`\nTotal: ₹${total}`);
        if (discount > 0) {
            console.log(`Discounted Total: ₹${dtotal}`);
        }
        console.log("\n");
    }
}
exports.ecommerceService = ecommerceService;
