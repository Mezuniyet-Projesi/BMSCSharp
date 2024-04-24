using Project.HR;
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
    public partial class SelectDepartment : Form
    {
        public SelectDepartment()
        {
            InitializeComponent();
        }

        private void managementButton_Click(object sender, EventArgs e)
        {
            SelectDepartment management = new SelectDepartment();
            management.Show();
            this.Hide();
        }

        private void hrButton_Click(object sender, EventArgs e)
        {
            HrLogin hr = new HrLogin();
            hr.Show();
            this.Hide();
        }

        private void managementButton_MouseEnter(object sender, EventArgs e)
        {
            managementButton.BackColor = Color.Green;
        }

        private void managementButton_MouseLeave(object sender, EventArgs e)
        {
            managementButton.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void financeButton_MouseEnter(object sender, EventArgs e)
        {
            financeButton.BackColor = Color.Green;
        }

        private void financeButton_MouseLeave(object sender, EventArgs e)
        {
            financeButton.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void hrButton_MouseEnter(object sender, EventArgs e)
        {
            hrButton.BackColor = Color.Green;
        }

        private void hrButton_MouseLeave(object sender, EventArgs e)
        {
            hrButton.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
