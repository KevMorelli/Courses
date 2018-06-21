package com.topic2.exercise5;

import java.util.Scanner;

public class App {
	public static void main(String[] args) {
		String input = null;
		Scanner inputReader = new Scanner(System.in);
		
		System.out.println("Hi, what's your name?");
		input = inputReader.nextLine();
		System.out.println("Welcome " + input + "!");
		inputReader.close();
		
	}
}
