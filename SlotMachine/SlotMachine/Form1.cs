using SlotMachine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        public DefaultTheme defaultTheme = new DefaultTheme();
        public AnimalTheme animalTheme = new AnimalTheme();
        public JewelTheme jewelTheme = new JewelTheme ();

        private Slot slotMachine;
        private PictureBox[] pictureBoxes;
        private Reel[] reels;

        public Form1()
        {
            InitializeComponent();

            pictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3 };

            reels = new Reel[pictureBoxes.Length];
            InitReels(defaultTheme);

            slotMachine = new Slot(1000, reels);

            bal.Text = "BAL: " + slotMachine.Balance ;
            

            MakeTransparent(pictureBox1, bg_pic);
            MakeTransparent(pictureBox2, bg_pic);
            MakeTransparent(pictureBox3, bg_pic);
            MakeTransparent(lever, bg_pic);
            MakeTransparent(bet, bg_pic);
            MakeTransparent(bal, bg_pic);
            MakeTransparent(lblResult, bg_pic);
            betBox.BackColor = Color.FromArgb(110, 121, 166);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int stake;
            Int32.TryParse(betBox.Text, out stake);

            lever.Image = Properties.Resources.slot_machine3;
            if (slotMachine.Balance == 0)
            {
                MessageBox.Show("You lost all your money.");
            }
            else if (stake == 0)
            {
                MessageBox.Show("Please enter a bet.");
            }
            else if (stake <= slotMachine.Balance)
            {
                slotMachine.Stake = stake;
                slotMachine.UpdateBalance(-stake);
                bal.Text = "BAL: " + slotMachine.Balance;
                lever.Enabled = false; // Disable the button during spin
                slotMachine.Spin(); // Spin the reels
                lever.Enabled = true;
                lblResult.Text = ""; // Clear any previous result
                int winnings = slotMachine.CheckResult(); // Check the result and update the UI accordingly
                slotMachine.UpdateBalance(winnings);
                // Update the result label
                if (winnings > 0)
                {
                    lblResult.Text = "YOU WON P" + winnings + "!";
                }
                else
                {
                    lblResult.Text = "NO LUCK THIS TIME!";
                }
                bal.Text = "BAL: " + slotMachine.Balance;
                betBox.Clear();
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lever.Image = Properties.Resources.slot_machine2;
            
            timer1.Stop();
            
        }

        static void MakeTransparent(Control form, Control parent)
        {
            form.Parent = parent;
            form.BackColor = Color.Transparent;
            form.Location = new Point(form.Location.X - parent.Location.X, form.Location.Y - parent.Location.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(betBox.Text, "[^0-9]"))
            {
                betBox.Text = betBox.Text.Remove(betBox.Text.Length - 1);
                betBox.Select(betBox.Text.Length, 0);
            }
        }

        private void fruitRadio_CheckedChanged(object sender, EventArgs e)
        {
            bg_pic.BackgroundImage = defaultTheme.bg;
            bal.Font = defaultTheme.font;
            bet.Font = defaultTheme.font;
            lblResult.Font = defaultTheme.font;
            betBox.Font = defaultTheme.font;
            betBox.BackColor = Color.FromArgb(110, 121, 166);
            string temp = bal.Text;
            slotMachine = new Slot(Int32.Parse(bal.Text.Split(':')[1]), reels);
            InitReels(defaultTheme);
            Refresh();
        }

        private void animalRadio_CheckedChanged(object sender, EventArgs e)
        {
            bg_pic.BackgroundImage = animalTheme.bg;
            bal.Font = animalTheme.font;
            bet.Font = animalTheme.font;
            lblResult.Font = animalTheme.font;
            betBox.Font = animalTheme.font;
            betBox.BackColor = Color.FromArgb(156, 120, 123);
            slotMachine = new Slot(Int32.Parse(bal.Text.Split(':')[1]), reels);
            InitReels(animalTheme);
            Refresh();
        }


        private void jewelRadio_CheckedChanged(object sender, EventArgs e)
        {
            bg_pic.BackgroundImage = jewelTheme.bg;
            bal.Font = jewelTheme.font;
            bet.Font = jewelTheme.font;
            lblResult.Font = jewelTheme.font;
            betBox.Font = jewelTheme.font;
            betBox.BackColor = Color.FromArgb(125, 156, 120);
            slotMachine = new Slot(Int32.Parse(bal.Text.Split(':')[1]), reels);
            InitReels(jewelTheme);
            Refresh();
        }
        public void InitReels(Theme _theme)
        {
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                reels[i] = new Reel(pictureBoxes[i], _theme);
            }

            foreach (Reel _reel in reels)
            {
                _reel.UpdateSymbol();
            }
        }
    }
}
