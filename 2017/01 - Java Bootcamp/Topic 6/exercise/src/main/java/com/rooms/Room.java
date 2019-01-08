package com.rooms;

public class Room {
	private String id;
	private String capacity;

	public Room() {
	}

	public Room(String id, String capacity) {
		super();
		this.id = id;
		this.capacity = capacity;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getCapacity() {
		return capacity;
	}

	public void setCapacity(String capacity) {
		this.capacity = capacity;
	}

}
