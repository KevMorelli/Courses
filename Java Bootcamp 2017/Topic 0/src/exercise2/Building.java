package exercise2;

public class Building {

	private int rooms;
	private int windows;
	private int doors;
	private double surface;

	public int getRooms() {
		return rooms;
	}

	public void setRooms(int rooms) {
		this.rooms = rooms;
	}

	public int getWindows() {
		return windows;
	}

	public void setWindows(int windows) {
		this.windows = windows;
	}

	public int getDoors() {
		return doors;
	}

	public void setDoors(int doors) {
		this.doors = doors;
	}

	public double getSurface() {
		return surface;
	}

	public void setSurface(double surface) {
		this.surface = surface;
	}

	public String toString() {
		return "Rooms: " + rooms + ".\nWindows: " + windows + ".\nDoors: " + doors + ".\nTotal surface: " + surface + " m2.";
	}

}
