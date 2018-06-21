package com.finalproject.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import com.finalproject.entities.Roles;
import com.finalproject.services.RolesService;

@RestController
@RequestMapping("/api/roles")
public class RolesController {
	
	@Autowired
	private RolesService rolesService;
	
	@RequestMapping(method=RequestMethod.PUT)
	public void addRol(@RequestBody Roles rol) {
		rolesService.addRol(rol);
	}

	@RequestMapping()
	public List<Roles> getRoles() {
		return rolesService.getAllRoles();
	}

	@RequestMapping(value="/{id}")
	public Roles getRol(@PathVariable int id) {
		return rolesService.getRol(id);
	}

}
