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
    public partial class HydraHead : Form
    {
        private HydraMain _main;
        public HydraHead(HydraMain main)
        {
            InitializeComponent();
            _main = main;
            Show();
            Update();
        }
        private void HydraHead_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            Random r = new Random();
            r.Next();//Gets rid of the first random number that uses System.Time to function...
            int x = r.Next(Screen.PrimaryScreen.Bounds.Right - Width);
            int y = r.Next(Screen.PrimaryScreen.Bounds.Bottom - Height - 42);
            Location = new Point(x,y);
        }
        private void HydraHead_FormClosing(object sender, FormClosingEventArgs e)
        {
            _main._slayed++;
            _main._heads.Add(new HydraHead(_main));
            _main._heads.Add(new HydraHead(_main));
        }
        private void uxAttack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
