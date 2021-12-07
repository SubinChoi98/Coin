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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            button1.Click += (sender, e) =>
            {
                try
                {
                        Users user = new Users()
                        {
                            Id = textBox1.Text,
                            Password = textBox2.Text,
                            APIKey1 = textBox3.Text,
                            APIKey2 = textBox4.Text
                        };
                        DataManager.Users.Add(user);
                        DataManager.Save();
                        MessageBox.Show("회원가입이 완료되었습니다.");
                        Close();
                }
                catch (Exception exception)
                {

                }
            };
        }
    }
}
