using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Reel
    {
        private Theme theme;
        private Random rand;
        private int rn;
        private readonly PictureBox pictureBox;
        public Reel(PictureBox _pictureBox, Theme _theme)
        {
            pictureBox = _pictureBox;
            theme = _theme;
        }

        public void UpdateSymbol()
        {
            pictureBox.Image = theme.symbols[rn];
            pictureBox.Invalidate();
        }
        public int Spin()
        {
            rand = new Random(Guid.NewGuid().GetHashCode());
            rn = rand.Next(theme.symbols.Length);
            UpdateSymbol();

            return rn;
        }
    }
}

