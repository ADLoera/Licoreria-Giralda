using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Licoreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Cesar")
            {
                if (textBox2.Text == "Prueba")
                {
                    Form2 x = new Form2(this);
                    x.Show();
                    this.Hide();
                    MessageBox.Show("Bienvenido Cesar", "Bienvenido",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Contraseña Equivocada", "Error de Contraseña",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
            else if (textBox1.Text == "Administrador")
            {
                if (textBox2.Text == "Prueba")
                {
                    Form2 x = new Form2(this);
                    x.Show();
                    this.Hide();
                    MessageBox.Show("Bienvenido Administrador", "Bienvenido",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Contraseña Equivocada", "Error de Contraseña",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
             else if (textBox1.Text == "Usuario")
                {
                    if (textBox2.Text == "Prueba")
                    {
                        Form2 x = new Form2(this);
                        x.Show();
                        this.Hide();
                        MessageBox.Show("Bienvenido Usuario", "Bienvenido",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                else
                {
                    MessageBox.Show("Contraseña Equivocada", "Error de Contraseña",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Usurio y/o Contraseña Erronea", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
