package com.finalproject.entities;

import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.ManyToMany;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;

@Entity
@Table(name = "user_roles")
public class Roles {

@Id
@GeneratedValue(strategy = GenerationType.AUTO)
private int id;
@NotNull
@ManyToMany
private List<User> users;
@NotNull
@Column(name = "role")
private String role;
public int getId() {
	return id;
}
public void setId(int id) {
	this.id = id;
}
public List<User> getUsers() {
	return users;
}
public void setUsers(List<User> users) {
	this.users = users;
}
public String getRole() {
	return role;
}
public void setRole(String role) {
	this.role = role;
}

}
