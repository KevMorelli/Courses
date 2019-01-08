package shoppingExercise;

import java.util.List;

public class PaypalDiscount implements DiscountStrategy {

	@Override
	public double discountApplied(List<Item> items) {
		int cheapest = 0;
		int sum = 0;
		int price = 0;
		for (Item item : items) {
			// price var is declared to not call getPrice() two times
			price = item.getPrice();
			if (cheapest == 0 || price < cheapest) {
				cheapest = price;
			}
			sum += price;
		}
		sum -= cheapest;
		return sum;
	}

}
