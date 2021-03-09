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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _txtPass_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_txtUser.Text) && !string.IsNullOrEmpty(_txtPass.Text))
            {

                Regitercs regitercs = new Regitercs();
                regitercs.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("กรอกข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
