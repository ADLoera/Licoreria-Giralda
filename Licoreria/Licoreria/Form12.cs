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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void surteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.surteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softmonkeyDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softmonkeyDataSet.mercancia' Puede moverla o quitarla según sea necesario.
            this.mercanciaTableAdapter.Fill(this.softmonkeyDataSet.mercancia);
            // TODO: esta línea de código carga datos en la tabla 'softmonkeyDataSet.Surte' Puede moverla o quitarla según sea necesario.
            this.surteTableAdapter.Fill(this.softmonkeyDataSet.Surte);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
