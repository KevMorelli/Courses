package shoppingCartExercise;

import java.util.List;

public interface ShoppingCartService {

	void addItem(Item item);

	void removeItem(Item item);

	void pay();

	double getSummary();

	List<Item> getItems();

}
