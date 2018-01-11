import java.awt.Color;
import java.awt.Graphics;
import java.awt.List;
import java.io.BufferedInputStream;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

public class Parking implements Serializable {
	ArrayList<ClassArray<Stone>> parkingStages;
	int countPlaces = 5;
	int placeSizeWidth = 210;
	int placeSizeHeight = 80;

	int currentLevel;

	public int getCurrentLevel() {
		return currentLevel;
	}

	public Parking(int countStages) {
		parkingStages = new ArrayList<ClassArray<Stone>>(countStages);
		for (int i = 0; i < countStages; i++) {
			parkingStages.add(new ClassArray<Stone>(countPlaces, null));
		}
	}

	public void LevelUp() {
		if (currentLevel + 1 < parkingStages.size()) {
			currentLevel++;
		}
	}

	public void LevelDown() {
		if (currentLevel > 0) {
			currentLevel--;
		}
	}

	public int PutStoneInShowcase(Stone stone) throws ParkingOverflowException, ParkingAlreadyHaveException {
		return parkingStages.get(currentLevel).plus(parkingStages.get(currentLevel), stone);
	}

	public Stone GetStoneInShowcase(int ticket) throws ParkingIndexOutOfRangeException {
		return parkingStages.get(currentLevel).minus(parkingStages.get(currentLevel), ticket);
	}

	public void Draw(Graphics g, int wight, int height) {
		DrawMarking(g);
		int i = 0;
		while (parkingStages.get(currentLevel).hasNext()) {
			Stone stone = parkingStages.get(currentLevel).next();
			if (stone != null) {
				stone.setPosition(5 + i / 5 * placeSizeWidth + 40, i % 5 * placeSizeHeight + 50);
				stone.drawStone(g);
				i++;
			}
		}
	}

	public void DrawMarking(Graphics g) {
		g.setColor(Color.BLACK);
		g.drawRect(0, 0, (countPlaces / 5) * placeSizeWidth, 480);
		for (int i = 0; i < countPlaces / 5; i++) {
			for (int j = 0; j < 6; ++j) {
				g.drawLine(i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
			}
			g.drawLine(i * placeSizeWidth, 0, i * placeSizeWidth, 400);
		}
	}

	public boolean save(String fileName) throws IOException {

		FileOutputStream save = null;
		try {
			save = new FileOutputStream(fileName);
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		ObjectOutputStream obSave = new ObjectOutputStream(save);
		System.out.println(parkingStages.get(0).getStone(0).getInfo());
		obSave.writeObject(parkingStages);

		return true;
	}

	public boolean load(String filename) {
		try {
			ObjectInputStream obLoad = new ObjectInputStream(new BufferedInputStream(new FileInputStream(filename)));
			try {
				parkingStages = (ArrayList<ClassArray<Stone>>) obLoad.readObject();
				System.out.println(parkingStages.get(0).getStone(0).getInfo());
			} catch (ClassNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return true;
	}

	public void sort() {
		Collections.sort(parkingStages, new Comparator<ClassArray<Stone>>() {

			@Override
			public int compare(ClassArray<Stone> o1, ClassArray<Stone> o2) {
				// TODO Auto-generated method stub
				return o1.compareTo(o2);
			}
		});
	}
}
