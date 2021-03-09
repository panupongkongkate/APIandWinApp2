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
    public partial class Regitercs : Form
    {
        public Regitercs()
        {
            InitializeComponent();
        }

        #region Use
        private void Regitercs_Load(object sender, EventArgs e)
        {
            _userPeople1.Hide();
            _userConReg1.Hide();
        }


        private void _btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            Hide();
        }


        private void _btnReg_Click(object sender, EventArgs e)
        {
            _userPeople1.Hide();
            _userConReg1.Show();
        }

        private void _btnPeople_Click(object sender, EventArgs e)
        {
            _userPeople1.refresh();
            _userPeople1.Show();
            _userConReg1.Hide();
        }
        #endregion



        #region NoUse
        private void _userRegister_Load(object sender, EventArgs e)
        {

        }

        private void _userConReg1_Load(object sender, EventArgs e)
        {

        }

        #endregion
     
    }
}
