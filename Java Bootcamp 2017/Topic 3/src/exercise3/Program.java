package exercise3;

import java.util.Objects;

public class Program {

	String[] recentFiles;

	public Program() {
		recentFiles = new String[15];
	}

	public String[] getList() {
		return recentFiles;
	}

	public void openFile(String file) {

		for (int i = 0; i < 15; i++) {
			if (Objects.equals(recentFiles[i], file)) {
				for (int x = i; x > 0; x--) {
					recentFiles[x] = recentFiles[x - 1];
				}
				recentFiles[0] = file;
				break;
			} else if (recentFiles[i] == null) {
				recentFiles[i] = file;
				break;
			} else if (i == 14) {
				for (int x = 14; x > 0; x--) {
					recentFiles[x] = recentFiles[x - 1];
				}
				recentFiles[0] = file;
			}
		}

	}

}
