
public class Stove {
	private Pan pan;

	public Pan GetPan() {
		return pan;
	}

	public void SetPan(Pan p) {
		pan = p;
	}

	private boolean state = false;

	public boolean getState() {
		return state;
	}

	public void setState(boolean s) {
		state = s;
	}

	public void Cook() {
		if (state) {
			while (!pan.IsReadyPan()) {
				pan.Cook();
			}
		}
	}
}
