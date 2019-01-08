package com.finalproject.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.finalproject.entities.Category;
import com.finalproject.repositories.CategoryRepository;

@Service
public class CategoryService {

	@Autowired
	private CategoryRepository categoryRepository;

	public List<Category> getAllCategories() {
		return (List<Category>) categoryRepository.findAll();
	}

	public void addCategory(Category category) {
		categoryRepository.save(category);

	}

	public Category getCategory(String name) {
		return categoryRepository.findOne(name);
	}

}
