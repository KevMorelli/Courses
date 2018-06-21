package userServiceExercise;

public class Demo {

	public static void main(String[] args) {
		UserService test = UserServiceFactory.getLocalService();

		test.addUser(new User("Peter"));
		test.addUser(new User("Robert"));
		
		/*
		old method
		test.addFriendship(test.getUsers().get(0), test.getUsers().get(1));
		old method
		System.out.println(test.getName(test.getFriends(test.getUsers().get(0)).get(0)));
		*/
		
		test.getFriendShipService().addFriendship(test.getUsers().get(0), test.getUsers().get(1));

	}

}
