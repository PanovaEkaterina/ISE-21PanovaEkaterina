import java.awt.Color;
import java.awt.Graphics;

public abstract class Jewelry implements Stone {
	protected int srartRosX;
	protected int srartRosY;

	public int Weight;
	public int Price;
	public int Hardness;
	public Color ColorStone;
	
	protected abstract void setWeight(int w);
	
	public abstract int getWeight();
	
	protected abstract void setPrice(int p);
	
	public abstract int getPrice();
	
	protected abstract void setHardness(int h);
	
	public abstract int getHardness();

	public abstract void drawStone(Graphics g);

	public void setPosition(int x, int y) {
		srartRosX = x;
		srartRosY = y;
	}
}
