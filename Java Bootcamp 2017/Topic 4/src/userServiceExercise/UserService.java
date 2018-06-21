package userServiceExercise;

import java.util.List;

public interface UserService {

	void addUser(User user);

	void removeUser(User user);

	List<User> getUsers();

	void changeName(User user, String name);

	String getName(User user);

	PhotoServiceImp getPhotoService();
	
	FriendShipServiceImp getFriendShipService();
}
