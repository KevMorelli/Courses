package com.attendees;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import org.springframework.stereotype.Service;

@Service
public class AttendantService {
	
	private List<Attendant> attendees = new ArrayList<>(Arrays.asList(
			new Attendant("1","Kev","Morelli"),
			new Attendant("2","George","Smith"),
			new Attendant("3","Lucas","Rodriguez")
			));

	public List<Attendant> getAllAttendees() {
		return attendees;
	}
	
	public Attendant getAttendant(String id) {
		return attendees.stream().filter(a -> a.getId().equals(id)).findFirst().get();
	}

}
