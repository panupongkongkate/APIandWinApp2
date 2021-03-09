using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Model;

namespace Project
{
    public partial class _userConReg : UserControl
    {
        ClientReq clientReq = new ClientReq();
        string path = "https://localhost:44394/api/People";
        public _userConReg()
        {
            InitializeComponent();
        }


        private void _btnClear_Click(object sender, EventArgs e)
        {
            if (_btnClear.Text == "Back")
            {
                _txtId.Enabled = true;
                _txtName.Enabled = true;
                _txtLastName.Enabled = true;
                _btnClear.Text = "Clear";
                _btnSummit.Text = "Submit";
            }

            _txtId.Text = null;
            _txtName.Text = null;
            _txtLastName.Text = null;

        }

        private void _btnSummit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_txtId.Text)|| string.IsNullOrEmpty(_txtName.Text)|| string.IsNullOrEmpty(_txtLastName.Text))
                {
                    MessageBox.Show("ลงทะเบียนไม่สำเร้จกรุณาตรวจสอบข้อมูลใหม่","แจ้งเตือน",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                }
                else
                {
                    if(_btnSummit.Text == "Confirm")
                    {
                        User user = new User
                        {
                            id = Convert.ToInt32(_txtId.Text),
                            name = _txtName.Text ,
                            lastName = _txtLastName.Text 
                        };

                    var msg =  clientReq.CreateProductAsync(path, user).GetAwaiter().GetResult();

                        if(!string.IsNullOrEmpty(msg.PathAndQuery))
                        {

                            MessageBox.Show("ลงทะเบียนสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _txtId.Text = null;
                            _txtName.Text = null;
                            _txtLastName.Text = null;
                            _txtId.Enabled = true;
                            _txtName.Enabled = true;
                            _txtLastName.Enabled = true;
                            _btnClear.Text = "Clear";
                            _btnSummit.Text = "Submit";

                        }

                    }
                    else
                    {
                        _btnClear.Text = "Back";
                        _btnSummit.Text = "Confirm";
                        _txtId.Enabled = false;
                        _txtName.Enabled = false;
                        _txtLastName.Enabled = false;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("ไม่สามารถลงทะเบียนได้ id นี้มีซ้ำแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _txtId.Text = null;
                _txtName.Text = null;
                _txtLastName.Text = null;
                _txtId.Enabled = true;
                _txtName.Enabled = true;
                _txtLastName.Enabled = true;
                _btnClear.Text = "Clear";
                _btnSummit.Text = "Submit";
            }

        }

        private void _userConReg_Load(object sender, EventArgs e)
        {

        }

        private void _txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
