package com.finalproject.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import com.finalproject.entities.ProductSelected;
import com.finalproject.services.ProductSelectedService;

@RestController
@RequestMapping("/api")
public class ProductSelectedController {
	
	@Autowired
	private ProductSelectedService productSelectedService;
	
	@RequestMapping(method = RequestMethod.PUT, value = "/carts")
	public void addProduct(@RequestBody ProductSelected product) {
		productSelectedService.addProduct(product);
	}
	
	@RequestMapping(value = "/carts")
	public List<ProductSelected> getProductsSelected() {
		return productSelectedService.getProducts();
	}
}
