package com.rooms;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class RoomController {

	@Autowired
	private RoomService roomService;

	@RequestMapping("/rooms")
	public List<Room> getAllRooms() {
		return roomService.getAllRooms();
	}

	@RequestMapping("/rooms/{id}")
	public Room getTopic(@PathVariable String id) {
		return roomService.getRoom(id);
	}

}
