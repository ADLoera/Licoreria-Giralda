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
    public partial class Form2 : Form
    {
        Form1 Padre=null;
        public Form2(Form1 prmPadre)
        {
            InitializeComponent();
            Padre = prmPadre;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.Show(); 
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("\t\t  Pinguirasec Mg®\t\t\n\n\t                 -::Soporte Tecnico::-  \n\n\t\t01-800-38-97-01-16\n\t\t              ó\t\t\n\t\t045-33-15-33-43-75\n\n\t              o visitanos en el domicilio:\t\n\n\t            Av. Acueducto #435 Int. #46 ", "Pinguirasec Mg Soporte y Mantenimiento");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("\t\t    Vinos Giralda ®\t\t\n\n\t                      Contactenos     \n\n\t\t     38-97-01-16\n\t\t              ó   \t\t\n\t\t     31-23-04-23\n\n\t            visitanos en el domicilio:\t\n\n\t            Dr. Silverio Garcia #1043 ", "Contáctenos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 x = new Form4();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 x = new Form5();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Form6 x = new Form6();
            x.Show();
       }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 x = new Form7();
            x.Show();
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 x = new Form8();
            x.Show();
        }

        private void creditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 x = new Form9();
            x.Show();
        }

        private void notaDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 x = new Form10();
            x.Show();
        }

        private void mostrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form11 x = new Form11();
            x.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 x = new Form12();
            x.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("\tUsted Adquiere Marcas 100% Originales y de calidad.\n\nNuestros productos son certificados y contamos con las marcas de mejor prestigio en el mercado. Al comprarnos usted no solo se lleva el producto si no también la tranquilidad de comprar un producto auténtico.", "Politicas");
        }
        
    }
}
