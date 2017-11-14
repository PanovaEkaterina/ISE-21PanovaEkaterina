import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.BevelBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JCheckBox;
import javax.swing.JColorChooser;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Main {

	private JFrame frame;
	private JTextField textFieldTake;
	Parking parking;

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

	public Main() {
		parking = new Parking();
		initialize();
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 676, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new Panel_parking(parking);
		panel.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		panel.setBounds(10, 11, 505, 239);
		frame.getContentPane().add(panel);

		JButton btnNewButtonAdamant = new JButton(
				"\u0417\u0430\u0434\u0430\u0442\u044C \u0430\u043B\u043C\u0430\u0437");
		btnNewButtonAdamant.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog = JColorChooser.showDialog(null, "JColorChooser Sample", null);
				if (colorDialog != null) {
					Stone stone = new Adamant(100, 4, 1, colorDialog);
					int place = parking.PutStoneInShowcase(stone);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "Ваше место:" + place);
				}
			}
		});
		btnNewButtonAdamant.setBounds(525, 11, 125, 23);
		frame.getContentPane().add(btnNewButtonAdamant);

		JButton buttonDiamond = new JButton(
				"\u0417\u0430\u0434\u0430\u0442\u044C \u0431\u0440\u0438\u043B\u043B\u0438\u0430\u043D\u0442");
		buttonDiamond.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
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
		buttonDiamond.setBounds(525, 45, 125, 23);
		frame.getContentPane().add(buttonDiamond);

		textFieldTake = new JTextField();
		textFieldTake.setBounds(593, 143, 57, 20);
		frame.getContentPane().add(textFieldTake);
		textFieldTake.setColumns(10);

		JLabel lblNewLabel = new JLabel("\u041C\u0435\u0441\u0442\u043E");
		lblNewLabel.setBounds(525, 146, 46, 14);
		frame.getContentPane().add(lblNewLabel);

		JButton btnGetStone = new JButton("\u0417\u0430\u0431\u0440\u0430\u0442\u044C");
		btnGetStone.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (checkPlace(textFieldTake.getText())) {
					Stone stone = parking.GetStoneInShowcase(Integer.parseInt(textFieldTake.getText()));
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					stone.setPosition(5, 5);
					stone.drawStone(gr);
					panel.repaint();
				}
			}
		});
		btnGetStone.setBounds(546, 178, 89, 23);
		frame.getContentPane().add(btnGetStone);
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
