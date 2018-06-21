package com.finalproject.repositories;

import org.springframework.data.repository.CrudRepository;

import com.finalproject.entities.Product;

public interface ProductRepository extends CrudRepository<Product, String> {

}
