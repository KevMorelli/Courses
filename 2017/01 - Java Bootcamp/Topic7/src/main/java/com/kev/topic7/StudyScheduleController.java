package com.kev.topic7;

import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class StudyScheduleController {

	@Autowired
	private StudentController studentController;
	@Autowired
	private CourseController courseController;

	@Autowired
	private StudyScheduleRepository studyScheduleRepository;

	@RequestMapping("/students/{id}/courses")
	public List<Course> getAllCoursesFromStudent(@PathVariable int id) {
		List<Course> courses = courseController.getAllCourses();
		List<StudySchedule> studySchedule = (List<StudySchedule>) studyScheduleRepository.findAll();
		List<Course> currentCourses = new ArrayList<>();
		List<Integer> currentCoursesId = new ArrayList<>();
		for (StudySchedule currentRow : studySchedule) {
			if (currentRow.getStudentId() == id) {
				currentCoursesId.add(currentRow.getCourseId());
			}
		}
		for (int i = 0; i < currentCoursesId.size(); i++) {
			for (Course course : courses) {
				if (course.getCourseId() == currentCoursesId.get(i)) {
					currentCourses.add(course);
				}
			}
		}
		return currentCourses;
	}

	@RequestMapping("/courses/{id}/students")
	public List<Student> getAllStudentsFromCourse(@PathVariable int id) {
		List<Student> students = studentController.getAllStudents();
		List<StudySchedule> studySchedule = (List<StudySchedule>) studyScheduleRepository.findAll();
		List<Student> currentStudents = new ArrayList<>();
		List<Integer> currentStudentsId = new ArrayList<>();
		for (StudySchedule currentRow : studySchedule) {
			if (currentRow.getStudentId() == id) {
				currentStudentsId.add(currentRow.getCourseId());
			}
		}
		for (int i = 0; i < currentStudentsId.size(); i++) {
			for (Student student : students) {
				if (student.getRegNumber() == currentStudentsId.get(i)) {
					currentStudents.add(student);
				}
			}
		}
		return currentStudents;
	}
}
