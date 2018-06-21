package userServiceExercise;

import java.util.List;

public interface FriendShipService {
	
	void addFriendship(User user1, User user2);

	void removeFriendship(User user1, User user2);

	List<User> getFriends(User user);

}
