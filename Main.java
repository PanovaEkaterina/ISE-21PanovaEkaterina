import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JTextField;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Main {

	private JFrame frame;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Main window = new Main();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	Parking parking;
	private JTextField textFieldTake;

	public Main() {
		parking = new Parking();
		initialize();
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 676, 368);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new Panel_parking(parking);
		panel.setBounds(10, 11, 536, 307);
		frame.getContentPane().add(panel);

		JButton btnAdamant = new JButton("\u0410\u043B\u043C\u0430\u0437");
		btnAdamant.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Color colorDialog = JColorChooser.showDialog(null, "JColorChooser Sample", null);
				if (colorDialog != null) {
					Stone stone = new Adamant(100, 4, 1, colorDialog);
					int place = parking.PutStoneInShowcase(stone);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "Ваше место:" + place);
				}
			}
		});
		btnAdamant.setBounds(556, 11, 94, 23);
		frame.getContentPane().add(btnAdamant);

		JButton buttonDiamond = new JButton("\u0411\u0440\u0438\u043B\u043B\u0438\u0430\u043D\u0442");
		buttonDiamond.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null, "JColorChooser Sample", null);
				if (colorDialog1 != null) {
					Color colorDialog = JColorChooser.showDialog(null, "JColorChooser Sample", null);
					if (colorDialog != null) {
						Stone stone = new Diamond(100, 4, 1, colorDialog, true, colorDialog);
						int place = parking.PutStoneInShowcase(stone);
						panel.repaint();
						JOptionPane.showMessageDialog(null, "Ваше место:" + place);
					}
				}
			}
		});
		buttonDiamond.setBounds(556, 55, 94, 23);
		frame.getContentPane().add(buttonDiamond);

		JButton btnGetStone = new JButton("\u0417\u0430\u0431\u0440\u0430\u0442\u044C");
		btnGetStone.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkPlace(textFieldTake.getText())) {
					Stone car = parking.GetStoneInShowcase(Integer.parseInt(textFieldTake.getText()));
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					car.setPosition(5, 5);
					car.drawStone(gr);
					panel.repaint();
				}
			}
		});
		btnGetStone.setBounds(556, 123, 89, 23);
		frame.getContentPane().add(btnGetStone);

		textFieldTake = new JTextField();
		textFieldTake.setBounds(556, 157, 86, 20);
		frame.getContentPane().add(textFieldTake);
		textFieldTake.setColumns(10);
	}

	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		if (Integer.parseInt(str) > 20)
			return false;
		return true;
	}
}
