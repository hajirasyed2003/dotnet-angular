import { ecommerceService } from "./services/ecommerce.service";

const store = new ecommerceService();


store.viewProducts();

store.addToCart(1, 1); 
store.addToCart(2, 2); 
store.addToCart(3, 1); 

store.removeFromCart(2); 

store.viewCartSummary();

store.viewProducts();
