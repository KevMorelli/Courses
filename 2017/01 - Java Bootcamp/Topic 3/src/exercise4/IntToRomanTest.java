package exercise4;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

public class IntToRomanTest {

	IntToRoman toRoman;

	@Before
	public void setUp() throws Exception {
		toRoman = new IntToRoman();
	}

	@Test
	public void test() {
		assertEquals("XXXIII", toRoman.convert(33));
	}

}
