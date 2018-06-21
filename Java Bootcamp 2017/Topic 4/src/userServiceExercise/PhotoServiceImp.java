package userServiceExercise;

import java.util.List;

public class PhotoServiceImp implements PhotoService{

	@Override
	public void addPhoto(User user, Photo photo) {
		user.addPhoto(photo);
	}

	@Override
	public void removePhoto(User user, Photo photo) {
		user.removePhoto(photo);
	}

	@Override
	public List<Photo> getPhotos(User user) {
		return user.getPhotos();
	}

	@Override
	public String getTitle(Photo photo) {
		return photo.getTitle();
	}

	@Override
	public void changeTitle(Photo photo, String title) {
		photo.changeTitle(title);
	}

	@Override
	public List<User> getLikes(Photo photo) {
		return photo.getLikes();
	}

	@Override
	public void addLikePhoto(User user, Photo photo) {
		photo.addLike(user);
	}

	@Override
	public void removeLikePhoto(User user, Photo photo) {
		photo.removeLike(user);
	}
}
