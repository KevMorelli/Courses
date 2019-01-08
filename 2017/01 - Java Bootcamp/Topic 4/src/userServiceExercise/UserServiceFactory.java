package userServiceExercise;

public class UserServiceFactory {

	public static UserServiceImp getLocalService() {
		return new UserServiceImp();
	}
	
	//for this exercise i only configured local service.

}
