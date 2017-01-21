using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HkDia
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            tPassRepeat.PasswordChar = '*';
            tPass.PasswordChar = '*';
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            Base hikks = new Base();
            hikks.readAtBase(hikks);

            if (tName.Text.Replace(" ","") == "")
            {
                MessageBox.Show("Имя не может быть пустым!");
                return;
            }

            if (tPass.Text != tPassRepeat.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                lPass.ForeColor = Color.Red;
                lPassRepeat.ForeColor = Color.Red;
                return;
            }

            if (hikks.peoples.ContainsValue(tName.Text))
            {
                MessageBox.Show("Имя уже заюзано");
                return;
            }

            else
            {
                hikks.addAt(CodeEncode.encodeHeader(tName.Text, true), CodeEncode.encodeHeader(tPass.Text, true));
                hikks.writeToBase(hikks);
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
