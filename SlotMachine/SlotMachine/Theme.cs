using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    public abstract class Theme 
    {
        public Bitmap[] symbols { get; protected set; }
        public Bitmap bg { get; protected set; }
        public Font font { get; protected set; }

    }

    public class DefaultTheme : Theme
    {
        public DefaultTheme()
        {
            symbols = new Bitmap[] { Properties.Resources.slot_symbol1, Properties.Resources.slot_symbol2, Properties.Resources.slot_symbol3, Properties.Resources.slot_symbol4 };
            bg = Properties.Resources.slot_machine1;
            font = new Font("DePixel", 15.75F);
        }
    }

    public class AnimalTheme : Theme
    {
        public AnimalTheme()
        {
            symbols = new Bitmap[] { Properties.Resources.animal_chicken, Properties.Resources.animal_crab, Properties.Resources.animal_frog, Properties.Resources.animal_turtle };
            bg = Properties.Resources.animal_machine;
            font = new Font("Daydream", 14F);
        }
    }

    public class JewelTheme : Theme
    {
        public JewelTheme()
        {
            symbols = new Bitmap[] { Properties.Resources.jewel_yellow, Properties.Resources.jewel_blue, Properties.Resources.jewel_green, Properties.Resources.jewel_red };
            bg = Properties.Resources.jewel_machine;
            font = new Font("Mario Kart DS", 25F);
        }
    }
}
