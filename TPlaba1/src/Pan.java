public class Pan {
	private Apple[] apples;
	private Dough d;

	private boolean ready;

	public boolean getReady() {
		return ready;
	}

	public void Init(int countapple) {
		apples = new Apple[countapple];
	}

	public void AddApple(Apple a) {
		for (int i = 0; i < apples.length; i++) {
			if (apples[i] == null) {
				apples[i] = a;
				return;
			}
		}
	}

	public void AddDough(Dough dd) {
		if (dd.Check()) {
			d = dd;
		}
	}

	public boolean Check() {
		if (apples == null) {
			return false;
		}
		if (apples.length == 0) {
			return false;
		}
		for (int i = 0; i < apples.length; ++i) {
			if (apples[i] == null)
				return false;
		}
		if (apples.length < 1)
			return false;
		for (int i = 0; i < apples.length; ++i) {
			if (!apples[i].getDirty()) {
				if (apples[i].GetHave_skin_apple()) {
					return false;
				}
			} else
				return false;
		}
		if (d == null) {
			return false;
		}
		return true;
	}

	public boolean IsReadyPan() {
		if (apples == null) {
			return false;
		}
		if (apples.length == 0) {
			return false;
		}

		for (int i = 0; i < apples.length; ++i) {
			if (!apples[i].getDirty()) {
				if (apples[i].GetHave_skin_apple()) {
					return false;
				}
			} else
				return false;
		}

		if (apples.length < 1)
			return false;
		for (int i = 0; i < apples.length; ++i) {
			if (apples[i] == null)
				return false;
		}
		if (d == null) {
			return false;
		}
		return true;
	}

	public void Cook() {
		if (Check()) {
			ready = true;
		} else
			return;
	}
}