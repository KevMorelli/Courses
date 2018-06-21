package audioPlayer;

public class StoppedState implements PlayerState {

	Player player;

	public StoppedState(Player player) {
		this.player = player;
	}

	@Override
	public void playSong() {
		System.out.println("Playing song from the beginning.");
		player.setState(new PlayingState(player));
	}

	@Override
	public void pauseSong() {
		System.out.println("The song has already stopped.");

	}

	@Override
	public void stopSong() {
		System.out.println("The song has already stopped.");

	}

}
