package exercise3;

public class PublicHospital extends Hospital {

	@Override
	public String getName() {
		return "Hospital del Centenario";
	}

	@Override
	public int getNurses() {
		return 35;
	}

	@Override
	public int getDoctors() {
		return 20;
	}

	@Override
	public int getMaxPatients() {
		return 183;
	}

	@Override
	public int getFloors() {
		return 3;
	}

	@Override
	public String getType() {
		return "public";
	}

}
