using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydra
{
    public partial class Score : Form
    {
        public Score(HydraMain main)
        {
            InitializeComponent();
            String score = main._slayed + "";
            while (score.Length < 7)
                score = "0" + score;
            uxLabel.Text = "Congrats, You Chopped " + score + " Heads!";
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.GetBounds(new Point()).Width / 2 - Width / 2,
                Screen.GetBounds(new Point()).Height / 2 - Height / 2);
        }
    }
}
