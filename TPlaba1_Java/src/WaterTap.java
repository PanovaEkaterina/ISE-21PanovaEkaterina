
public class WaterTap {
	private boolean open = false;

	public boolean getState() {
		return open;
	}

	public void setState(boolean o) {
		open = o;
	}

	public void Wash(Apple apple) {
		if (open) {
			if (apple.getDirty()) {
				apple.setDirty(false);
			}
		}
	}
}
