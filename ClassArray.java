public class ClassArray<T extends Stone> {
	private T[] places;
	private T defaultValue;

	public ClassArray(int sizes, T defVal) {
		defaultValue = defVal;
		places = (T[]) new Stone[sizes];
		for (int i = 0; i < places.length; i++) {
			places[i] = defaultValue;
		}
	}

	public T getObject(int ind) {
		if (ind > -1 && ind < places.length) {
			return places[ind];
		}
		return defaultValue;
	}

	public static <T extends Stone> int plus(ClassArray<T> p, T stone) {
		for (int i = 0; i < p.places.length; i++) {
			if (p.CheckFreePlace(i)) {
				p.places[i] = stone;
				return i;
			}
		}
		return -1;
	}

	public static <T extends Stone> T minus(ClassArray<T> p, int index) {
		if (!p.CheckFreePlace(index)) {
			T stone = p.places[index];
			p.places[index] = p.defaultValue;
			return stone;
		}
		return p.defaultValue;
	}

	private boolean CheckFreePlace(int index) {
		if (index < 0 || index > places.length) {
			return false;
		}
		if (places[index] == null) {
			return true;
		}
		if (places[index].equals(defaultValue)) {
			return true;
		}

		return false;
	}
}
