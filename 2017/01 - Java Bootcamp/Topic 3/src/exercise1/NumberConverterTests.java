package exercise1;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

public class NumberConverterTests {

	NumberConverter converter;

	@Before
	public void setUp() throws Exception {
		converter = new NumberConverter();
	}

	@Test
	public void checkFullConverter() {
		assertEquals("two thousand five hundred twenty three dollars and zero four cents", converter.doubleConvert(2523.04));
	}

	@Test
	public void checkMainConverter() {
		assertEquals("one hundred", converter.convert(100));
	}
	

}
