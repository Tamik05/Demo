namespace _1233123213123
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label обмен_курсLabel;
            this.label1 = new System.Windows.Forms.Label();
            this._Microsoft_Access_База_данных__2_DataSet = new _1233123213123._Microsoft_Access_База_данных__2_DataSet();
            this.валютаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.валютаTableAdapter = new _1233123213123._Microsoft_Access_База_данных__2_DataSetTableAdapters.валютаTableAdapter();
            this.tableAdapterManager = new _1233123213123._Microsoft_Access_База_данных__2_DataSetTableAdapters.TableAdapterManager();
            this.валютаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.валютаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.обмен_курсTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            обмен_курсLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Microsoft_Access_База_данных__2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютаBindingNavigator)).BeginInit();
            this.валютаBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(310, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Валюта";
            // 
            // _Microsoft_Access_База_данных__2_DataSet
            // 
            this._Microsoft_Access_База_данных__2_DataSet.DataSetName = "_Microsoft_Access_База_данных__2_DataSet";
            this._Microsoft_Access_База_данных__2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // валютаBindingSource
            // 
            this.валютаBindingSource.DataMember = "валюта";
            this.валютаBindingSource.DataSource = this._Microsoft_Access_База_данных__2_DataSet;
            // 
            // валютаTableAdapter
            // 
            this.валютаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = _1233123213123._Microsoft_Access_База_данных__2_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.валютаTableAdapter = this.валютаTableAdapter;
            this.tableAdapterManager.вкладчикиTableAdapter = null;
            this.tableAdapterManager.вкладыTableAdapter = null;
            this.tableAdapterManager.должностиTableAdapter = null;
            this.tableAdapterManager.сотрудникиTableAdapter = null;
            // 
            // валютаBindingNavigator
            // 
            this.валютаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.валютаBindingNavigator.BindingSource = this.валютаBindingSource;
            this.валютаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.валютаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.валютаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.валютаBindingNavigatorSaveItem});
            this.валютаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.валютаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.валютаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.валютаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.валютаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.валютаBindingNavigator.Name = "валютаBindingNavigator";
            this.валютаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.валютаBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.валютаBindingNavigator.TabIndex = 3;
            this.валютаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // валютаBindingNavigatorSaveItem
            // 
            this.валютаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.валютаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("валютаBindingNavigatorSaveItem.Image")));
            this.валютаBindingNavigatorSaveItem.Name = "валютаBindingNavigatorSaveItem";
            this.валютаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.валютаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.валютаBindingNavigatorSaveItem.Click += new System.EventHandler(this.валютаBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(301, 144);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютаBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(325, 141);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(235, 170);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(84, 13);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютаBindingSource, "наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(325, 167);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // обмен_курсLabel
            // 
            обмен_курсLabel.AutoSize = true;
            обмен_курсLabel.Location = new System.Drawing.Point(251, 196);
            обмен_курсLabel.Name = "обмен_курсLabel";
            обмен_курсLabel.Size = new System.Drawing.Size(68, 13);
            обмен_курсLabel.TabIndex = 6;
            обмен_курсLabel.Text = "обмен курс:";
            // 
            // обмен_курсTextBox
            // 
            this.обмен_курсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.валютаBindingSource, "обмен курс", true));
            this.обмен_курсTextBox.Location = new System.Drawing.Point(325, 193);
            this.обмен_курсTextBox.Name = "обмен_курсTextBox";
            this.обмен_курсTextBox.Size = new System.Drawing.Size(100, 20);
            this.обмен_курсTextBox.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(обмен_курсLabel);
            this.Controls.Add(this.обмен_курсTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.валютаBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Microsoft_Access_База_данных__2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.валютаBindingNavigator)).EndInit();
            this.валютаBindingNavigator.ResumeLayout(false);
            this.валютаBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Microsoft_Access_База_данных__2_DataSet _Microsoft_Access_База_данных__2_DataSet;
        private System.Windows.Forms.BindingSource валютаBindingSource;
        private _Microsoft_Access_База_данных__2_DataSetTableAdapters.валютаTableAdapter валютаTableAdapter;
        private _Microsoft_Access_База_данных__2_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator валютаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton валютаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox обмен_курсTextBox;
    }
}