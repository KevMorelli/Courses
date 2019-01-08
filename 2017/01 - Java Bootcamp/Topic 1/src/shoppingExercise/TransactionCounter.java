package shoppingExercise;

public class TransactionCounter {
	private static TransactionCounter transactionCounter = null;
	private int transactions = 0;

	private TransactionCounter() {
	}

	public static TransactionCounter getInstance() {
		if (transactionCounter == null) {
			transactionCounter = new TransactionCounter();
		}
		return transactionCounter;
	}

	public int getTransactionNumber() {
		transactions++;
		return transactions;
	}
}
