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
    public partial class HydraMain : Form
    {
        public IList<HydraHead> _heads = new List<HydraHead>();
        public int _slayed = 0;
        public HydraMain()
        {
            InitializeComponent();
        }
        private void HydraMain_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.GetBounds(new Point()).Width / 2 - Width / 2,
                Screen.GetBounds(new Point()).Height / 2 - Height / 2);
        }
        private void uxStart_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            _heads.Add(new HydraHead(this));
        }
        private void HydraMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Opacity = 0;
            new Score(this).ShowDialog();
        }
    }
}
