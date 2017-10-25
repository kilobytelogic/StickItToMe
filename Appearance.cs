using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickItToMe
{
    public partial class Appearance : Form
    {
        public Appearance(Pad pad)
        {
            InitializeComponent();
            previewTb.Font = pad.tb.Font;
            previewTb.BackColor = pad.tb.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = previewTb.Font;

            DialogResult res = fd.ShowDialog();

            if(res == DialogResult.OK)
            {
                previewTb.Font = fd.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = previewTb.ForeColor;

            DialogResult res = cd.ShowDialog();

            if(res == DialogResult.OK)
            {
                previewTb.ForeColor = cd.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = previewTb.BackColor;

            DialogResult res = cd.ShowDialog();

            if(res == DialogResult.OK)
            {
                previewTb.BackColor = cd.Color;
            }
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
