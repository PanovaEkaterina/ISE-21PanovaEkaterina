import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.BevelBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JColorChooser;
import javax.swing.JFileChooser;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.awt.event.ActionEvent;
import javax.swing.JList;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;

public class Main {
	private JFrame frame;
	private JTextField textFieldTake;
	Parking parking;

	private String[] elements = new String[6];

	JList listlevel;
	JPanel panel;

	SelectStone select;

	private static Logger log;

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
		parking = new Parking(5);

		log = Logger.getLogger(Main.class.getName());
		FileHandler fh = null;
		try {
			fh = new FileHandler("D://file.txt");
		} catch (SecurityException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		log.addHandler(fh);
		initialize();

		for (int i = 0; i < 5; i++) {
			elements[i] = "Уровень " + (i + 1);
		}

		listlevel.setSelectedIndex(parking.getCurrentLevel());
	}

	/**
	 * @throws ParkingOverflowException
	 */

	public void getStone() {
		select = new SelectStone(frame);
		if (select.res()) {
			Stone stone = select.getStone();

			int place = 0;
			try {
				place = parking.PutStoneInShowcase(stone);
				log.log(Level.INFO, "Положили камень на место " + place);
			} catch (ParkingOverflowException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
				JOptionPane.showMessageDialog(null, "Ошибка переполнения");
			} catch (Exception ex) {
				JOptionPane.showMessageDialog(null, "Общая ошибка");
			}
			panel.repaint();
			JOptionPane.showMessageDialog(frame, "Ваше место:" + place);
		}
	}

	private void initialize() {

		frame = new JFrame();
		frame.setBounds(100, 100, 473, 562);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		panel = new Panel_parking(parking);
		panel.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		panel.setBounds(10, 11, 213, 501);
		frame.getContentPane().add(panel);

		JPanel panelTake = new JPanel();
		panelTake.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		panelTake.setBounds(257, 284, 167, 126);
		frame.getContentPane().add(panelTake);

		textFieldTake = new JTextField();
		textFieldTake.setBounds(367, 196, 57, 20);
		frame.getContentPane().add(textFieldTake);
		textFieldTake.setColumns(10);

		JLabel lblNewLabel = new JLabel("\u041C\u0435\u0441\u0442\u043E");
		lblNewLabel.setBounds(270, 199, 46, 14);
		frame.getContentPane().add(lblNewLabel);

		JButton btnGetStone = new JButton("\u0417\u0430\u0431\u0440\u0430\u0442\u044C");
		btnGetStone.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (checkPlace(textFieldTake.getText())) {
					Stone stone = null;
					try {
						stone = parking.GetStoneInShowcase(Integer.parseInt(textFieldTake.getText()));
						log.log(Level.INFO, "Забрали камень с места " + textFieldTake.getText());
					} catch (ParkingIndexOutOfRangeException e) {
						// TODO Auto-generated catch block
						JOptionPane.showMessageDialog(null, "Неверный номер");
					} catch (Exception ex) {
						JOptionPane.showMessageDialog(null, "Общая ошибка");
					}
					Graphics gr = panelTake.getGraphics();
					gr.clearRect(0, 0, panelTake.getWidth(), panelTake.getHeight());
					stone.setPosition(100, 50);
					stone.drawStone(gr);
					panel.repaint();
				}
			}
		});
		btnGetStone.setBounds(306, 227, 89, 23);
		frame.getContentPane().add(btnGetStone);

		listlevel = new JList(elements);
		listlevel.setBounds(247, 11, 177, 90);
		frame.getContentPane().add(listlevel);

		JButton btnDown = new JButton("<");
		btnDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				parking.LevelDown();
				log.log(Level.INFO, "Переход на уровень ниже Текущий уровень:" + parking.getCurrentLevel());
				listlevel.setSelectedIndex(parking.getCurrentLevel());
				panel.repaint();
			}
		});
		btnDown.setBounds(247, 112, 41, 23);
		frame.getContentPane().add(btnDown);

		JButton btnUp = new JButton(">");
		btnUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				parking.LevelUp();
				log.log(Level.INFO, "Переход на уровень выше Текущий уровень:" + parking.getCurrentLevel());
				listlevel.setSelectedIndex(parking.getCurrentLevel());
				panel.repaint();
			}
		});
		btnUp.setBounds(383, 112, 41, 23);
		frame.getContentPane().add(btnUp);

		JButton btnAdd = new JButton("\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C");
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				getStone();
			}
		});
		btnAdd.setBounds(257, 146, 167, 23);
		frame.getContentPane().add(btnAdd);

		JMenuBar menuBar = new JMenuBar();
		JMenu menu = new JMenu("File");
		frame.setJMenuBar(menuBar);
		menuBar.add(menu);
		JMenuItem menuSave = new JMenuItem("Save");
		menu.add(menuSave);
		JMenuItem menuOpen = new JMenuItem("Open");
		menu.add(menuOpen);

		menuSave.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				JFileChooser filesave = new JFileChooser();

				if (filesave.showDialog(null, "Save") == JFileChooser.APPROVE_OPTION) {
					try {
						if (parking.save(filesave.getSelectedFile().getPath()))
							if (filesave.getSelectedFile().getPath() != null)
								JOptionPane.showMessageDialog(frame, "Сохранение прошло успешно");
					} catch (IOException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
						JOptionPane.showMessageDialog(frame, "Не получилось сохранить");
					}
				}
			}
		});

		menuOpen.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				JFileChooser fileopen = new JFileChooser();
				if (fileopen.showDialog(null, "Open") == JFileChooser.APPROVE_OPTION) {
					if (parking.load(fileopen.getSelectedFile().getPath()))
						if (fileopen.getSelectedFile().getPath() != null)
							JOptionPane.showMessageDialog(frame, "Закрузили");
				}
				panel.repaint();
			}
		});

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
