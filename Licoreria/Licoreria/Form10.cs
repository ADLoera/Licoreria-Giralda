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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void nota_vtaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nota_vtaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softmonkeyDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softmonkeyDataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.softmonkeyDataSet.Venta);
            // TODO: esta línea de código carga datos en la tabla 'softmonkeyDataSet.nota_vta' Puede moverla o quitarla según sea necesario.
            this.nota_vtaTableAdapter.Fill(this.softmonkeyDataSet.nota_vta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
