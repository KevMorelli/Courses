package com.finalproject.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import com.finalproject.entities.User;
import com.finalproject.services.UserService;

@RestController
public class UserController {
	
	@Autowired
	UserService userService;
	

@RequestMapping(method=RequestMethod.PUT, value="/register")
public void addUser(@RequestBody User user) {
	userService.addUser(user);
}

@RequestMapping(value="/api/users")
public List<User> getUsers() {
	return userService.getUsers();
}

@RequestMapping(value="/api/users/{username}")
public User getUser(@PathVariable String username) {
	return userService.getUserByUsername(username);
}

}
