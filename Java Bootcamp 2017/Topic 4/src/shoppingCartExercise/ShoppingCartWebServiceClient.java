package shoppingCartExercise;

import java.util.List;

public class ShoppingCartWebServiceClient implements ShoppingCartService{

	ShoppingCartService webService;  
    public ShoppingCartWebServiceClient() {  
        //webService = code to get the reference to Service A from the webservice call  
    } 
	
	@Override
	public void addItem(Item item) {
		webService.addItem(item);	
	}

	@Override
	public void removeItem(Item item) {
		webService.removeItem(item);
	}

	@Override
	public void pay() {
		webService.pay();
	}

	@Override
	public double getSummary() {
		return webService.getSummary();
	}

	@Override
	public List<Item> getItems() {
		return webService.getItems();
	}

}
