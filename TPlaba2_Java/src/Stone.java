import java.awt.Color;
import java.awt.Graphics;

public interface Stone {
	void drawStone(Graphics g);

	void setPosition(int x, int y);

	void setMainColor(Color color);
	
	String getInfo();
}
