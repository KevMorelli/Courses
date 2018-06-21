package com.finalproject.entities;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;



@Entity
@Table(name = "products")
public class Product {

	@Id
	@NotNull
	@Column(name = "name")
	private String name;
	@ManyToOne
	@NotNull
	@JoinColumn(name = "category_name")
	private Category category;
	@NotNull
	@Column(name = "price")
	private double price;

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}

	/* This method causes recursion when I call GET in category and @JsonIgnore does not work
	 * public Category getCategory() {
		return category;
	}*/

	public void setCategory(Category category) {
		this.category = category;
	}

}

