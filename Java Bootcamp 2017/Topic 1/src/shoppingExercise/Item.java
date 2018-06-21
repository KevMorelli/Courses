package shoppingExercise;

public class Item {

	private String id;
	private int price;
	private String name;

	public Item(String itemId, String name, int cost) {
		this.id = itemId;
		this.price = cost;
		this.name = name;
	}

	public String getId() {
		return id;
	}

	public int getPrice() {
		return price;
	}

	public String getName() {
		return name;
	}
	
	public void setPrice(int price) {
		this.price = price;
	}

	public String toString() {
		return name + ": $" + price;
	}

}
