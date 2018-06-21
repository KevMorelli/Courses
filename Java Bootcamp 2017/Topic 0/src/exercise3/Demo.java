package exercise3;

public class Demo {

	public static void main(String[] args) {
		HospitalFactory hospitalFactory = new HospitalFactory();

		Hospital h1 = hospitalFactory.getHospital("public");
		System.out.println("The " + h1.getType() + " service " + h1.getName() + " counts with:");
		System.out.println(h1.getMaxPatients() + " beds in " + h1.getFloors() + " floors.");
		System.out.println(h1.getNurses() + " nurses and " + h1.getDoctors() + " doctors.");

		System.out.println();

		Hospital h2 = hospitalFactory.getHospital("private");
		System.out.println("The " + h2.getType() + " service " + h2.getName() + " counts with:");
		System.out.println(h2.getMaxPatients() + " beds in " + h2.getFloors() + " floors.");
		System.out.println(h2.getNurses() + " nurses and " + h2.getDoctors() + " doctors.");
	}

}
