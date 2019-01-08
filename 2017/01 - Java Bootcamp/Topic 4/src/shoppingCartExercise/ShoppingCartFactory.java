package shoppingCartExercise;

public class ShoppingCartFactory {

	public static ShoppingCartService getLocalService() {
		return new ShoppingCart();
	}

	public static ShoppingCartService getRemoteServiceUsingJms() {
		return new ShoppingCartProxy(new ShoppingCartJmsClient());
	}

	public static ShoppingCartService getRemoteServiceUsingWebService() {
		return new ShoppingCartProxy(new ShoppingCartWebServiceClient());
	}

}
