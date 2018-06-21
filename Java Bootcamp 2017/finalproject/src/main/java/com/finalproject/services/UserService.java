package com.finalproject.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Service;

import com.finalproject.entities.User;
import com.finalproject.repositories.UserRepository;

@Service
public class UserService {

	@Autowired
	UserRepository userRepository;

	public void addUser(User user) {
		if (getUserByUsername(user.getUsername()) == null) {
			user.setPassword(new BCryptPasswordEncoder().encode(user.getPassword()));
			userRepository.save(user);
		}

	}

	public User getUserByUsername(String username) {
		return userRepository.findOne(username);
	}

	public List<User> getUsers() {
		return (List<User>) userRepository.findAll();
	}

}
