import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Adamant extends Jewelry implements Serializable {
	public Adamant(int weight, int price, int hardness, Color color) {
		this.Weight = weight;
		this.Price = price;
		this.Hardness = hardness;
		this.ColorStone = color;

		srartRosX = 100;
		srartRosY = 100;
	}

	protected void setWeight(int w) {
		if (w > 0 && w < 34)
			super.Weight = w;
		else
			super.Weight = 15;
	}

	public int getWeight() {
		return super.Weight;
	}

	protected void setPrice(int p) {
		if (p > 0 && p < 10000)
			super.Price = p;
		else
			super.Price = 5000;
	}

	public int getPrice() {
		return super.Price;
	}

	protected void setHardness(int h) {
		if (h > 0 && h < 11)
			super.Hardness = h;
		else
			super.Hardness = 10;
	}

	public int getHardness() {
		return super.Hardness;
	}

	public void drawStone(Graphics g) {
		drawAdamant(g);
	}

	protected void drawAdamant(Graphics g) {
		g.setColor(ColorStone);
		g.drawLine(srartRosX, srartRosY, srartRosX - 30, srartRosY - 30);
		g.drawLine(srartRosX, srartRosY, srartRosX + 30, srartRosY - 30);
		g.drawLine(srartRosX - 30, srartRosY - 30, srartRosX - 25, srartRosY - 35);
		g.drawLine(srartRosX + 30, srartRosY - 30, srartRosX + 25, srartRosY - 35);
		g.drawLine(srartRosX - 25, srartRosY - 35, srartRosX + 25, srartRosY - 35);
	}
	
	public String getInfo() {
		// TODO Auto-generated method stub
		return Weight + ";" + Price + ";" + Hardness + ";" + ColorStone;

	}
	
	private void writeObject(ObjectOutputStream s) throws IOException {
        s.defaultWriteObject();
        s.writeInt(ColorStone.getRed());
        s.writeInt(ColorStone.getGreen());
        s.writeInt(ColorStone.getBlue());
    }

    private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException {
        s.defaultReadObject();
        int red = s.readInt();
        int green = s.readInt();
        int blue = s.readInt();
        ColorStone = new Color(red, green, blue);
    }
}
