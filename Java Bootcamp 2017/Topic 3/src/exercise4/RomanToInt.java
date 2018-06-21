package exercise4;

import java.util.TreeMap;

public class RomanToInt {

	private TreeMap<String, Integer> map;

	public RomanToInt() {
		map = new TreeMap<String, Integer>();
		createMap();
	}

	private void createMap() {

		map.put("M", 1000);
		map.put("CM", 900);
		map.put("D", 500);
		map.put("CD", 400);
		map.put("C", 100);
		map.put("XC", 90);
		map.put("L", 50);
		map.put("XL", 40);
		map.put("X", 10);
		map.put("IX", 9);
		map.put("V", 5);
		map.put("IV", 4);
		map.put("I", 1);

	}

	public int convert(String romanNumber) {
		int intNum = 0;
		int prev = 0;
		for (int i = romanNumber.length() - 1; i >= 0; i--) {
			int temp = map.get(String.valueOf(romanNumber.charAt(i)));
			if (temp < prev)
				intNum -= temp;
			else
				intNum += temp;
			prev = temp;
		}
		return intNum;
	}

}
