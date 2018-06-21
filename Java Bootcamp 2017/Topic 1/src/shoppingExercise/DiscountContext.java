package shoppingExercise;

import java.util.List;

public class DiscountContext {

	private DiscountStrategy discountStrategy;
	private double discount;

	public DiscountContext(PaymentStrategy typeOfPayment, List<Item> items) {

		if (typeOfPayment instanceof CreditCardStrategy) {
			this.discountStrategy = new CreditCardDiscount();
		} else if (typeOfPayment instanceof PaypalStrategy) {
			this.discountStrategy = new PaypalDiscount();
		} else {
			this.discountStrategy = new CashDiscount();
		}

		this.discount = this.discountStrategy.discountApplied(items);

	}

	public DiscountStrategy getDiscountStrategy() {
		return discountStrategy;
	}

	public double getDiscount() {
		return discount;
	}

}
