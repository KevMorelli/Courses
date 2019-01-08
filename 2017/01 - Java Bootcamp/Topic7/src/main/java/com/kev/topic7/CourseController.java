package com.kev.topic7;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class CourseController {
	
	@Autowired
	private CourseRepository courseRepository;
	

	@RequestMapping("/courses")
	public List<Course> getAllCourses() {
		return (List<Course>) courseRepository.findAll();
	}
	
	@RequestMapping("/courses/{id}")
	public Course getCourse(@PathVariable int id) {
		return courseRepository.findOne(id);
	}

	@RequestMapping(method=RequestMethod.POST, value="/courses")
	public void addCourse(@RequestBody Course course) {
		courseRepository.save(course);
	}

}
