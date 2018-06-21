package com.kev.topic7;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class StudentController {
	
	@Autowired
	private StudentRepository studentRepository;
	
	@RequestMapping("/students")
	public List<Student> getAllStudents() {
		return (List<Student>) studentRepository.findAll();
	}

	@RequestMapping("/students/{id}")
	public Student getStudent(@PathVariable int id) {
		return studentRepository.findOne(id);
	}
	
	@RequestMapping(method=RequestMethod.POST, value="/students")
	public void addStudent(@RequestBody Student student) {
		studentRepository.save(student);
	}

}
