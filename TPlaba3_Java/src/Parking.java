import java.awt.Color;
import java.awt.Graphics;

public class Parking {
	ClassArray<Stone> parking;

	int countPlaces = 20;

	int placeSizeWidth = 210;

	int placeSizeHeight = 80;

	public Parking() {
		parking = new ClassArray<Stone>(countPlaces, null);
	}

	public int PutStoneInShowcase(Stone stone) {
		return parking.plus(parking, stone);
	}

	public Stone GetStoneInShowcase(int ticket) {
		return parking.minus(parking, ticket);
	}

	public void Draw(Graphics g, int wight, int height) {
		DrawMarking(g);
		for (int i = 0; i < countPlaces; i++) {
			Stone stone = parking.getObject(i);
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
