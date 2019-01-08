package exercise4;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

public class RomanToIntTest {

	RomanToInt toInt;

	@Before
	public void setUp() throws Exception {
		toInt = new RomanToInt();
	}

	@Test
	public void test() {
		assertEquals(33, toInt.convert("XXXIII"));
	}

}
