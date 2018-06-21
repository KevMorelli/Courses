package com.finalproject.repositories;

import org.springframework.data.repository.CrudRepository;

import com.finalproject.entities.User;

public interface UserRepository extends CrudRepository<User, String> {

}
