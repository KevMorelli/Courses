package exercise3;

public class PrivateHospital extends Hospital {

	@Override
	public String getName() {
		return "Hospital Privado de Rosario";
	}

	@Override
	public int getNurses() {
		return 40;
	}

	@Override
	public int getDoctors() {
		return 30;
	}

	@Override
	public int getMaxPatients() {
		return 250;
	}

	@Override
	public int getFloors() {
		return 5;
	}

	@Override
	public String getType() {
		return "private";
	}

}
