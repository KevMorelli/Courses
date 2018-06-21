package shoppingCartExercise;

import static org.junit.Assert.*;

import java.util.ArrayList;
import java.util.List;

import org.junit.Test;

public class ShoppingCartTests {

	ShoppingCartService cart;

	@Test
	public void checkLocalAPI() {
		cart = ShoppingCartFactory.getLocalService();
		List<Item> items = new ArrayList<Item>();
		items.add(new Item("item1", 250.0));
		items.add(new Item("item2", 10.5));
		items.add(new Item("item3", 0.25));
		cart.addItem(items.get(0));
		cart.addItem(items.get(1));
		cart.addItem(items.get(2));

		assertEquals(items, cart.getItems());

		assertEquals(260.75, cart.getSummary(), 0.0);

	}

}
