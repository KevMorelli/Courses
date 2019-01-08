package shoppingCartExercise;

import java.util.List;

public class ShoppingCartProxy implements ShoppingCartService{
	
	ShoppingCartService shoppingCart;
	
	protected ShoppingCartProxy(ShoppingCartService cart) {
		this.shoppingCart = cart;
	}

	@Override
	public void addItem(Item item) {
		shoppingCart.addItem(item);	
	}

	@Override
	public void removeItem(Item item) {
		shoppingCart.removeItem(item);	
	}

	@Override
	public void pay() {
		shoppingCart.pay();
	}

	@Override
	public double getSummary() {
		return shoppingCart.getSummary();
	}

	@Override
	public List<Item> getItems() {
		return shoppingCart.getItems();
	}
	
	
	
	

}
