package shoppingExercise;

public class PaypalStrategy implements PaymentStrategy {

	private String email;
	private String password;

	public PaypalStrategy(String ownerEmail, String accountPassword) {
		email = ownerEmail;
		password = accountPassword;
	}

	@Override
	public void pay(double amount) {
		if (email != null && password != null) {
			System.out.println("$"+ amount + " paid using Paypal.");
		}
	}

}
