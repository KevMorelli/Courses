package shoppingExercise;

import java.util.List;

public class CashDiscount implements DiscountStrategy{

	@Override
	public double discountApplied(List<Item> items) {
		int mostExpensive = 0;
		int sum = 0;
		int price = 0;
		for (Item item : items) {
			// price var is declared to not call getPrice() two times
			price = item.getPrice();
			if (price > mostExpensive) {
				mostExpensive = price;
			}
			sum += price;
		}
		sum -= (mostExpensive * 90 / 100);
		return sum;
	}

}
