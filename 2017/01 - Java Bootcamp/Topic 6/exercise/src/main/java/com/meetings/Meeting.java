package com.meetings;

import java.util.List;

import com.attendees.Attendant;
import com.rooms.Room;

public class Meeting {

	private String id;
	private List<Attendant> attendees;
	private Room room;
	private String timeSlot;

	public Meeting() {
	}

	public Meeting(String id, List<Attendant> attendees, Room room, String timeSlot) {
		super();
		this.id = id;
		this.attendees = attendees;
		this.room = room;
		this.timeSlot = timeSlot;
	}

	public List<Attendant> getAttendees() {
		return attendees;
	}

	public void setAttendees(List<Attendant> attendees) {
		this.attendees = attendees;
	}

	public Room getRoom() {
		return room;
	}

	public void setRoom(Room room) {
		this.room = room;
	}

	public String getTimeSlot() {
		return timeSlot;
	}

	public void setTimeSlot(String timeSlot) {
		this.timeSlot = timeSlot;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

}
