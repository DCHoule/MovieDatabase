using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class MovieApp : Form
    {
        public MovieApp()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            //exit application on cmdExit button click
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //confirm user wants to exit. if yes close form
            if (MessageBox.Show("Are you sure you want to exit?", "Exit?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //if yes exit app
                Application.Exit();
            }
        }
    }
}
