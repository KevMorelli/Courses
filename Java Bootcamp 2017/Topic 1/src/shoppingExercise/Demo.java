package shoppingExercise;

public class Demo {

	public static void main(String[] args) {

		ShoppingCart cart = new ShoppingCart();
		MaillistStation maillistStation = new MaillistStation();
		cart.setMaillistStation(maillistStation);
		MaillistObserver marketManager = new MarketManager();
		maillistStation.addObserver(marketManager);

		Item item1 = new Item("01", "Cake", 50);
		Item item2 = new Item("02", "Apple Pie", 80);
		Item item3 = new Item("03", "Muffin", 20);
		Item item4 = new Item("04", "Lemon Pie", 100);

		cart.addItem(item1);
		cart.addItem(item2);
		cart.addItem(item3);
		cart.addItem(item4);

		cart.showItems();
		System.out.println("");

		OfferComposite offer1 = new OfferComposite("test", 150, maillistStation);
		offer1.add(new OfferItem(item1));
		offer1.add(new OfferItem(item2));

		OfferComposite offer2 = new OfferComposite("test2", 50, maillistStation);
		offer2.add(new OfferItem(item3));
		offer2.add(new OfferItem(item4));

		offer1.add(offer2);

		offer1.showList();

		System.out.println("");

		// pay by cash
		cart.setPaymentMethod(new CashStrategy());
		cart.pay();

		cart.removeItem("04");

		// pay by credit card
		cart.setPaymentMethod(new CreditCardStrategy("John Wick", "123456789"));
		cart.pay();

		cart.removeItem("02");

		// pay by Paypal
		cart.setPaymentMethod(new PaypalStrategy("mail@hotmail.com", "pass123"));
		cart.pay();

		// just removed some items from the shopping cart just to show different
		// results
	}

}
