package exercise2;

public class BuildingDirector {

	private BuildingBuilder buildingBuilder = null;

	public BuildingDirector(BuildingBuilder buildingBuilder) {
		this.buildingBuilder = buildingBuilder;
	}

	public void constructBuilding() {
		buildingBuilder.buildSurface();
		buildingBuilder.buildWindows();
		buildingBuilder.buildRooms();
		buildingBuilder.buildDoors();
	}

	public Building getBuilding() {
		return buildingBuilder.getBuilding();
	}

}
