package userServiceExercise;

import java.util.ArrayList;
import java.util.List;

public class Photo {

	private String title;
	private List<User> likes;

	public Photo(String title) {
		this.title = title;
		this.likes = new ArrayList<User>();
	}

	public String getTitle() {
		return title;
	}

	public void changeTitle(String title) {
		this.title = title;
	}

	public List<User> getLikes() {
		return likes;
	}

	public void addLike(User user) {
		this.likes.add(user);
	}

	public void removeLike(User user) {
		this.likes.remove(user);
	}

}
