using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPad
{
    /// <summary>
    /// Task 3.7 - 3.10 & 3.13
    /// This form uses a rich text box to provide the simple functions
    /// of a simple word pad.
    /// Author: Shan Ahmed 21813031
    /// </summary>
    /// 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();
            txtMain.Font = fd.Font;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Undo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();                      //show Dialog to choose a file name
            txtMain.SaveFile(sfd.FileName);        //save text using this file name
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            txtMain.LoadFile(ofd.FileName);
        }

        private void backgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            txtMain.BackColor = cd.Color;   
        }

        private void foregroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            txtMain.ForeColor = cd.Color;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Font f = new Font(txtMain.Font.Name, hScrollBar1.Value, FontStyle.Regular);
            txtMain.SelectionFont = f;
        }
    }
}
