package userServiceExercise;

import java.util.List;

public class FriendShipServiceImp implements FriendShipService {

	@Override
	public void addFriendship(User user1, User user2) {
		user1.addFriend(user2);
		user2.addFriend(user1);
	}

	@Override
	public void removeFriendship(User user1, User user2) {
		user1.removeFriend(user2);
		user2.removeFriend(user1);
	}

	@Override
	public List<User> getFriends(User user) {
		return user.getFriends();
	}
}
