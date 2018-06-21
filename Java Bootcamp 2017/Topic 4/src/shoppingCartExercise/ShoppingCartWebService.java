package shoppingCartExercise;

import java.util.List;

import javax.jws.WebService;

@WebService

// Just created this one to have to guide in the future.

public class ShoppingCartWebService implements ShoppingCartService {

	ShoppingCartService cart = new ShoppingCart();
	
	@Override
	public void addItem(Item item) {
		cart.addItem(item);
	}

	@Override
	public void removeItem(Item item) {
		cart.removeItem(item);
	}

	@Override
	public void pay() {
		cart.pay();
	}

	@Override
	public double getSummary() {
		return cart.getSummary();
	}

	@Override
	public List<Item> getItems() {
		return cart.getItems();
	}

}
