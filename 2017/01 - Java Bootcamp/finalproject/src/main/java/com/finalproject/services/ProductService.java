package com.finalproject.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.finalproject.entities.Product;
import com.finalproject.repositories.ProductRepository;

@Service
public class ProductService {

	@Autowired
	private ProductRepository productRepository;

	public List<Product> getAllProducts() {
		return (List<Product>) productRepository.findAll();
	}

	public Product getProduct(String name) {
		return productRepository.findOne(name);
	}

	public void addProduct(Product product) {
		productRepository.save(product);
	}

}
