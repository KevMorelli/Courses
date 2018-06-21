package com.finalproject.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.finalproject.entities.ProductSelected;
import com.finalproject.repositories.ProductSelectedRepository;

@Service
public class ProductSelectedService {
	
	@Autowired
	private ProductSelectedRepository productSelectedRepository;
	
	public void addProduct(ProductSelected productSelected) {
		productSelectedRepository.save(productSelected);
	}

	public List<ProductSelected> getProducts() {
		return (List<ProductSelected>) productSelectedRepository.findAll();
	}

}
