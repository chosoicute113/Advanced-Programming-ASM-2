using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public Form currentformn;
        public void openChildForm(Form childform)
        {
            if (currentformn != null) { currentformn.Close(); }
            currentformn = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_childform.Controls.Add(childform);
            panel_childform.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            openChildForm( new Form2());
            
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel_childform.Controls.Remove(currentformn);
        }

        private void btn_DriveThru_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
