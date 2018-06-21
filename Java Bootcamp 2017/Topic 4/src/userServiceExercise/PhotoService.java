package userServiceExercise;

import java.util.List;

public interface PhotoService {
	
	void addPhoto(User user, Photo photo);

	void removePhoto(User user, Photo photo);

	List<Photo> getPhotos(User user);
	
	String getTitle(Photo photo);

	void changeTitle(Photo photo, String title);

	List<User> getLikes(Photo photo);

	void addLikePhoto(User user, Photo photo);

	void removeLikePhoto(User user, Photo photo);
	
}
