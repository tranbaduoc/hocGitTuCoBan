using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnhViet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "duocdung" && txtPassWord.Text == "1234")
            {
                MessageBox.Show("hello world!", "bá được nói", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Form2 fr = new Form2();
                fr.ShowDialog();
                    this.Close();
            }
            else
            {
                MessageBox.Show("bạn nhập sai Name ỏ Password","error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tính năng đang được phát triển vui lòng chờ!", "hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
