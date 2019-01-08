package com.finalproject.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import com.finalproject.entities.Category;
import com.finalproject.services.CategoryService;

@RestController
@RequestMapping("/api/categories")
public class CategoryController {
	@Autowired
	CategoryService categoryService;

	@RequestMapping(method = RequestMethod.PUT)
	public void addCategory(@RequestBody Category category) {
		categoryService.addCategory(category);
	}
	
	@RequestMapping()
	public List<Category> getAllCategories() {
		return categoryService.getAllCategories();
	}
	
	@RequestMapping("/{name}")
	public Category getCategory(@PathVariable String name) {
		return categoryService.getCategory(name);
	}
}
