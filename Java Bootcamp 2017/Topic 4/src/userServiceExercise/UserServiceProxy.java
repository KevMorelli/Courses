package userServiceExercise;

import java.util.List;

public class UserServiceProxy implements UserService{
	
	UserService implementation;
	
	protected UserServiceProxy(UserService imp) {
		this.implementation = imp;
	}

	@Override
	public void addUser(User user) {
		implementation.addUser(user);
	}

	@Override
	public void removeUser(User user) {
		implementation.removeUser(user);
	}

	@Override
	public List<User> getUsers() {
		return implementation.getUsers();
	}


	@Override
	public void changeName(User user, String name) {
		implementation.changeName(user, name);
	}

	@Override
	public String getName(User user) {
		return implementation.getName(user);
	}

	@Override
	public PhotoServiceImp getPhotoService() {
		return implementation.getPhotoService();
	}

	@Override
	public FriendShipServiceImp getFriendShipService() {
		return implementation.getFriendShipService();
	}

}
