package shoppingExercise;

public class MarketManager implements MaillistObserver {

	@Override
	public void doUpdate(Email email) {
		System.out.println("");
		System.out.println("Market manager just received an email:");
		email.readEmail();
		System.out.println("");
	}

}
