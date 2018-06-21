package com.finalproject.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import com.finalproject.entities.Product;
import com.finalproject.services.ProductService;

@RestController
@RequestMapping("/api/products")
public class ProductController {
	
	@Autowired
	private ProductService productService;

	@RequestMapping()
	public List<Product> getAllProducts() {
		return (List<Product>) productService.getAllProducts();
	}

	@RequestMapping("/{name}")
	public Product getProduct(@PathVariable String name) {
		return productService.getProduct(name);
	}

	@RequestMapping(method = RequestMethod.PUT)
	public void addProduct(@RequestBody Product product) {
		productService.addProduct(product);
	}
	
	
/*
	@GetMapping
	public List<Product> list() {
		return Arrays.asList(new Product("Mug for Coffee", 12.99), new Product("Coffee cup", 4.21));
	}
*/
}
