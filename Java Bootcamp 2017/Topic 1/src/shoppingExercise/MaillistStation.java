package shoppingExercise;

import java.util.Set;
import java.util.HashSet;
import java.util.Iterator;

public class MaillistStation implements MaillistSubject {

	Set<MaillistObserver> maillistObservers;
	private Email email;

	public MaillistStation() {
		maillistObservers = new HashSet<MaillistObserver>();
	}

	@Override
	public void addObserver(MaillistObserver maillistObserver) {
		maillistObservers.add(maillistObserver);

	}

	@Override
	public void removeObserver(MaillistObserver maillistObserver) {
		maillistObservers.remove(maillistObserver);

	}

	@Override
	public void doNotify() {
		Iterator<MaillistObserver> it = maillistObservers.iterator();
		while (it.hasNext()) {
			MaillistObserver maillistObserver = it.next();
			maillistObserver.doUpdate(email);
		}

	}

	public void sendEmail(Email newEmail) {
		email = newEmail;
		doNotify();
	}

}
