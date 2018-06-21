package shoppingExercise;

public interface MaillistSubject {

	void addObserver(MaillistObserver maillistObserver);

	void removeObserver(MaillistObserver maillistObserver);

	void doNotify();

}
