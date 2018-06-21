package shoppingExercise;

public class CashStrategy implements PaymentStrategy{

	@Override
	public void pay(double amount) {
		System.out.println("$"+ amount + " paid with cash.");
	}

}
