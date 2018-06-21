package com.meetings;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class MeetingController {

	@Autowired
	private MeetingService meetingService;
	
	@RequestMapping("/meetings")
	public List<Meeting> getAllMeetings() {
		return meetingService.getAllMeetings();
	}
	
	@RequestMapping("/meetings/{id}")
	public Meeting getMeeting(@PathVariable String id) {
		return meetingService.getMeeting(id);
	}
	
	@RequestMapping(method=RequestMethod.POST, value="/meetings")
	public void addMeeting(@RequestBody Meeting meeting) {
		meetingService.addMeeting(meeting);
	}
	
	@RequestMapping(method=RequestMethod.PUT, value="/meetings/{id}")
	public void updateMeeting(@RequestBody Meeting meeting, @PathVariable String id) {
		meetingService.updateMeeting(id, meeting);
	}
	
	@RequestMapping(method=RequestMethod.DELETE, value="/meetings/{id}")
	public void deleteMeeting(@PathVariable String id) {
		meetingService.deleteMeeting(id);
	}

}
