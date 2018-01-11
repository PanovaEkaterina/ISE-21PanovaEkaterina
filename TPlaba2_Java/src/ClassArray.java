import java.io.Serializable;
import java.util.Dictionary;
import java.util.Hashtable;
import java.util.Iterator;

public class ClassArray<T extends Stone> implements Serializable, Comparable<ClassArray<T>>, Iterable<T>, Iterator<T> {
	private T defaultValue;
	private int maxCount;
	private Dictionary<Integer, T> places;

	public ClassArray(int sizes, T defVal) {
		defaultValue = defVal;
		places = new Hashtable<Integer, T>();
		maxCount = sizes;

	}

	public static <T extends Stone> int plus(ClassArray<T> p, T stone)
			throws ParkingOverflowException, ParkingAlreadyHaveException {
		boolean isDiamond = stone instanceof Diamond;
		if (p.places.size() == p.maxCount) {
			throw new ParkingOverflowException();
		}
		int index = p.places.size();
		for (int i = 0; i < p.places.size(); i++) {
			if (p.CheckFreePlace(i))
				index = i;
			if (stone.getClass() == p.places.get(i).getClass()) {
				if (isDiamond) {
					if (((Diamond) stone).equals(p.places.get(i))) {
						throw new ParkingAlreadyHaveException();
					}
				} else if (((Adamant) stone).equals(p.places.get(i))) {
					throw new ParkingAlreadyHaveException();
				}
			}
		}
		if (index != p.places.size()) {
			p.places.put(index, stone);
			return index;
		}
		p.places.put(p.places.size(), stone);
		return p.places.size() - 1;
	}

	public static <T extends Stone> T minus(ClassArray<T> p, int index) throws ParkingIndexOutOfRangeException {
		if (((Hashtable<Integer, T>) p.places).containsKey(index)) {
			T stone = p.places.get(index);
			p.places.remove(index);
			return stone;
		}
		throw new ParkingIndexOutOfRangeException();
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

	@Override
	public Iterator<T> iterator() {
		return this;
	}

	private int currentIndex;

	@Override
	public boolean hasNext() {
		if (currentIndex + 1 >= places.size()) {
			currentIndex = -1;
			return false;
		}
		currentIndex++;
		return true;
	}

	@Override
	public T next() {
		return (T) places.get(currentIndex);
	}

	@Override
	public int compareTo(ClassArray<T> other) {
		if (places.size() > other.places.size())
			return -1;
		else if (places.size() < other.places.size())
			return 1;
		else {
			for (int i = 0; i < places.size(); i++) {
				if ((places.get(places.keys().nextElement()) instanceof Diamond)
						&& (other.places.get(other.places.keys().nextElement()) instanceof Diamond)) {
					return (((Adamant) places.get(places.keys().nextElement()))
							.compareTo(((Diamond) other.places.get(other.places.keys().nextElement()))));
				}
				if ((places.get(places.keys().nextElement()) instanceof Adamant)
						&& (other.places.get(other.places.keys().nextElement()) instanceof Diamond))
					return 1;
				if ((places.get(places.keys().nextElement()) instanceof Diamond)
						&& (other.places.get(other.places.keys().nextElement()) instanceof Adamant))
					return -1;
				if ((places.get(places.keys().nextElement()) instanceof Adamant)
						&& (other.places.get(other.places.keys().nextElement()) instanceof Adamant)) {
					return (((Adamant) places.get(places.keys().nextElement()))
							.compareTo(((Adamant) other.places.get(other.places.keys().nextElement()))));
				}

			}
		}
		return 0;
	}
}
