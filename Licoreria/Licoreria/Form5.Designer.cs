namespace Licoreria
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.softmonkeyDataSet = new Licoreria.SoftmonkeyDataSet();
            this.vendeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendeTableAdapter = new Licoreria.SoftmonkeyDataSetTableAdapters.vendeTableAdapter();
            this.tableAdapterManager = new Licoreria.SoftmonkeyDataSetTableAdapters.TableAdapterManager();
            this.mercanciaTableAdapter = new Licoreria.SoftmonkeyDataSetTableAdapters.mercanciaTableAdapter();
            this.vendeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vendeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vendeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mercanciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mercanciaListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.softmonkeyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendeBindingNavigator)).BeginInit();
            this.vendeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // softmonkeyDataSet
            // 
            this.softmonkeyDataSet.DataSetName = "SoftmonkeyDataSet";
            this.softmonkeyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendeBindingSource
            // 
            this.vendeBindingSource.DataMember = "vende";
            this.vendeBindingSource.DataSource = this.softmonkeyDataSet;
            // 
            // vendeTableAdapter
            // 
            this.vendeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SurteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Licoreria.SoftmonkeyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendeTableAdapter = this.vendeTableAdapter;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // mercanciaTableAdapter
            // 
            this.mercanciaTableAdapter.ClearBeforeFill = true;
            // 
            // vendeBindingNavigator
            // 
            this.vendeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendeBindingNavigator.BindingSource = this.vendeBindingSource;
            this.vendeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vendeBindingNavigatorSaveItem});
            this.vendeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendeBindingNavigator.Name = "vendeBindingNavigator";
            this.vendeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendeBindingNavigator.Size = new System.Drawing.Size(839, 25);
            this.vendeBindingNavigator.TabIndex = 0;
            this.vendeBindingNavigator.Text = "bindingNavigator1";
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
            // vendeBindingNavigatorSaveItem
            // 
            this.vendeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendeBindingNavigatorSaveItem.Image")));
            this.vendeBindingNavigatorSaveItem.Name = "vendeBindingNavigatorSaveItem";
            this.vendeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendeBindingNavigatorSaveItem.Text = "Guardar datos";
            this.vendeBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendeBindingNavigatorSaveItem_Click);
            // 
            // vendeDataGridView
            // 
            this.vendeDataGridView.AutoGenerateColumns = false;
            this.vendeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.vendeDataGridView.DataSource = this.vendeBindingSource;
            this.vendeDataGridView.Location = new System.Drawing.Point(12, 40);
            this.vendeDataGridView.Name = "vendeDataGridView";
            this.vendeDataGridView.Size = new System.Drawing.Size(369, 116);
            this.vendeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "no_art";
            this.dataGridViewTextBoxColumn1.HeaderText = "no_art";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codigo_mer";
            this.dataGridViewTextBoxColumn2.HeaderText = "codigo_mer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "no_venta";
            this.dataGridViewTextBoxColumn3.HeaderText = "no_venta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            this.mercanciaListBox.Location = new System.Drawing.Point(464, 40);
            this.mercanciaListBox.Name = "mercanciaListBox";
            this.mercanciaListBox.Size = new System.Drawing.Size(300, 212);
            this.mercanciaListBox.TabIndex = 2;
            this.mercanciaListBox.ValueMember = "codigo_mer";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(501, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mercanciaListBox);
            this.Controls.Add(this.vendeDataGridView);
            this.Controls.Add(this.vendeBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Vinos\"Giralda\"®";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softmonkeyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendeBindingNavigator)).EndInit();
            this.vendeBindingNavigator.ResumeLayout(false);
            this.vendeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoftmonkeyDataSet softmonkeyDataSet;
        private System.Windows.Forms.BindingSource vendeBindingSource;
        private SoftmonkeyDataSetTableAdapters.vendeTableAdapter vendeTableAdapter;
        private SoftmonkeyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vendeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vendeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private SoftmonkeyDataSetTableAdapters.mercanciaTableAdapter mercanciaTableAdapter;
        private System.Windows.Forms.BindingSource mercanciaBindingSource;
        private System.Windows.Forms.ListBox mercanciaListBox;
        private System.Windows.Forms.Button button1;
    }
}