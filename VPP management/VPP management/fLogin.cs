using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPP_management
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            //if (AccountDAO.Instance.Login(username, password))
            //{
            //    //Global.getAccount(username); // Luu thong tin account lai;
            //    //fManage fManage = new fManage();
            //    //this.Hide();
            //    //fManage.ShowDialog();
            //    //this.Show();

            //}
            //else
            //    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");

        }
    }
}
