package exercise2;

//This is just an example of a Concrete Builder

public class HouseBuildingBuilder implements BuildingBuilder {
	private Building building;

	public HouseBuildingBuilder() {
		building = new Building();
	}

	@Override
	public void buildRooms() {
		building.setRooms(4);
	}

	@Override
	public void buildWindows() {
		building.setWindows(8);
	}

	@Override
	public void buildDoors() {
		building.setDoors(5);
	}

	@Override
	public void buildSurface() {
		building.setSurface(62.5);
	}

	@Override
	public Building getBuilding() {
		return building;
	}

}
