package shoppingExercise;

import java.util.List;

public class CreditCardDiscount implements DiscountStrategy{

	@Override
	public double discountApplied(List<Item> items) {
		int sum = 0;
		for (Item item : items) {
			sum += item.getPrice();
		}
		double discount = 10 * sum / 100;
		return discount;
	}

}
