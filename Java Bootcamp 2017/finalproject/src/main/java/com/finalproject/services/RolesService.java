package com.finalproject.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.finalproject.entities.Roles;
import com.finalproject.repositories.RolesRepository;

@Service
public class RolesService {
	
	@Autowired
	private RolesRepository rolesRepository;
	
	public List<Roles> getAllRoles() {
		return (List<Roles>) rolesRepository.findAll();
	}
	
	public Roles getRol(int id) {
		return rolesRepository.findOne(id);
	}

	public void addRol(Roles rol) {
		rolesRepository.save(rol);
	}

}
