package exercise2;

import java.util.ArrayList;
import java.util.List;

public class WordSplit {

	public List<String> split(String word, int rowLength) {
		List<String> wrappedWords = new ArrayList<String>();
		String currentWord = "";
		int firstChar = 1;

		for (int x = 0; x < word.length(); x += rowLength) {
			for (int i = x; i < x + rowLength; i++) {
				if (i < word.length()) {
					if (firstChar == 1 && word.charAt(i) == ' ') {
						i++;
						x++;
					}
					firstChar = 0;
					currentWord = currentWord + word.charAt(i);
				}
			}
			wrappedWords.add(currentWord);
			currentWord = "";
			firstChar = 1;
		}
		return wrappedWords;
	}

}
