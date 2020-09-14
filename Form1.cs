using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabToolsControl1.addressBar.Text = "test";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitWebBrowserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("BROWZIT WEB BROWSER Version 1.1" + '\n' +
            "Creator: Blythe Leatherman (BRL0027)" + '\n' +
            "Last Updated: 9/6/2020");
        }
    }
}
