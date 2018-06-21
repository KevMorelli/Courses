package audioPlayer;

public class Player implements PlayerState {

	PlayerState state = new StoppedState(this);

	public void setState(PlayerState state) {
		this.state = state;
	}

	@Override
	public void playSong() {
		state.playSong();

	}

	@Override
	public void pauseSong() {
		state.pauseSong();

	}

	@Override
	public void stopSong() {
		state.stopSong();

	}

}
