import java.io.Serializable;
import java.util.Dictionary;
import java.util.Hashtable;

public class ClassArray<T extends Stone> implements Serializable {
	private T defaultValue;
	private int maxCount;
	private Dictionary<Integer, T> places; 

	public ClassArray(int sizes, T defVal) {
		defaultValue = defVal;
		places = new Hashtable<Integer, T>();
		maxCount = sizes;

	}

	public static <T extends Stone> int plus(ClassArray<T> p, T stone) {
		if (p.places.size() == p.maxCount) {
			return -1;
		}
		for (int i = 0; i < p.places.size(); i++) {
			if (p.CheckFreePlace(i)) {
				p.places.put(i, stone);
				return i;
			}
		}
		p.places.put(p.places.size(), stone);
		return p.places.size() - 1;
	}

	public static <T extends Stone> T minus(ClassArray<T> p, int index) {
		if (((Hashtable<Integer, T>) p.places).containsKey(index)) {
			T stone = p.places.get(index);
			p.places.remove(index);
			return stone;
		}
		return p.defaultValue;
	}

	private boolean CheckFreePlace(int index) {
		return !((Hashtable<Integer, T>) places).containsKey(index);
	}

	public T getStone(int ind) {
		if (((Hashtable<Integer, T>) places).containsKey(ind)) {
			return places.get(ind);
		}
		return defaultValue;
	}
}
