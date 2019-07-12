namespace AddTableControls
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label productLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label productLabel1;
            this.buckyDataSet = new AddTableControls.buckyDataSet();
            this.t1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t1TableAdapter = new AddTableControls.buckyDataSetTableAdapters.t1TableAdapter();
            this.tableAdapterManager = new AddTableControls.buckyDataSetTableAdapters.TableAdapterManager();
            this.t2TableAdapter = new AddTableControls.buckyDataSetTableAdapters.t2TableAdapter();
            this.t1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.t2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.productTextBox1 = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            productLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            productLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buckyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingNavigator)).BeginInit();
            this.t1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(57, 87);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new System.Drawing.Point(57, 115);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(60, 17);
            productLabel.TabIndex = 3;
            productLabel.Text = "product:";
            // 
            // buckyDataSet
            // 
            this.buckyDataSet.DataSetName = "buckyDataSet";
            this.buckyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t1BindingSource
            // 
            this.t1BindingSource.DataMember = "t1";
            this.t1BindingSource.DataSource = this.buckyDataSet;
            // 
            // t1TableAdapter
            // 
            this.t1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t1TableAdapter = this.t1TableAdapter;
            this.tableAdapterManager.t2TableAdapter = this.t2TableAdapter;
            this.tableAdapterManager.UpdateOrder = AddTableControls.buckyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t2TableAdapter
            // 
            this.t2TableAdapter.ClearBeforeFill = true;
            // 
            // t1BindingNavigator
            // 
            this.t1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t1BindingNavigator.BindingSource = this.t1BindingSource;
            this.t1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t1BindingNavigatorSaveItem});
            this.t1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t1BindingNavigator.Name = "t1BindingNavigator";
            this.t1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t1BindingNavigator.Size = new System.Drawing.Size(492, 27);
            this.t1BindingNavigator.TabIndex = 0;
            this.t1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // t1BindingNavigatorSaveItem
            // 
            this.t1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t1BindingNavigatorSaveItem.Image")));
            this.t1BindingNavigatorSaveItem.Name = "t1BindingNavigatorSaveItem";
            this.t1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.t1BindingNavigatorSaveItem.Text = "Save Data";
            this.t1BindingNavigatorSaveItem.Click += new System.EventHandler(this.t1BindingNavigatorSaveItem_Click_1);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t1BindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(123, 84);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // productTextBox
            // 
            this.productTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t1BindingSource, "product", true));
            this.productTextBox.Location = new System.Drawing.Point(123, 112);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(100, 22);
            this.productTextBox.TabIndex = 4;
            // 
            // t2BindingSource
            // 
            this.t2BindingSource.DataMember = "t2";
            this.t2BindingSource.DataSource = this.buckyDataSet;
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(63, 182);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(23, 17);
            idLabel1.TabIndex = 5;
            idLabel1.Text = "id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t2BindingSource, "id", true));
            this.idTextBox1.Location = new System.Drawing.Point(129, 179);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 22);
            this.idTextBox1.TabIndex = 6;
            // 
            // productLabel1
            // 
            productLabel1.AutoSize = true;
            productLabel1.Location = new System.Drawing.Point(63, 210);
            productLabel1.Name = "productLabel1";
            productLabel1.Size = new System.Drawing.Size(60, 17);
            productLabel1.TabIndex = 7;
            productLabel1.Text = "product:";
            // 
            // productTextBox1
            // 
            this.productTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t2BindingSource, "product", true));
            this.productTextBox1.Location = new System.Drawing.Point(129, 207);
            this.productTextBox1.Name = "productTextBox1";
            this.productTextBox1.Size = new System.Drawing.Size(100, 22);
            this.productTextBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 406);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(productLabel1);
            this.Controls.Add(this.productTextBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(productLabel);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.t1BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buckyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingNavigator)).EndInit();
            this.t1BindingNavigator.ResumeLayout(false);
            this.t1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buckyDataSet buckyDataSet;
        private System.Windows.Forms.BindingSource t1BindingSource;
        private buckyDataSetTableAdapters.t1TableAdapter t1TableAdapter;
        private buckyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t1BindingNavigatorSaveItem;
        private buckyDataSetTableAdapters.t2TableAdapter t2TableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.BindingSource t2BindingSource;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox productTextBox1;

    }
}

