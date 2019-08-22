using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loggin_en_visual_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contrasusena = textBox2.Text;

            if (usuario == "taketake" && contrasusena == "1235")
            {
                MessageBox.Show("usuario logueado");
            }
            else
            {
                MessageBox.Show("incorrecto");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}