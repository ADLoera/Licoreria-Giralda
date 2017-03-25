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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void vendeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softmonkeyDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softmonkeyDataSet.mercancia' Puede moverla o quitarla según sea necesario.
            this.mercanciaTableAdapter.Fill(this.softmonkeyDataSet.mercancia);
            // TODO: esta línea de código carga datos en la tabla 'softmonkeyDataSet.vende' Puede moverla o quitarla según sea necesario.
            this.vendeTableAdapter.Fill(this.softmonkeyDataSet.vende);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
