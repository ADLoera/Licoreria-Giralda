namespace Licoreria
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.softmonkeyDataSet = new Licoreria.SoftmonkeyDataSet();
            this.nota_vtaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nota_vtaTableAdapter = new Licoreria.SoftmonkeyDataSetTableAdapters.nota_vtaTableAdapter();
            this.tableAdapterManager = new Licoreria.SoftmonkeyDataSetTableAdapters.TableAdapterManager();
            this.ventaTableAdapter = new Licoreria.SoftmonkeyDataSetTableAdapters.VentaTableAdapter();
            this.nota_vtaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nota_vtaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nota_vtaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.softmonkeyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_vtaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_vtaBindingNavigator)).BeginInit();
            this.nota_vtaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nota_vtaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // softmonkeyDataSet
            // 
            this.softmonkeyDataSet.DataSetName = "SoftmonkeyDataSet";
            this.softmonkeyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nota_vtaBindingSource
            // 
            this.nota_vtaBindingSource.DataMember = "nota_vta";
            this.nota_vtaBindingSource.DataSource = this.softmonkeyDataSet;
            // 
            // nota_vtaTableAdapter
            // 
            this.nota_vtaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.creditoTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.mercanciaTableAdapter = null;
            this.tableAdapterManager.nota_vtaTableAdapter = this.nota_vtaTableAdapter;
            this.tableAdapterManager.PagoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.pideTableAdapter = null;
            this.tableAdapterManager.proveedorTableAdapter = null;
            this.tableAdapterManager.reciveTableAdapter = null;
            this.tableAdapterManager.SurteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Licoreria.SoftmonkeyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendeTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = this.ventaTableAdapter;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // nota_vtaBindingNavigator
            // 
            this.nota_vtaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nota_vtaBindingNavigator.BindingSource = this.nota_vtaBindingSource;
            this.nota_vtaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nota_vtaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nota_vtaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nota_vtaBindingNavigatorSaveItem});
            this.nota_vtaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nota_vtaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nota_vtaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nota_vtaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nota_vtaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nota_vtaBindingNavigator.Name = "nota_vtaBindingNavigator";
            this.nota_vtaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nota_vtaBindingNavigator.Size = new System.Drawing.Size(661, 25);
            this.nota_vtaBindingNavigator.TabIndex = 0;
            this.nota_vtaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nota_vtaBindingNavigatorSaveItem
            // 
            this.nota_vtaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nota_vtaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nota_vtaBindingNavigatorSaveItem.Image")));
            this.nota_vtaBindingNavigatorSaveItem.Name = "nota_vtaBindingNavigatorSaveItem";
            this.nota_vtaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nota_vtaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.nota_vtaBindingNavigatorSaveItem.Click += new System.EventHandler(this.nota_vtaBindingNavigatorSaveItem_Click);
            // 
            // nota_vtaDataGridView
            // 
            this.nota_vtaDataGridView.AutoGenerateColumns = false;
            this.nota_vtaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nota_vtaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.nota_vtaDataGridView.DataSource = this.nota_vtaBindingSource;
            this.nota_vtaDataGridView.Location = new System.Drawing.Point(125, 58);
            this.nota_vtaDataGridView.Name = "nota_vtaDataGridView";
            this.nota_vtaDataGridView.Size = new System.Drawing.Size(362, 95);
            this.nota_vtaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "no_venta";
            this.dataGridViewTextBoxColumn1.HeaderText = "no_venta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "for_pago";
            this.dataGridViewTextBoxColumn2.HeaderText = "for_pago";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(198, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.softmonkeyDataSet;
            // 
            // ventaListBox
            // 
            this.ventaListBox.DataSource = this.ventaBindingSource;
            this.ventaListBox.DisplayMember = "id_venta";
            this.ventaListBox.FormattingEnabled = true;
            this.ventaListBox.Location = new System.Drawing.Point(125, 159);
            this.ventaListBox.Name = "ventaListBox";
            this.ventaListBox.Size = new System.Drawing.Size(362, 108);
            this.ventaListBox.TabIndex = 7;
            this.ventaListBox.ValueMember = "id_venta";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 362);
            this.Controls.Add(this.ventaListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nota_vtaDataGridView);
            this.Controls.Add(this.nota_vtaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "Vinos\"Giralda\"®";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softmonkeyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_vtaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_vtaBindingNavigator)).EndInit();
            this.nota_vtaBindingNavigator.ResumeLayout(false);
            this.nota_vtaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nota_vtaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoftmonkeyDataSet softmonkeyDataSet;
        private System.Windows.Forms.BindingSource nota_vtaBindingSource;
        private SoftmonkeyDataSetTableAdapters.nota_vtaTableAdapter nota_vtaTableAdapter;
        private SoftmonkeyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nota_vtaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nota_vtaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nota_vtaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private SoftmonkeyDataSetTableAdapters.VentaTableAdapter ventaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private System.Windows.Forms.ListBox ventaListBox;
    }
}