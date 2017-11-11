import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JSpinner;
import javax.swing.JRadioButton;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import java.awt.Font;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Main {

	private JFrame frame;

	private Egg[] eggs;

	private Sugar sugar;

	private Flour flour;

	private Dough d;

	private Apple[] apples;

	private WaterTap waterTap;

	private Knife knife;

	private Pan pan;

	private Stove stove;

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
		initialize();
	}

	private void initialize() {
		waterTap = new WaterTap();
		knife = new Knife();
		pan = new Pan();
		stove = new Stove();
		d = new Dough();
		sugar = new Sugar();
		flour = new Flour();

		frame = new JFrame();
		frame.setBounds(100, 100, 620, 331);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JLabel LabelEgg = new JLabel("\u042F\u0438\u0446\u0430");
		LabelEgg.setBounds(10, 31, 35, 14);
		frame.getContentPane().add(LabelEgg);

		JLabel labelApple = new JLabel("\u042F\u0431\u043B\u043E\u043A\u0438");
		labelApple.setBounds(10, 56, 48, 14);
		frame.getContentPane().add(labelApple);

		JSpinner spinnerEgg = new JSpinner();
		spinnerEgg.setBounds(55, 28, 29, 20);
		frame.getContentPane().add(spinnerEgg);

		JSpinner spinnerApple = new JSpinner();
		spinnerApple.setBounds(55, 53, 29, 20);
		frame.getContentPane().add(spinnerApple);

		JButton btnAddIngregient = new JButton("\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C");
		btnAddIngregient.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (Integer.parseInt((spinnerEgg.getValue()).toString()) < 1
						|| Integer.parseInt((spinnerApple.getValue()).toString()) < 1) {
					JOptionPane.showMessageDialog(frame, "Добавьте ингредиенты");
					return;
				} else {
					eggs = new Egg[Integer.parseInt((spinnerEgg.getValue()).toString())];
					d.Init(eggs.length);
					for (int i = 0; i < eggs.length; ++i) {
						eggs[i] = new Egg();
					}

					apples = new Apple[Integer.parseInt((spinnerApple.getValue()).toString())];

					for (int i = 0; i < apples.length; ++i) {
						apples[i] = new Apple();
					}

					JOptionPane.showMessageDialog(frame, "Ингредиенты добавлены");
				}
			}
		});
		btnAddIngregient.setBounds(8, 88, 97, 23);
		frame.getContentPane().add(btnAddIngregient);
		
		JCheckBox checkBoxCloseStove = new JCheckBox("\u0412\u044B\u043A\u043B");
		
		JCheckBox chckbxOpenStove = new JCheckBox("\u0412\u043A\u043B");
		chckbxOpenStove.setBounds(218, 158, 55, 23);
		frame.getContentPane().add(chckbxOpenStove);
		chckbxOpenStove.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				stove.setState(true);
				checkBoxCloseStove.setSelected(false);
			}
		});

		
		checkBoxCloseStove.setSelected(true);
		checkBoxCloseStove.setBounds(285, 158, 74, 23);
		frame.getContentPane().add(checkBoxCloseStove);
		checkBoxCloseStove.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				stove.setState(false);
			}
		});

		JRadioButton radioButtonClose = new JRadioButton("\u0417\u0430\u043A\u0440\u044B\u0442");
		radioButtonClose.setSelected(true);
		radioButtonClose.setBounds(145, 52, 80, 23);
		frame.getContentPane().add(radioButtonClose);
		radioButtonClose.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				waterTap.setState(false);
			}
		});

		JRadioButton rdbtnOpen = new JRadioButton("\u041E\u0442\u043A\u0440\u044B\u0442");
		rdbtnOpen.setBounds(145, 27, 80, 23);
		frame.getContentPane().add(rdbtnOpen);
		rdbtnOpen.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				waterTap.setState(true);
				radioButtonClose.setSelected(false);
			}
		});

		JButton btnWaterTap = new JButton("\u041F\u043E\u043C\u044B\u0442\u044C \u044F\u0431\u043B\u043E\u043A\u0438");
		btnWaterTap.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				if (waterTap.getState()) {
					if (apples == null) {
						JOptionPane.showMessageDialog(frame, "Яблок нет, что мыть?");
						return;
					}

					if (apples.length == 0) {
						JOptionPane.showMessageDialog(frame, "Яблок нет, что мыть?");
						return;
					}

					pan.Init(apples.length);

					for (int i = 0; i < apples.length; ++i) {
						apples[i].setDirty(false);
					}

					JOptionPane.showMessageDialog(frame, "Яблоки помыли, можно резать");
					radioButtonClose.setSelected(true);
					rdbtnOpen.setSelected(false);
					spinnerApple.setEnabled(false);
				} else
					JOptionPane.showMessageDialog(frame, "Кран закрыт, как мыть?");
			}
		});
		btnWaterTap.setBounds(128, 88, 130, 23);
		frame.getContentPane().add(btnWaterTap);

		JCheckBox chckbxEgg = new JCheckBox("\u042F\u0438\u0446\u0430");
		chckbxEgg.setBounds(450, 31, 97, 23);
		frame.getContentPane().add(chckbxEgg);

		JButton btnCutEgg = new JButton("\u0420\u0430\u0437\u0431\u0438\u0442\u044C \u044F\u0438\u0446\u0430");
		btnCutEgg.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (eggs == null) {
					JOptionPane.showMessageDialog(frame, "Яиц то нет, что разбивать собрались?");
					return;
				}

				if (eggs.length == 0) {
					JOptionPane.showMessageDialog(frame, "Яиц то нет, что разбивать собрались?");
					return;
				}

				for (int i = 0; i < eggs.length; ++i) {
					eggs[i].SetHave_shell_egg(false);
				}

				for (int i = 0; i < eggs.length; ++i) {
					knife.Cut_Egg(eggs[i]);
				}
				JOptionPane.showMessageDialog(frame, "Яицa разбили");
				spinnerEgg.setEnabled(false);
				chckbxEgg.setSelected(true);
			}
		});
		btnCutEgg.setBounds(271, 27, 119, 23);
		frame.getContentPane().add(btnCutEgg);

		JRadioButton AddApple = new JRadioButton(
				"\u0412\u044B\u043B\u043E\u0436\u0438\u0442\u044C \u044F\u0431\u043B\u043E\u043A\u0438");
		AddApple.setBounds(10, 191, 149, 23);
		frame.getContentPane().add(AddApple);

		JButton buttonCutApple = new JButton("P\u0435\u0437\u0430\u0442\u044C \u044F\u0431\u043B\u043E\u043A\u0438");
		buttonCutApple.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (apples == null) {
					JOptionPane.showMessageDialog(frame, "Яблок то нет, что резать?");
					return;
				}

				if (apples.length == 0) {
					JOptionPane.showMessageDialog(frame, "Яблок то нет, что резать?");
					return;
				}
				for (int i = 0; i < apples.length; ++i) {
					if (apples[i].getDirty() == true) {
						JOptionPane.showMessageDialog(frame, "Яблоки грязные! Сначала помыть, затем резать!");
						return;
					}
				}

				for (int i = 0; i < apples.length; i++) {
					knife.Cut_Apple(apples[i]);
				}
				JOptionPane.showMessageDialog(frame, "Яблоки нарезали");
				AddApple.setSelected(true);

			}
		});
		buttonCutApple.setBounds(271, 52, 119, 23);
		frame.getContentPane().add(buttonCutApple);

		JCheckBox checkBoxSugar = new JCheckBox("\u0421\u0430\u0445\u0430\u0440");
		checkBoxSugar.setBounds(450, 56, 97, 23);
		frame.getContentPane().add(checkBoxSugar);
		checkBoxSugar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				sugar.SetCountSugar(true);
			}
		});

		JCheckBox checkBoxFlour = new JCheckBox("\u041C\u0443\u043A\u0430");
		checkBoxFlour.setBounds(450, 82, 97, 23);
		frame.getContentPane().add(checkBoxFlour);
		checkBoxFlour.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				flour.SetCountFlour(true);
			}
		});

		JRadioButton AddDough = new JRadioButton("\u0417\u0430\u043B\u0438\u0442\u044C \u0442\u0435\u0441\u0442\u043E");
		AddDough.setBounds(10, 217, 109, 23);
		frame.getContentPane().add(AddDough);

		JButton btnDough = new JButton(
				"\u0417\u0430\u043C\u0435\u0441\u0438\u0442\u044C \u0442\u0435\u0441\u0442\u043E");
		btnDough.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if ((eggs != null) && (eggs.length != 0)) {
					for (int i = 0; i < eggs.length; i++) {
						if (eggs[i].GetHave_shell_egg() == true) {
							JOptionPane.showMessageDialog(frame, "Яица не разбиты!");
							return;
						}
					}
				}

				if (eggs == null) {
					JOptionPane.showMessageDialog(frame, "Нет яиц");
					return;
				}

				if (eggs.length == 0) {
					JOptionPane.showMessageDialog(frame, "Нет яиц");
					return;
				} else {
					for (int i = 0; i < eggs.length; i++) {
						d.AddEgg(eggs[i]);
					}
				}

				if (sugar.GetCountSugar() == false) {
					JOptionPane.showMessageDialog(frame, "Добавьте сахар!");
					return;
				} else {
					sugar = new Sugar();
					d.AddSugar(sugar);
				}

				if (flour.GetCountFlour() == false) {
					JOptionPane.showMessageDialog(frame, "Добавьте муку!");
					return;
				} else {
					flour = new Flour();
					d.AddFlour(flour);
				}
				JOptionPane.showMessageDialog(frame, "Тесто замешано");
				btnDough.setEnabled(false);
				AddDough.setSelected(true);
				;
			}
		});
		btnDough.setBounds(425, 112, 136, 23);
		frame.getContentPane().add(btnDough);

		JLabel lblNewLabel = new JLabel(
				"\u0424\u043E\u0440\u043C\u0430 \u0434\u043B\u044F \u0432\u044B\u043F\u0435\u0447\u043A\u0438");
		lblNewLabel.setFont(new Font("Tahoma", Font.BOLD, 12));
		lblNewLabel.setBounds(12, 158, 147, 14);
		frame.getContentPane().add(lblNewLabel);

		JButton btnAddPan = new JButton(
				"\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C \u0432 \u0444\u043E\u0440\u043C\u0443");
		btnAddPan.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (apples == null) {
					JOptionPane.showMessageDialog(frame, "Яблок нет, что выкладывать?");
					return;
				}

				if (apples.length == 0) {
					JOptionPane.showMessageDialog(frame, "Яблок нет, что выкладывать?");
					return;
				}

				for (int i = 0; i < apples.length; i++) {
					if (apples[i].GetHave_skin_apple() == true) {
						JOptionPane.showMessageDialog(frame, "Cначала нужно нарезать яблоки, а затем выкладывать!");
						return;
					}
				}

				for (int i = 0; i < eggs.length; i++) {
					if (eggs[i].GetHave_shell_egg() == true) {
						JOptionPane.showMessageDialog(frame, "Сначала разбейте яица, затем замесите тесто!");
						return;
					}
				}

				for (int i = 0; i < apples.length; ++i) {
					pan.AddApple(apples[i]);
				}

				pan.AddDough(d);
				JOptionPane.showMessageDialog(frame, "Можно ставить в духовку");
				btnAddPan.setEnabled(false);
			}
		});
		btnAddPan.setBounds(10, 247, 149, 23);
		frame.getContentPane().add(btnAddPan);

		JLabel label = new JLabel("\u0418\u043D\u0433\u0440\u0435\u0434\u0438\u0435\u043D\u0442\u044B");
		label.setFont(new Font("Tahoma", Font.BOLD, 12));
		label.setBounds(10, 11, 107, 14);
		frame.getContentPane().add(label);

		JLabel label_1 = new JLabel("\u041A\u0440\u0430\u043D");
		label_1.setFont(new Font("Tahoma", Font.BOLD, 12));
		label_1.setBounds(162, 11, 63, 14);
		frame.getContentPane().add(label_1);

		JLabel label_2 = new JLabel("\u041D\u043E\u0436");
		label_2.setFont(new Font("Tahoma", Font.BOLD, 12));
		label_2.setBounds(316, 11, 63, 14);
		frame.getContentPane().add(label_2);

		JLabel label_3 = new JLabel("\u0422\u0435\u0441\u0442\u043E");
		label_3.setFont(new Font("Tahoma", Font.BOLD, 12));
		label_3.setBounds(461, 11, 63, 14);
		frame.getContentPane().add(label_3);

		JLabel label_4 = new JLabel("\u0414\u0443\u0445\u043E\u0432\u043A\u0430");
		label_4.setFont(new Font("Tahoma", Font.BOLD, 12));
		label_4.setBounds(252, 143, 63, 14);
		frame.getContentPane().add(label_4);
		
		JButton buttonTakePan = new JButton("\u0417\u0430\u0431\u0440\u0430\u0442\u044C");
		buttonTakePan.setEnabled(false);
		buttonTakePan.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(frame, "Приятного аппетита!");
			}
		});
		buttonTakePan.setBounds(226, 265, 97, 23);
		frame.getContentPane().add(buttonTakePan);
		
		JButton buttonCookPan = new JButton("\u0413\u043E\u0442\u043E\u0432\u0438\u0442\u044C");
		
		JButton btnSetPan = new JButton("\u041F\u043E\u0441\u0442\u0430\u0432\u0438\u0442\u044C");
		btnSetPan.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				 if (stove.getState())
		            {
		                if (!pan.Check())
		                {
		                	JOptionPane.showMessageDialog(frame, "Что ставить будем?");
		                    return;
		                }
		                else
		                {
		                    stove.SetPan(pan);
		                    JOptionPane.showMessageDialog(frame, "Поставили в духовку!");
		                    buttonCookPan.setEnabled(true);
		                }
		            }
		            else JOptionPane.showMessageDialog(frame, "Включите духовку!");
			}
		});
		btnSetPan.setBounds(226, 197, 97, 23);
		frame.getContentPane().add(btnSetPan);
		
		buttonCookPan.setEnabled(false);
		buttonCookPan.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				 if (pan.IsReadyPan())
		            {
		                stove.GetPan().Cook();            
		            }
				 JOptionPane.showMessageDialog(frame, "Готово! Можно вынимать.");
				 chckbxOpenStove.setSelected(false); 
				 checkBoxCloseStove.setSelected(true);
				 buttonTakePan.setEnabled(true);
			}
		});
		buttonCookPan.setBounds(226, 231, 97, 23);
		frame.getContentPane().add(buttonCookPan);		
	}
}
