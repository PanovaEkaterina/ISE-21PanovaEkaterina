import java.awt.Color;
import java.awt.Graphics;
import java.awt.List;
import java.util.ArrayList;

public class Parking {
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

	public int PutStoneInShowcase(Stone stone) {
		return parkingStages.get(currentLevel).plus(parkingStages.get(currentLevel), stone);
	}

	public Stone GetStoneInShowcase(int ticket) {
		return parkingStages.get(currentLevel).minus(parkingStages.get(currentLevel), ticket);
	}

	public void Draw(Graphics g, int wight, int height) {
		DrawMarking(g);
		for (int i = 0; i < countPlaces; i++) {
			Stone stone = parkingStages.get(currentLevel).getStone(i);
			if (stone != null) {
				stone.setPosition(5 + i / 5 * placeSizeWidth + 40, i % 5 * placeSizeHeight + 50);
				stone.drawStone(g);
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
}
