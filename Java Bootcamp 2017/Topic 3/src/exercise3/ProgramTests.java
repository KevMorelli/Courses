package exercise3;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

public class ProgramTests {
	
	Program program;

	@Before
	public void setUp() throws Exception {
		program = new Program();
	}

	@Test
	public void checkFileListDeclared() {
		//checking if the list is empty
		String[] checkingFiles = new String[15];
		assertArrayEquals(checkingFiles,program.getList());
	}
	
	@Test
	public void checkFileList() {
		String[] checkingFiles = new String[15];
		
		//filling the arrays for testing and checking that files are distributed correctly
		String fileName = null;
		for (int i = 0; i < 15; i++) {
			fileName = Integer.toString(i+1) + ".file";
			checkingFiles[i] = fileName;
			program.openFile(fileName);
		}
		assertArrayEquals(checkingFiles,program.getList());
		
		//checking if the "file already exist" algorithm works
		checkingFiles[0] = "3.file";
		checkingFiles[1] = "1.file";
		checkingFiles[2] = "2.file";
		program.openFile("3.file");
		assertArrayEquals(checkingFiles,program.getList());
		
		//and last one, checking the full list algorithm
		
		checkingFiles[0] = "20.file";
		checkingFiles[1] = "3.file";
		checkingFiles[2] = "1.file";
		checkingFiles[3] = "2.file";
		checkingFiles[4] = "4.file";
		checkingFiles[5] = "5.file";
		checkingFiles[6] = "6.file";
		checkingFiles[7] = "7.file";
		checkingFiles[8] = "8.file";
		checkingFiles[9] = "9.file";
		checkingFiles[10] = "10.file";
		checkingFiles[11] = "11.file";
		checkingFiles[12] = "12.file";
		checkingFiles[13] = "13.file";
		checkingFiles[14] = "14.file";
		program.openFile("20.file");
		assertArrayEquals(checkingFiles,program.getList());
		
	}
	
	

}
