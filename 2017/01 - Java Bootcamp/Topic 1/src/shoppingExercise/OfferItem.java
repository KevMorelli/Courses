package shoppingExercise;

public class OfferItem implements OfferComponent {

	private String id;
	private int price;
	private String name;

	public OfferItem(Item item) {

		this.id = item.getId();
		this.price = item.getPrice();
		this.name = item.getName();

	}

	public String getId() {
		return id;
	}

	public int getPrice() {
		return price;
	}

	@Override
	public void showList() {
		System.out.println("*" + name + ": $" + price);
	}

}
