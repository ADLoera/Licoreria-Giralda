namespace Licoreria
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.softmonkeyDataSet = new Licoreria.SoftmonkeyDataSet();
            this.surteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surteTableAdapter = new Licoreria.SoftmonkeyDataSetTableAdapters.SurteTableAdapter();
            this.tableAdapterManager = new Licoreria.SoftmonkeyDataSetTableAdapters.TableAdapterManager();
            this.mercanciaTableAdapter = new Licoreria.SoftmonkeyDataSetTableAdapters.mercanciaTableAdapter();
            this.surteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.surteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.surteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.mercanciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercanciaListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.softmonkeyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surteBindingNavigator)).BeginInit();
            this.surteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.surteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // softmonkeyDataSet
            // 
            this.softmonkeyDataSet.DataSetName = "SoftmonkeyDataSet";
            this.softmonkeyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // surteBindingSource
            // 
            this.surteBindingSource.DataMember = "Surte";
            this.surteBindingSource.DataSource = this.softmonkeyDataSet;
            // 
            // surteTableAdapter
            // 
            this.surteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.creditoTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.mercanciaTableAdapter = this.mercanciaTableAdapter;
            this.tableAdapterManager.nota_vtaTableAdapter = null;
            this.tableAdapterManager.PagoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.pideTableAdapter = null;
            this.tableAdapterManager.proveedorTableAdapter = null;
            this.tableAdapterManager.reciveTableAdapter = null;
            this.tableAdapterManager.SurteTableAdapter = this.surteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Licoreria.SoftmonkeyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendeTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // mercanciaTableAdapter
            // 
            this.mercanciaTableAdapter.ClearBeforeFill = true;
            // 
            // surteBindingNavigator
            // 
            this.surteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.surteBindingNavigator.BindingSource = this.surteBindingSource;
            this.surteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.surteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.surteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.surteBindingNavigatorSaveItem});
            this.surteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.surteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.surteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.surteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.surteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.surteBindingNavigator.Name = "surteBindingNavigator";
            this.surteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.surteBindingNavigator.Size = new System.Drawing.Size(722, 25);
            this.surteBindingNavigator.TabIndex = 0;
            this.surteBindingNavigator.Text = "bindingNavigator1";
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
            // surteBindingNavigatorSaveItem
            // 
            this.surteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.surteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("surteBindingNavigatorSaveItem.Image")));
            this.surteBindingNavigatorSaveItem.Name = "surteBindingNavigatorSaveItem";
            this.surteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.surteBindingNavigatorSaveItem.Text = "Guardar datos";
            this.surteBindingNavigatorSaveItem.Click += new System.EventHandler(this.surteBindingNavigatorSaveItem_Click);
            // 
            // surteDataGridView
            // 
            this.surteDataGridView.AutoGenerateColumns = false;
            this.surteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.surteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.surteDataGridView.DataSource = this.surteBindingSource;
            this.surteDataGridView.Location = new System.Drawing.Point(12, 44);
            this.surteDataGridView.Name = "surteDataGridView";
            this.surteDataGridView.Size = new System.Drawing.Size(665, 116);
            this.surteDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fecha_pedido";
            this.dataGridViewTextBoxColumn1.HeaderText = "fecha_pedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "precio_uni";
            this.dataGridViewTextBoxColumn2.HeaderText = "precio_uni";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codigo_mer";
            this.dataGridViewTextBoxColumn4.HeaderText = "codigo_mer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "no_pedido";
            this.dataGridViewTextBoxColumn5.HeaderText = "no_pedido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "codigo_prove";
            this.dataGridViewTextBoxColumn6.HeaderText = "codigo_prove";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(467, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mercanciaBindingSource
            // 
            this.mercanciaBindingSource.DataMember = "mercancia";
            this.mercanciaBindingSource.DataSource = this.softmonkeyDataSet;
            // 
            // mercanciaListBox
            // 
            this.mercanciaListBox.DataSource = this.mercanciaBindingSource;
            this.mercanciaListBox.DisplayMember = "nombre";
            this.mercanciaListBox.FormattingEnabled = true;
            this.mercanciaListBox.Location = new System.Drawing.Point(354, 166);
            this.mercanciaListBox.Name = "mercanciaListBox";
            this.mercanciaListBox.Size = new System.Drawing.Size(323, 147);
            this.mercanciaListBox.TabIndex = 9;
            this.mercanciaListBox.ValueMember = "codigo_mer";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 388);
            this.Controls.Add(this.mercanciaListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.surteDataGridView);
            this.Controls.Add(this.surteBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.Text = "Vinos\"Giralda\"®";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softmonkeyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surteBindingNavigator)).EndInit();
            this.surteBindingNavigator.ResumeLayout(false);
            this.surteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.surteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoftmonkeyDataSet softmonkeyDataSet;
        private System.Windows.Forms.BindingSource surteBindingSource;
        private SoftmonkeyDataSetTableAdapters.SurteTableAdapter surteTableAdapter;
        private SoftmonkeyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator surteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton surteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView surteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private SoftmonkeyDataSetTableAdapters.mercanciaTableAdapter mercanciaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource mercanciaBindingSource;
        private System.Windows.Forms.ListBox mercanciaListBox;
    }
}