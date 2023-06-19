namespace _1233123213123
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label наименование_должностиLabel;
            System.Windows.Forms.Label окладLabel;
            System.Windows.Forms.Label обязонастиLabel;
            System.Windows.Forms.Label требованияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this._Microsoft_Access_База_данных__2_DataSet = new _1233123213123._Microsoft_Access_База_данных__2_DataSet();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиTableAdapter = new _1233123213123._Microsoft_Access_База_данных__2_DataSetTableAdapters.должностиTableAdapter();
            this.tableAdapterManager = new _1233123213123._Microsoft_Access_База_данных__2_DataSetTableAdapters.TableAdapterManager();
            this.должностиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.должностиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.наименование_должностиTextBox = new System.Windows.Forms.TextBox();
            this.окладTextBox = new System.Windows.Forms.TextBox();
            this.обязонастиTextBox = new System.Windows.Forms.TextBox();
            this.требованияTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            наименование_должностиLabel = new System.Windows.Forms.Label();
            окладLabel = new System.Windows.Forms.Label();
            обязонастиLabel = new System.Windows.Forms.Label();
            требованияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Microsoft_Access_База_данных__2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingNavigator)).BeginInit();
            this.должностиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(299, 113);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "id:";
            // 
            // наименование_должностиLabel
            // 
            наименование_должностиLabel.AutoSize = true;
            наименование_должностиLabel.Location = new System.Drawing.Point(175, 139);
            наименование_должностиLabel.Name = "наименование_должностиLabel";
            наименование_должностиLabel.Size = new System.Drawing.Size(142, 13);
            наименование_должностиLabel.TabIndex = 6;
            наименование_должностиLabel.Text = "наименование должности:";
            // 
            // окладLabel
            // 
            окладLabel.AutoSize = true;
            окладLabel.Location = new System.Drawing.Point(277, 165);
            окладLabel.Name = "окладLabel";
            окладLabel.Size = new System.Drawing.Size(40, 13);
            окладLabel.TabIndex = 7;
            окладLabel.Text = "оклад:";
            // 
            // обязонастиLabel
            // 
            обязонастиLabel.AutoSize = true;
            обязонастиLabel.Location = new System.Drawing.Point(248, 191);
            обязонастиLabel.Name = "обязонастиLabel";
            обязонастиLabel.Size = new System.Drawing.Size(69, 13);
            обязонастиLabel.TabIndex = 8;
            обязонастиLabel.Text = "обязонасти:";
            // 
            // требованияLabel
            // 
            требованияLabel.AutoSize = true;
            требованияLabel.Location = new System.Drawing.Point(248, 217);
            требованияLabel.Name = "требованияLabel";
            требованияLabel.Size = new System.Drawing.Size(69, 13);
            требованияLabel.TabIndex = 10;
            требованияLabel.Text = "требования:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(296, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Должность";
            // 
            // _Microsoft_Access_База_данных__2_DataSet
            // 
            this._Microsoft_Access_База_данных__2_DataSet.DataSetName = "_Microsoft_Access_База_данных__2_DataSet";
            this._Microsoft_Access_База_данных__2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "должности";
            this.должностиBindingSource.DataSource = this._Microsoft_Access_База_данных__2_DataSet;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = _1233123213123._Microsoft_Access_База_данных__2_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.валютаTableAdapter = null;
            this.tableAdapterManager.вкладчикиTableAdapter = null;
            this.tableAdapterManager.вкладыTableAdapter = null;
            this.tableAdapterManager.должностиTableAdapter = this.должностиTableAdapter;
            this.tableAdapterManager.сотрудникиTableAdapter = null;
            // 
            // должностиBindingNavigator
            // 
            this.должностиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.должностиBindingNavigator.BindingSource = this.должностиBindingSource;
            this.должностиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.должностиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.должностиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.должностиBindingNavigatorSaveItem});
            this.должностиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.должностиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.должностиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.должностиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.должностиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.должностиBindingNavigator.Name = "должностиBindingNavigator";
            this.должностиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.должностиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.должностиBindingNavigator.TabIndex = 5;
            this.должностиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // должностиBindingNavigatorSaveItem
            // 
            this.должностиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.должностиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("должностиBindingNavigatorSaveItem.Image")));
            this.должностиBindingNavigatorSaveItem.Name = "должностиBindingNavigatorSaveItem";
            this.должностиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.должностиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.должностиBindingNavigatorSaveItem.Click += new System.EventHandler(this.должностиBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(323, 110);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // наименование_должностиTextBox
            // 
            this.наименование_должностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "наименование должности", true));
            this.наименование_должностиTextBox.Location = new System.Drawing.Point(323, 136);
            this.наименование_должностиTextBox.Name = "наименование_должностиTextBox";
            this.наименование_должностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименование_должностиTextBox.TabIndex = 7;
            // 
            // окладTextBox
            // 
            this.окладTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "оклад", true));
            this.окладTextBox.Location = new System.Drawing.Point(323, 162);
            this.окладTextBox.Name = "окладTextBox";
            this.окладTextBox.Size = new System.Drawing.Size(100, 20);
            this.окладTextBox.TabIndex = 8;
            // 
            // обязонастиTextBox
            // 
            this.обязонастиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "обязонасти", true));
            this.обязонастиTextBox.Location = new System.Drawing.Point(323, 188);
            this.обязонастиTextBox.Name = "обязонастиTextBox";
            this.обязонастиTextBox.Size = new System.Drawing.Size(100, 20);
            this.обязонастиTextBox.TabIndex = 9;
            // 
            // требованияTextBox
            // 
            this.требованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "требования", true));
            this.требованияTextBox.Location = new System.Drawing.Point(323, 214);
            this.требованияTextBox.Name = "требованияTextBox";
            this.требованияTextBox.Size = new System.Drawing.Size(100, 20);
            this.требованияTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Следующая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(463, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 38);
            this.button4.TabIndex = 15;
            this.button4.Text = "Предыдущая";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(463, 333);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 38);
            this.button5.TabIndex = 16;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(185, 333);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 38);
            this.button6.TabIndex = 17;
            this.button6.Text = "Последняя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(323, 377);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 38);
            this.button7.TabIndex = 18;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(584, 88);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 38);
            this.button8.TabIndex = 19;
            this.button8.Text = "Открыть таблицу";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(требованияLabel);
            this.Controls.Add(this.требованияTextBox);
            this.Controls.Add(обязонастиLabel);
            this.Controls.Add(this.обязонастиTextBox);
            this.Controls.Add(окладLabel);
            this.Controls.Add(this.окладTextBox);
            this.Controls.Add(наименование_должностиLabel);
            this.Controls.Add(this.наименование_должностиTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.должностиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Microsoft_Access_База_данных__2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingNavigator)).EndInit();
            this.должностиBindingNavigator.ResumeLayout(false);
            this.должностиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Microsoft_Access_База_данных__2_DataSet _Microsoft_Access_База_данных__2_DataSet;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private _Microsoft_Access_База_данных__2_DataSetTableAdapters.должностиTableAdapter должностиTableAdapter;
        private _Microsoft_Access_База_данных__2_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator должностиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton должностиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox наименование_должностиTextBox;
        private System.Windows.Forms.TextBox окладTextBox;
        private System.Windows.Forms.TextBox обязонастиTextBox;
        private System.Windows.Forms.TextBox требованияTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}