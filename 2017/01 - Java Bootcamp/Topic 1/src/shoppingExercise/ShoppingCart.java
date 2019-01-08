package shoppingExercise;

import java.util.ArrayList;
import java.util.List;

public class ShoppingCart {

	// List of items
	private List<Item> items;
	private PaymentStrategy paymentMethod;
	private DiscountContext discountMethod;
	private TransactionCounter transactionCounter;
	private MaillistStation maillistStation;

	public ShoppingCart() {
		this.items = new ArrayList<Item>();
		transactionCounter = TransactionCounter.getInstance();

	}

	public void setMaillistStation(MaillistStation maillistStation) {
		this.maillistStation = maillistStation;
	}

	public void setPaymentMethod(PaymentStrategy paymentStrategy) {
		this.paymentMethod = paymentStrategy;
	}

	public void addItem(Item item) {
		this.items.add(item);
		maillistStation.sendEmail(new Email("new item added", "place holder for the body"));

	}

	public void removeItem(String idItem) {
		for (Item item : items) {
			if (item.getId() == idItem) {
				this.items.remove(item);
				break;
			}
		}
	}

	public int calculateTotal() {
		int sum = 0;
		for (Item item : items) {
			sum += item.getPrice();
		}
		return sum;
	}

	public void pay() {
		// int amount = calculateTotal();
		discountMethod = new DiscountContext(paymentMethod, items);
		double PriceWithDiscount = discountMethod.getDiscount();
		System.out.println("Transaction #" + transactionCounter.getTransactionNumber());
		paymentMethod.pay(PriceWithDiscount);
		maillistStation
				.sendEmail(new Email("new transaction", "transaction made with number " + transactionCounter.getTransactionNumber()));
	}

	public void showItems() {
		for (Item item : items) {
			System.out.println(item);
		}
	}

	public void changeItemPrice(String id, int price) {
		for (Item item : items) {
			if (item.getId() == id) {
				item.setPrice(price);
				maillistStation.sendEmail(new Email("new item price", "changed price in item " + id));
				break;
			}
		}
	}

}
