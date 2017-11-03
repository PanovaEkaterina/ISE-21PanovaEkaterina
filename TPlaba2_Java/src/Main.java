import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.BevelBorder;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JCheckBox;
import javax.swing.JColorChooser;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Main {

	private JFrame frame;
	private JTextField textFieldWeight;
	private JTextField textFieldPrice;
	private JTextField textFieldHardness;

	Color color;
	Color dopColor;
	int weight;
	int price;
	int hardness;
	boolean facet;

	private Stone inter;

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
		color = Color.WHITE;
		dopColor = Color.BLACK;
		weight = 15;
		price = 5000;
		hardness = 10;
		initialize();
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new JPanel();
		panel.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		panel.setBounds(10, 11, 414, 147);
		frame.getContentPane().add(panel);

		JLabel lblLabelWeight = new JLabel("\u0412\u0435\u0441");
		lblLabelWeight.setBounds(10, 169, 31, 14);
		frame.getContentPane().add(lblLabelWeight);

		JLabel lblabelPrice = new JLabel("\u0426\u0435\u043D\u0430");
		lblabelPrice.setBounds(10, 194, 46, 14);
		frame.getContentPane().add(lblabelPrice);

		JLabel lblLabelHardness = new JLabel("\u0422\u0432\u0435\u0440\u0434\u043E\u0441\u0442\u044C");
		lblLabelHardness.setBounds(116, 169, 62, 14);
		frame.getContentPane().add(lblLabelHardness);

		JLabel lblLabelColor = new JLabel("\u0426\u0432\u0435\u0442");
		lblLabelColor.setBounds(116, 194, 46, 14);
		frame.getContentPane().add(lblLabelColor);

		textFieldWeight = new JTextField();
		textFieldWeight.setBounds(51, 169, 46, 20);
		frame.getContentPane().add(textFieldWeight);
		textFieldWeight.setColumns(10);

		textFieldPrice = new JTextField();
		textFieldPrice.setColumns(10);
		textFieldPrice.setBounds(51, 191, 46, 20);
		frame.getContentPane().add(textFieldPrice);

		textFieldHardness = new JTextField();
		textFieldHardness.setColumns(10);
		textFieldHardness.setBounds(180, 166, 46, 20);
		frame.getContentPane().add(textFieldHardness);

		JCheckBox chckbxCheckBoxFacet = new JCheckBox("\u0413\u0440\u0430\u043D\u0438");
		chckbxCheckBoxFacet.setBounds(261, 165, 97, 23);
		frame.getContentPane().add(chckbxCheckBoxFacet);

		JLabel labeldopColor = new JLabel("\u0426\u0432\u0435\u0442");
		labeldopColor.setBounds(271, 194, 31, 14);
		frame.getContentPane().add(labeldopColor);

		JButton btnNewButtonAdamant = new JButton(
				"\u0417\u0430\u0434\u0430\u0442\u044C \u0430\u043B\u043C\u0430\u0437");
		btnNewButtonAdamant.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					inter = new Adamant(weight, price, hardness, color);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawStone(gr);
				}
			}
		});
		btnNewButtonAdamant.setBounds(51, 219, 125, 23);
		frame.getContentPane().add(btnNewButtonAdamant);

		JButton buttonDiamond = new JButton(
				"\u0417\u0430\u0434\u0430\u0442\u044C \u0431\u0440\u0438\u043B\u043B\u0438\u0430\u043D\u0442");
		buttonDiamond.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (checkFields()) {
					facet = chckbxCheckBoxFacet.isSelected();
					inter = new Diamond(weight, price, hardness, color, facet, dopColor);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawStone(gr);
				}
			}
		});
		buttonDiamond.setBounds(249, 219, 153, 23);
		frame.getContentPane().add(buttonDiamond);

		JButton btnButtonColor = new JButton("");
		btnButtonColor.setForeground(color);
		btnButtonColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color initialBackground = btnButtonColor.getForeground();
				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
				if (foreground != null) {
					btnButtonColor.setForeground(foreground);
				}
				color = foreground;
			}
		});
		btnButtonColor.setBounds(172, 191, 54, 23);
		frame.getContentPane().add(btnButtonColor);

		JButton buttonDopColor = new JButton("");
		buttonDopColor.setForeground(dopColor);
		buttonDopColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color initialBackground = buttonDopColor.getForeground();
				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
				if (foreground != null) {
					buttonDopColor.setForeground(foreground);
				}
				dopColor = foreground;
			}
		});
		buttonDopColor.setBounds(301, 190, 54, 23);
		frame.getContentPane().add(buttonDopColor);
	}

	private boolean checkParse(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		return true;
	}

	private boolean checkFields() {
		if (checkParse(textFieldWeight.getText())) {
			weight = Integer.parseInt(textFieldWeight.getText());
		} else
			return false;

		if (checkParse(textFieldPrice.getText())) {
			price = Integer.parseInt(textFieldPrice.getText());
		} else
			return false;

		if (checkParse(textFieldHardness.getText())) {
			hardness = Integer.parseInt(textFieldHardness.getText());
		} else
			return false;

		return true;
	}
}
