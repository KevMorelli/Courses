package com.meetings;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Service;

@Service
public class MeetingService {

	private List<Meeting> meetings = new ArrayList<>();

	public List<Meeting> getAllMeetings() {
		return meetings;
	}

	public Meeting getMeeting(String id) {
		return meetings.stream().filter(m -> m.getId().equals(id)).findFirst().get();
	}

	public void addMeeting(Meeting meeting) {
		meetings.add(meeting);
	}

	public void updateMeeting(String id, Meeting meeting) {
		for (int i = 0; i < meetings.size(); i++) {
			if (meetings.get(i).getId().equals(id)) {
				meetings.set(i, meeting);
				return;
			}
		}
	}

	public void deleteMeeting(String id) {
		meetings.removeIf(m -> m.getId().equals(id));
	}

}
