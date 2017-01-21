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
            lStatus.Location = new Point(this.Size.Width / 2 - lStatus.Size.Width / 2, 1);
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            Base hikks = new Base();
            Base.readAtBase(ref hikks.peoples);

            if (tName.Text.Replace(" ","") == "")
            {
                lStatus.Text = "Имя не может быть пустым!";
                lStatus.ForeColor = Color.Red;
                lStatus.Location = new Point(this.Size.Width / 2 - lStatus.Size.Width / 2, 1);
                return;
            }

            if (tPass.Text != tPassRepeat.Text)
            {
                lStatus.Text = "Пароли не совпадают";
                lStatus.Location = new Point(this.Size.Width / 2 - lStatus.Size.Width / 2, 1);
                lStatus.ForeColor = Color.Red;
                lPass.ForeColor = Color.Red;
                lPassRepeat.ForeColor = Color.Red;
                return;
            }
            else
            {
                lPass.ForeColor = Color.Black;
                lPassRepeat.ForeColor = Color.Black;
            }

            if (hikks.peoples.ContainsKey(CodeEncode.encodeHeader(tName.Text, true)))
            {
                lStatus.Text = "Имя пользователя уже заюзано";
                lStatus.Location = new Point(this.Size.Width / 2 - lStatus.Size.Width / 2, 1);
                lStatus.ForeColor = Color.Red;
                return;         
            }

            else
            {
                lStatus.Text = "Ты успешно добавлен в базу";
                lStatus.ForeColor = Color.Green;
                lStatus.Location = new Point(this.Size.Width / 2 - lStatus.Size.Width / 2, 1);
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/" + hikks.peoples.Count);
                hikks.addAt(CodeEncode.encodeHeader(tName.Text, true), CodeEncode.encodeHeader(tPass.Text, true));
                Base.writeToBase(hikks);
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
