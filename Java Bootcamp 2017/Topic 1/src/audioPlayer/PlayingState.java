package audioPlayer;

public class PlayingState implements PlayerState {

	Player player;

	public PlayingState(Player player) {
		this.player = player;
	}

	@Override
	public void playSong() {
		System.out.println("The song is already playing.");

	}

	@Override
	public void pauseSong() {
		System.out.println("The song is now paused.");
		player.setState(new PausedState(player));

	}

	@Override
	public void stopSong() {
		System.out.println("The song has stopped.");
		player.setState(new StoppedState(player));

	}

}
