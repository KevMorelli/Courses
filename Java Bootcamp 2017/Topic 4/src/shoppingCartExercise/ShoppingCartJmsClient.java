package shoppingCartExercise;

import java.util.List;

public class ShoppingCartJmsClient implements ShoppingCartService {

	ShoppingCartService jmsObject;

	public ShoppingCartJmsClient() {
		// jmsObject = code to get the reference to Service A from the jms call
	}

	@Override
	public void addItem(Item item) {
		jmsObject.addItem(item);
	}

	@Override
	public void removeItem(Item item) {
		jmsObject.removeItem(item);
	}

	@Override
	public void pay() {
		jmsObject.pay();
	}

	@Override
	public double getSummary() {
		return jmsObject.getSummary();
	}

	@Override
	public List<Item> getItems() {
		return jmsObject.getItems();
	}

}
