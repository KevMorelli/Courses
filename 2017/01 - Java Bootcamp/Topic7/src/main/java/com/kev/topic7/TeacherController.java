package com.kev.topic7;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;


@RestController
public class TeacherController {
	
	@Autowired
	private TeacherRepository teacherRepository;
	
	@RequestMapping("/teachers")
	public List<Teacher> getAllTeachers() {
		return (List<Teacher>) teacherRepository.findAll();
	}

	@RequestMapping("/teachers/{id}")
	public Teacher getTeacher(@PathVariable int id) {
		return teacherRepository.findOne(id);
	}
	
	@RequestMapping(method=RequestMethod.POST, value="/teachers")
	public void addTeacher(@RequestBody Teacher teacher) {
		teacherRepository.save(teacher);
	}

}
