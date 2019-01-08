package userServiceExercise;

import java.util.ArrayList;
import java.util.List;

public class User {

	private String name;
	private List<User> friends;
	private List<Photo> photos;

	public User(String name) {
		this.name = name;
		this.friends = new ArrayList<User>();
		this.photos = new ArrayList<Photo>();
	}

	public String getName() {
		return name;
	}

	public void changeName(String name) {
		this.name = name;
	}

	public List<User> getFriends() {
		return friends;
	}

	public void addFriend(User user) {
		this.friends.add(user);
	}
	
	public void removeFriend(User user) {
		this.friends.remove(user);
	}

	public List<Photo> getPhotos() {
		return photos;
	}

	public void addPhoto(Photo photo) {
		this.photos.add(photo);
	}
	
	public void removePhoto(Photo photo) {
		this.photos.remove(photo);
	}

}
