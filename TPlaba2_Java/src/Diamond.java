import java.awt.Color;
import java.awt.Graphics;

public class Diamond extends Adamant {
	private boolean facet;
	private Color dopColor;

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
}
