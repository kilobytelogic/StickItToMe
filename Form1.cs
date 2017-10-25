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
    public partial class Pad : Form
    {
        // TODO: Make text size follow note size
        // TODO: Parse Markdown per row
        // TODO: Store notes and state in LiteDB
        // TODO: Manage Always on top state
        // TODO: Ctrl-D Toggles done!
        List<Pad> childTabs = new List<Pad>();
        bool isLastOpenPad = true;
        public bool moveMode = false;
        public bool resizeMode = false;

        Pad parent;

        public Pad()
        {
            InitializeComponent();

            parent = this;
            PadSettings settings = new PadSettings();

            tb.BackColor = settings.BackColor;
            tb.ForeColor = settings.ForeColor;
            this.BackColor = settings.BackColor;
            alwaysOnTopToolStripMenuItem.Checked = settings.TopMost;
            alwaysOnTopToolStripMenuItem.CheckState = settings.TopMost ? CheckState.Checked : CheckState.Unchecked;
            this.TopMost = settings.TopMost;

            this.FormClosed += Pad_FormClosed;
            
        }

        private void Pad_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon.Dispose();
        }

        public Pad(PadSettings settings)
        {

        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void openClosedTabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Populate sub-menu with closed tabs. On hover, show preview of the note where it should appear
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change wether this note should be topmost or not based on context menu click

            ((Pad)((RichTextBox)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl).Parent).TopMost = alwaysOnTopToolStripMenuItem.Checked ? false : true;

            if(alwaysOnTopToolStripMenuItem.Checked == false)
            {
                alwaysOnTopToolStripMenuItem.Checked = true;
                alwaysOnTopToolStripMenuItem.CheckState = CheckState.Checked;
            }
            else
            {
                alwaysOnTopToolStripMenuItem.Checked = false;
                alwaysOnTopToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moveTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveMode = true;
            resizeMode = false;
            prevLocation = null;
        }

        private void resizeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resizeMode = true;
            moveMode = false;
            prevLocation = null;
        }

        Point? prevLocation = null;
        private void tb_MouseMove(object sender, MouseEventArgs e)
        {
            if(moveMode || resizeMode)
            {
                if (prevLocation == null) prevLocation = e.Location;
                else
                {
                    Point diff = new Point(e.Location.X - prevLocation.Value.X, e.Location.Y - prevLocation.Value.Y);
                    Pad form = ((Pad)((RichTextBox)sender).Parent);

                    if (moveMode)
                        form.Location = new Point(form.Location.X + diff.X, form.Location.Y + diff.Y);
                    if (resizeMode)
                    {
                        form.Width = form.Width + diff.X;
                        form.Height = form.Height + diff.Y;
                        prevLocation = (Point?)e.Location;
                    }

                }
            }
            else
            {
                //RichTextBox rtb = sender as RichTextBox;
            }

        }

        private void tb_Click(object sender, EventArgs e)
        {
            if(moveMode || resizeMode)
            {
                moveMode = false;
                resizeMode = false;
                prevLocation = null;
            }
        }

        Graphics g = null;
        private void tb_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_MouseHover(object sender, EventArgs e)
        {
            if (moveMode || resizeMode) return;
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
        }

        private void tb_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void changeTabAppearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appearance app = new Appearance(this);
            DialogResult res = app.ShowDialog(parent);

            if(res == DialogResult.OK)
            {
                this.BackColor = app.previewTb.BackColor;
                tb.BackColor = app.previewTb.BackColor;
                tb.ForeColor = app.previewTb.ForeColor;
                tb.Font = app.previewTb.Font;
            }
        }
    }

    public class PadSettings
    {
        public bool TopMost;
        public Color BackColor;
        public Color ForeColor;

        public PadSettings()
        {
            TopMost = true;
            Random rnd = new Random();
            BackColor = Color.FromArgb(rnd.Next() & 0xff, rnd.Next() & 0xff, rnd.Next() & 0xff);
            ForeColor = Color.FromArgb(255 - BackColor.R, 255 - BackColor.G, 255 - BackColor.B);
        }
    }
}
