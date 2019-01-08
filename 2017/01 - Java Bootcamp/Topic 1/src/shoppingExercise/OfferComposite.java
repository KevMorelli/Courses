package shoppingExercise;

import java.util.ArrayList;
import java.util.List;

public class OfferComposite implements OfferComponent {

	List<OfferComponent> offerComponents = new ArrayList<OfferComponent>();
	String name;
	int price;
	MaillistStation maillistStation;

	public OfferComposite(String name, int price, MaillistStation maillistStation) {
		this.name = name;
		this.price = price;
		this.maillistStation = maillistStation;
		maillistStation.sendEmail(new Email("new offer created", "the new offer " + name + " was created with a value of $" + price));
	}

	@Override
	public void showList() {
		System.out.println("Offer " + name + ": $" + price);
		for (OfferComponent offerComponent : offerComponents) {
			offerComponent.showList();
		}
	}

	public void add(OfferComponent offerComponent) {
		offerComponents.add(offerComponent);
	}

	public void remove(OfferComponent component) {
		offerComponents.remove(component);
	}

	public List<OfferComponent> getComponents() {
		return offerComponents;
	}

	public OfferComponent getComponent(int index) {
		return offerComponents.get(index);
	}

}
