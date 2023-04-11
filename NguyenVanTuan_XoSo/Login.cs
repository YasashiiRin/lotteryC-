using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenVanTuan_XoSo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbuser.Text == "admin" && tbpass.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công với tài khoản Admin ");
                new FrmTuan().Show();
                this.Hide();
            }
            if (tbuser.Text=="tuan" && tbpass.Text =="123")
            {
                MessageBox.Show("Đăng nhập thành công với tài khoản người dùng ");          
                new Form1().Show();
                this.Hide();
            }          
            else if (tbuser.Text != "admin" && tbpass.Text != "admin" && tbuser.Text != "tuan" && tbpass.Text != "123")
            {
                MessageBox.Show("ko chính xác vui lòng thử lại");
                tbuser.Text = "";
                tbpass.Text = "";
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tbuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
