package shoppingExercise;

public class CreditCardStrategy implements PaymentStrategy {

	private String name;
	private String cardNumber;

	public CreditCardStrategy(String ownerName, String cardNum) {
		name = ownerName;
		cardNumber = cardNum;
	}

	@Override
	public void pay(double amount) {
		if (name != null && cardNumber != null) {
			System.out.println("$"+ amount + " paid with credit card.");
		}
	}
}
