package userServiceExercise;

import java.util.ArrayList;
import java.util.List;

public class UserServiceImp implements UserService {

	private List<User> users;
	private PhotoServiceImp photoService;
	private FriendShipServiceImp friendShipService;

	protected UserServiceImp() {
		users = new ArrayList<User>();
		photoService = new PhotoServiceImp();
		friendShipService = new FriendShipServiceImp();
	}

	@Override
	public void addUser(User user) {
		users.add(user);
	}

	@Override
	public void removeUser(User user) {
		users.remove(user);
	}

	@Override
	public List<User> getUsers() {
		return users;
	}

	@Override
	public void changeName(User user, String name) {
		user.changeName(name);
	}

	@Override
	public String getName(User user) {
		return user.getName();
	}

	@Override
	public PhotoServiceImp getPhotoService() {
		return photoService;
	}

	@Override
	public FriendShipServiceImp getFriendShipService() {
		return friendShipService;
	}

}
