import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Diamond extends Adamant implements Serializable {
	private boolean facet;
	transient private Color dopColor;

	public Diamond(int weight, int price, int hardness, Color color, boolean facet, Color dopColor) {
		super(weight, price, hardness, color);
		this.facet = facet;
		this.dopColor = dopColor;
	}

	protected void drawAdamant(Graphics g) {
		super.drawAdamant(g);
		if (facet) {
			g.setColor(dopColor);
			g.drawLine(srartRosX - 30, srartRosY - 30, srartRosX + 30, srartRosY - 30);
			g.drawLine(srartRosX - 25, srartRosY - 35, srartRosX - 13, srartRosY - 30);
			g.drawLine(srartRosX, srartRosY - 35, srartRosX - 13, srartRosY - 30);
			g.drawLine(srartRosX, srartRosY - 35, srartRosX + 13, srartRosY - 30);
			g.drawLine(srartRosX + 25, srartRosY - 35, srartRosX + 13, srartRosY - 30);
			g.drawLine(srartRosX - 10, srartRosY - 30, srartRosX, srartRosY);
			g.drawLine(srartRosX + 13, srartRosY - 30, srartRosX, srartRosY);
		}
	}

	public void setDopColor(Color color) {
		dopColor = color;
	}

	private void writeObject(ObjectOutputStream s) throws IOException {
		s.defaultWriteObject();
		s.writeInt(ColorStone.getRed());
		s.writeInt(ColorStone.getGreen());
		s.writeInt(ColorStone.getBlue());
		s.writeInt(dopColor.getRed());
		s.writeInt(dopColor.getGreen());
		s.writeInt(dopColor.getBlue());
	}

	private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException {
		s.defaultReadObject();
		int red = s.readInt();
		int green = s.readInt();
		int blue = s.readInt();
		ColorStone = new Color(red, green, blue);
		int red1 = s.readInt();
		int green1 = s.readInt();
		int blue1 = s.readInt();
		dopColor = new Color(red1, green1, blue1);
	}

	@Override
	public String getInfo() {
		// TODO Auto-generated method stub
		return Weight + ";" + Price + ";" + Hardness + ";" + ColorStone + ";" + true + ";" + dopColor;
	}

	public int compareTo(Diamond other) {
		int res = ((Adamant) this).compareTo((Adamant) other);
		if (res != 0)
			return res;
		if (facet != other.facet)
			return (facet + "").compareTo(other.facet + "");
		if (dopColor != other.dopColor)
			return dopColor.toString().compareTo(other.dopColor.toString());
		return 0;
	}

	public boolean equals(Diamond other) {
		boolean res = ((Adamant) this).equals((Adamant) other);
		if (!res)
			return res;
		if (facet != other.facet)
			return false;
		if (dopColor != other.dopColor)
			return false;
		return true;
	}

	@Override
	public boolean equals(Object obj) {
		if (obj == null)
			return false;
		Diamond DiamondObj = (Diamond) obj;
		if (DiamondObj == null)
			return false;
		else
			return equals(DiamondObj);
	}
}
