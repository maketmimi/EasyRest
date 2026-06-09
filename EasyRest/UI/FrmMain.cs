using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void UpdateStartStopCheckBox()
        {
            Color ColorToSet =
                ChkStartStop.Checked ?
                Color.FromArgb(0, 192, 0) :
                Color.FromArgb(192, 0, 0);

            ChkStartStop.BackColor = ColorToSet;
            ChkStartStop.FlatAppearance.MouseDownBackColor = ColorToSet;
            ChkStartStop.FlatAppearance.MouseOverBackColor = ColorToSet;

            ChkStartStop.Text =
                ChkStartStop.Checked ?
                "يعمل" : "متوقف";

        }

        private void ChkStartStop_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStartStopCheckBox();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateStartStopCheckBox();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();

            frmAbout.ShowDialog();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
