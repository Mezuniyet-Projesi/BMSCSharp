using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(3);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                SelectDepartment departments = new SelectDepartment();
                departments.Show();
                this.Hide();
            }
        }

    }
}
