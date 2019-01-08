package audioPlayer;

public class PausedState implements PlayerState {

	Player player;

	public PausedState(Player player) {
		this.player = player;
	}

	@Override
	public void playSong() {
		System.out.println("The song is now being played.");
		player.setState(new PlayingState(player));

	}

	@Override
	public void pauseSong() {
		System.out.println("The song is already paused.");

	}

	@Override
	public void stopSong() {
		System.out.println("The song has stopped.");
		player.setState(new StoppedState(player));

	}

}
