package com.attendees;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;


@RestController
public class AttendantController {
	
	@Autowired
	private AttendantService attendantService;

	@RequestMapping("/attendees")
	public List<Attendant> getAllAttendees() {
		return attendantService.getAllAttendees();
	}

	@RequestMapping("/attendees/{id}")
	public Attendant getAttendant(@PathVariable String id) {
		return attendantService.getAttendant(id);
	}

}
