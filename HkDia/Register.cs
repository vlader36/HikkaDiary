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
            bool finded = false;

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

            FileStream fsreadwrite = new FileStream("us.hkus", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader strread = new StreamReader(fsreadwrite);

            while (!strread.EndOfStream)
            {
                if (tName.Text == CodeEncode.encodeHeader(strread.ReadLine(), false))
                {
                    finded = true;
                    break;
                }
            }

            strread.Close();
            fsreadwrite.Close();

            if (finded)
            {
                MessageBox.Show("Имя занято, ну");
                return;
            }

            else
            {
                strread.Close();
                fsreadwrite = new FileStream("us.hkus", FileMode.Append, FileAccess.Write);
                StreamWriter strw = new StreamWriter(fsreadwrite);
                strw.Write(CodeEncode.encodeHeader(tName.Text, true) + '\n');
                strw.Close();
                fsreadwrite.Close();
                fsreadwrite = new FileStream("pa.hkus", FileMode.Append, FileAccess.Write);
                strw = new StreamWriter(fsreadwrite);
                strw.Write(CodeEncode.encodeHeader(tPass.Text, true), +'\n');
                strw.Close();
                fsreadwrite.Close();
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/" + CodeEncode.encodeHeader(tName.Text, true));
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
