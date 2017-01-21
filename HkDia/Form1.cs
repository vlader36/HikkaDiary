using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HkDia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tPass.PasswordChar = '*';
        }

        private void bReg_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            Base hikks = new Base();
            Base.readAtBase(ref hikks.peoples);
            int key = -1;

            if (!hikks.peoples.ContainsKey(CodeEncode.encodeHeader(tName.Text, true)))
            {
                lStatus.Text = "Такого человека нету в моей базе";
                lStatus.ForeColor = Color.Red;
                lStatus.Location = new Point(this.Size.Width / 2 - lStatus.Size.Width / 2, 1);
                return;
            }

            if (hikks.peoples.ContainsKey(CodeEncode.encodeHeader(tName.Text, true)))
            {
                for (int i = 0; i < hikks.peoples.Count; i++)
                {
                    if(hikks.peoples.ElementAt(i).Key == CodeEncode.encodeHeader(tName.Text, true))
                    {
                        key = i;
                        break;
                    }
                }
            }
            if (key == -1)
                return;

            if (hikks.peoples.ElementAt(key).Value != (CodeEncode.encodeHeader(tPass.Text, true)))
            {
                lStatus.Text = "Неверный пароль";
                lStatus.ForeColor = Color.Red;
                lStatus.Location = new Point(this.Size.Width / 2 - lStatus.Size.Width / 2, 1);
                return;
            }

            else
            {
                lStatus.Text = "Успешный вход";
                lStatus.ForeColor = Color.Green;
                lStatus.Location = new Point(this.Size.Width / 2 - lStatus.Size.Width / 2, 1);
            }
        }
    }
}
