package shoppingCartExercise;

import java.util.ArrayList;
import java.util.List;

public class ShoppingCart implements ShoppingCartService {

	List<Item> items;

	protected ShoppingCart() {
		this.items = new ArrayList<Item>();
	}

	@Override
	public void addItem(Item item) {
		this.items.add(item);
	}

	@Override
	public void removeItem(Item itemToRemove) {
		for (Item item : items) {
			if (item.getName() == itemToRemove.getName()) {
				this.items.remove(item);
				break;
			}
		}
	}

	@Override
	public void pay() {
		System.out.println("You have paid $" + getSummary() + " dollars.");
	}

	@Override
	public double getSummary() {
		double productSummary = 0.0;
		for (Item item : items) {
			productSummary += item.getPrice();
		}
		return productSummary;
	}

	@Override
	public List<Item> getItems() {
		return this.items;
	}

}
