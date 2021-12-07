using Coin.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            tableLayoutPanel1.Paint += ShadowPanel.Draw;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Id를 입력해주세요");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Password를 입력해주세요");
            }
            else
            {
                try
                {
                    Users user = DataManager.Users.Single((x) => x.Id == textBox1.Text);
                    if (user.Id == textBox1.Text && user.Password == textBox2.Text)
                    {
                        string key1 = user.APIKey1;
                        string key2 = user.APIKey2;
                        
                        //UpbitAPISample upbit = new UpbitAPISample(key1, key2);

                        this.Visible = false;
                        new OrderBookForm(key1, key2).ShowDialog();
                        Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new SignUpForm().ShowDialog();
        }
    }
}
