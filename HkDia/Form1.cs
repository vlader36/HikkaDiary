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

        }
    }
}
