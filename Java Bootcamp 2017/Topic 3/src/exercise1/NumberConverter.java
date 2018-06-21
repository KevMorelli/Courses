package exercise1;

import java.util.StringTokenizer;

public class NumberConverter {

	private String[] units = { "", "one", "two", "three", "four", "five", "six", //
			"seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", //
			"fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

	private String[] tens = { "", // 0
			"", // 1
			"twenty", // 2
			"thirty", // 3
			"forty", // 4
			"fifty", // 5
			"sixty", // 6
			"seventy", // 7
			"eighty", // 8
			"ninety" // 9
	};

	public String doubleConvert(double n) {
		String pass = n + "";
		StringTokenizer token = new StringTokenizer(pass, ".");
		String first = token.nextToken();
		String last = token.nextToken();
		pass = convert(Integer.parseInt(first));

		String get = convert(Integer.parseInt(last + ""));
		if (!get.isEmpty()) {
			pass = pass + " dollars and";
			for (int i = 0; i < last.length(); i++) {
				if (last.charAt(i) == '0') {
					pass = pass + " zero ";
				} else {
					break;
				}
			}
			pass = pass + get;
			pass = pass + " cents";
		}
		return pass;
	}

	public String convert(int n) {
		if (n < 20) {
			return units[n];
		}

		if (n < 100) {
			return tens[n / 10] + ((n % 10 != 0) ? " " : "") + units[n % 10];
		}

		if (n < 1000) {
			return units[n / 100] + " hundred" + ((n % 100 != 0) ? " " : "") + convert(n % 100);
		}

		if (n < 1000000) {
			return convert(n / 1000) + " thousand" + ((n % 1000 != 0) ? " " : "") + convert(n % 1000);
		}

		if (n < 1000000000) {
			return convert(n / 1000000) + " million" + ((n % 1000000 != 0) ? " " : "") + convert(n % 1000000);
		}

		return convert(n / 1000000000) + " billion" + ((n % 1000000000 != 0) ? " " : "") + convert(n % 1000000000);
	}
}
