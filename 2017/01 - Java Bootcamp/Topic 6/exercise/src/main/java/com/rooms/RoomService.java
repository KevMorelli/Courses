package com.rooms;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import org.springframework.stereotype.Service;

@Service
public class RoomService {
	
	private List<Room> rooms = new ArrayList<>(Arrays.asList(
			new Room("1","25"),
			new Room("2","30"),
			new Room("3","15")
			));

	public List<Room> getAllRooms() {
		return rooms;
	}
	
	public Room getRoom(String id) {
		return rooms.stream().filter(r -> r.getId().equals(id)).findFirst().get();
	}

}
