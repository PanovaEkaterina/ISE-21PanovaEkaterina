import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.SystemColor;
import java.awt.datatransfer.DataFlavor;
import java.awt.datatransfer.UnsupportedFlavorException;
import java.awt.dnd.DnDConstants;
import java.awt.dnd.DropTarget;
import java.awt.dnd.DropTargetDragEvent;
import java.awt.dnd.DropTargetDropEvent;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.io.IOException;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;

import javax.swing.JButton;
import javax.swing.JComponent;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.TransferHandler;
import javax.swing.SwingConstants;
import javax.swing.border.BevelBorder;

public class SelectStone extends JDialog {

	Stone stone = null;
	JPanel panel;
	boolean r;

	private Logger log;

	public SelectStone(JFrame parent) {
		super(parent, true);
		main();
	}

	public boolean res() {
		setVisible(true);
		return r;
	}

	public void main() {
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
		
		this.getContentPane().setBackground(SystemColor.controlHighlight);
		this.setBounds(100, 100, 420, 300);
		this.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
		this.getContentPane().setLayout(null);

		JLabel lblAdamant = new JLabel("Adamant");
		lblAdamant.setHorizontalAlignment(SwingConstants.CENTER);
		lblAdamant.setBounds(10, 29, 89, 24);
		this.getContentPane().add(lblAdamant);

		JLabel lblDiamond = new JLabel("Diamond");
		lblDiamond.setHorizontalAlignment(SwingConstants.CENTER);
		lblDiamond.setBounds(10, 64, 89, 14);
		this.getContentPane().add(lblDiamond);

		panel = new JPanel();
		panel.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		FlowLayout flowLayout = (FlowLayout) panel.getLayout();
		panel.setBounds(126, 29, 153, 110);
		this.getContentPane().add(panel);

		MouseListener mouseL = new MouseListener() {

			@Override
			public void mouseClicked(MouseEvent e) {
				// TODO Auto-generated method stub

			}

			@Override
			public void mouseEntered(MouseEvent e) {
				// TODO Auto-generated method stub

			}

			@Override
			public void mouseExited(MouseEvent e) {
				// TODO Auto-generated method stub

			}

			@Override
			public void mousePressed(MouseEvent e) {
				// TODO Auto-generated method stub
				JComponent jc = (JComponent) e.getSource();
				TransferHandler th = jc.getTransferHandler();
				th.exportAsDrag(jc, e, TransferHandler.COPY);
			}

			@Override
			public void mouseReleased(MouseEvent e) {
				// TODO Auto-generated method stub

			}

		};

		lblAdamant.addMouseListener(mouseL);
		lblDiamond.addMouseListener(mouseL);
		lblDiamond.setTransferHandler(new TransferHandler("text"));
		lblAdamant.setTransferHandler(new TransferHandler("text"));

		panel.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {

				try {

					for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
						if (e.getTransferable().getTransferData(df) == "Adamant") {
							stone = new Adamant(100, 4, 500, Color.BLACK);
						} else if (e.getTransferable().getTransferData(df) == "Diamond") {
							stone = new Diamond(100, 4, 500, Color.BLACK, true, Color.BLACK);
						}
						draw(panel, stone);
					}
				} catch (Exception ex) {
					System.out.println(ex);
				}

			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (Exception e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}
			}
		});

		JPanel panelYellow = new JPanel();
		panelYellow.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		panelYellow.setName("yellow");
		panelYellow.setBackground(Color.YELLOW);
		panelYellow.setBounds(347, 83, 31, 39);
		this.getContentPane().add(panelYellow);

		JPanel panelBlue = new JPanel();
		panelBlue.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		panelBlue.setName("blue");
		panelBlue.setBackground(Color.BLUE);
		panelBlue.setBounds(347, 29, 31, 39);
		this.getContentPane().add(panelBlue);

		JPanel panelRed = new JPanel();
		panelRed.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		panelRed.setName("red");
		panelRed.setBackground(Color.RED);
		panelRed.setBounds(306, 83, 31, 39);
		this.getContentPane().add(panelRed);

		JPanel panelGreen = new JPanel();
		panelGreen.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		panelGreen.setName("green");
		panelGreen.setBackground(Color.GREEN);
		panelGreen.setBounds(306, 133, 31, 39);
		this.getContentPane().add(panelGreen);

		JPanel panelBlack = new JPanel();
		panelBlack.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		panelBlack.setName("black");
		panelBlack.setBackground(Color.BLACK);
		panelBlack.setBounds(306, 29, 31, 39);
		this.getContentPane().add(panelBlack);

		JPanel panelPink = new JPanel();
		panelPink.setBorder(new BevelBorder(BevelBorder.LOWERED, null, null, null, null));
		panelPink.setName("pink");
		panelPink.setBackground(Color.PINK);
		panelPink.setBounds(347, 133, 31, 39);
		this.getContentPane().add(panelPink);

		panelYellow.addMouseListener(mouseL);
		panelYellow.setTransferHandler(new TransferHandler("name"));

		panelBlue.addMouseListener(mouseL);
		panelBlue.setTransferHandler(new TransferHandler("name"));

		panelRed.addMouseListener(mouseL);
		panelRed.setTransferHandler(new TransferHandler("name"));

		panelGreen.addMouseListener(mouseL);
		panelGreen.setTransferHandler(new TransferHandler("name"));

		panelBlack.addMouseListener(mouseL);
		panelBlack.setTransferHandler(new TransferHandler("name"));

		panelPink.addMouseListener(mouseL);
		panelPink.setTransferHandler(new TransferHandler("name"));

		JButton btnAdd = new JButton("\u0414\u043E\u0431\u0430\u0432\u0438\u0442\u044C");
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				log.log(Level.INFO, "Добавили камень ");
				r = true;
				JOptionPane.showMessageDialog(panel, "Добавили камень");
				dispose();
			}
		});
		btnAdd.setBounds(10, 133, 106, 23);
		this.getContentPane().add(btnAdd);

		JButton btnNO = new JButton("\u041E\u0442\u043C\u0435\u043D\u0430");
		btnNO.setBounds(10, 187, 106, 23);
		this.getContentPane().add(btnNO);
		btnNO.addActionListener((ActionEvent e) -> {
			r = false;
			dispose();
		});

		JButton btnBaseColor = new JButton("\u041E\u0441\u043D. \u0446\u0432\u0435\u0442");
		btnBaseColor.setBounds(146, 149, 122, 23);
		getContentPane().add(btnBaseColor);

		JButton btnDopColor = new JButton("\u0414\u043E\u043F. \u0446\u0432\u0435\u0442");
		btnDopColor.setBounds(146, 187, 122, 23);
		getContentPane().add(btnDopColor);

		btnBaseColor.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {
				if (stone != null) {
					try {
						for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
							stone.setMainColor((selectColor(e.getTransferable().getTransferData(df).toString())));
							draw(panel, stone);
						}
					} catch (Exception ex) {
						System.out.println(ex + "FF");
					}
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (UnsupportedFlavorException | IOException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}
			}
		});
		btnDopColor.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {
				if (stone != null) {
					try {

						for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
							((Diamond) stone)
									.setDopColor((selectColor(e.getTransferable().getTransferData(df).toString())));
							draw(panel, stone);
						}
					} catch (Exception ex) {
						System.out.println(ex);
					}
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (UnsupportedFlavorException | IOException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}
			}
		});
	}

	public Stone getStone() {
		return stone;
	}

	public void draw(JPanel panel, Stone plane) {
		if (plane != null) {
			Graphics gr = panel.getGraphics();
			gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
			plane.setPosition(70, 50);
			plane.drawStone(gr);
		}
	}

	public static Color selectColor(String s) {
		switch (s) {
		case "yellow":
			return Color.yellow;
		case "blue":
			return Color.blue;
		case "red":
			return Color.red;
		case "green":
			return Color.green;
		case "black":
			return Color.black;
		case "pink":
			return Color.pink;
		}
		return null;
	}
}