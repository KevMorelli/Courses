package shoppingExercise;

import java.util.List;

public interface DiscountStrategy {

	double discountApplied(List<Item> items);

}
