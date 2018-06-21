package com.finalproject.repositories;

import org.springframework.data.repository.CrudRepository;

import com.finalproject.entities.Category;

public interface CategoryRepository extends CrudRepository<Category, String> {

}
