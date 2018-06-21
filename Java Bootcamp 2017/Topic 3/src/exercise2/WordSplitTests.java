package exercise2;

import static org.junit.Assert.*;

import java.util.ArrayList;
import java.util.List;

import org.junit.Before;
import org.junit.Test;

public class WordSplitTests {
	
	WordSplit wordSplit;

	@Before
	public void setUp() throws Exception {
		wordSplit = new WordSplit();
	}

	@Test
	public void checkWordWrappingAlgorithm() {
		List<String> checkingWords = new ArrayList<String>();
		checkingWords.add("Hello");
		checkingWords.add("Word!");

		assertEquals(checkingWords,wordSplit.split("Hello Word!",5));
	}

}
