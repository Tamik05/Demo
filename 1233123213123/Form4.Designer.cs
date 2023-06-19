namespace _1233123213123
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label наименование_вкладаLabel;
            System.Windows.Forms.Label минимальный_срок_вкладаLabel;
            System.Windows.Forms.Label минимальная_сумма_вкладаLabel;
            System.Windows.Forms.Label процентная_ставкаLabel;
            System.Windows.Forms.Label максимальная_сумма_вкладаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this._Microsoft_Access_База_данных__2_DataSet = new _1233123213123._Microsoft_Access_База_данных__2_DataSet();
            this.вкладыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вкладыTableAdapter = new _1233123213123._Microsoft_Access_База_данных__2_DataSetTableAdapters.вкладыTableAdapter();
            this.tableAdapterManager = new _1233123213123._Microsoft_Access_База_данных__2_DataSetTableAdapters.TableAdapterManager();
            this.вкладыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.вкладыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.наименование_вкладаTextBox = new System.Windows.Forms.TextBox();
            this.минимальный_срок_вкладаTextBox = new System.Windows.Forms.TextBox();
            this.минимальная_сумма_вкладаTextBox = new System.Windows.Forms.TextBox();
            this.процентная_ставкаTextBox = new System.Windows.Forms.TextBox();
            this.максимальная_сумма_вкладаTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            наименование_вкладаLabel = new System.Windows.Forms.Label();
            минимальный_срок_вкладаLabel = new System.Windows.Forms.Label();
            минимальная_сумма_вкладаLabel = new System.Windows.Forms.Label();
            процентная_ставкаLabel = new System.Windows.Forms.Label();
            максимальная_сумма_вкладаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Microsoft_Access_База_данных__2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладыBindingNavigator)).BeginInit();
            this.вкладыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(329, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вклады";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _Microsoft_Access_База_данных__2_DataSet
            // 
            this._Microsoft_Access_База_данных__2_DataSet.DataSetName = "_Microsoft_Access_База_данных__2_DataSet";
            this._Microsoft_Access_База_данных__2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вкладыBindingSource
            // 
            this.вкладыBindingSource.DataMember = "вклады";
            this.вкладыBindingSource.DataSource = this._Microsoft_Access_База_данных__2_DataSet;
            // 
            // вкладыTableAdapter
            // 
            this.вкладыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = _1233123213123._Microsoft_Access_База_данных__2_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.валютаTableAdapter = null;
            this.tableAdapterManager.вкладчикиTableAdapter = null;
            this.tableAdapterManager.вкладыTableAdapter = this.вкладыTableAdapter;
            this.tableAdapterManager.должностиTableAdapter = null;
            this.tableAdapterManager.сотрудникиTableAdapter = null;
            // 
            // вкладыBindingNavigator
            // 
            this.вкладыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.вкладыBindingNavigator.BindingSource = this.вкладыBindingSource;
            this.вкладыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.вкладыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.вкладыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.вкладыBindingNavigatorSaveItem});
            this.вкладыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.вкладыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.вкладыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.вкладыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.вкладыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.вкладыBindingNavigator.Name = "вкладыBindingNavigator";
            this.вкладыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.вкладыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.вкладыBindingNavigator.TabIndex = 5;
            this.вкладыBindingNavigator.Text = "bindingNavigator1";
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
            // вкладыBindingNavigatorSaveItem
            // 
            this.вкладыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вкладыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("вкладыBindingNavigatorSaveItem.Image")));
            this.вкладыBindingNavigatorSaveItem.Name = "вкладыBindingNavigatorSaveItem";
            this.вкладыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.вкладыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.вкладыBindingNavigatorSaveItem.Click += new System.EventHandler(this.вкладыBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(302, 133);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(326, 130);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // наименование_вкладаLabel
            // 
            наименование_вкладаLabel.AutoSize = true;
            наименование_вкладаLabel.Location = new System.Drawing.Point(197, 159);
            наименование_вкладаLabel.Name = "наименование_вкладаLabel";
            наименование_вкладаLabel.Size = new System.Drawing.Size(123, 13);
            наименование_вкладаLabel.TabIndex = 6;
            наименование_вкладаLabel.Text = "наименование вклада:";
            // 
            // наименование_вкладаTextBox
            // 
            this.наименование_вкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "наименование вклада", true));
            this.наименование_вкладаTextBox.Location = new System.Drawing.Point(326, 156);
            this.наименование_вкладаTextBox.Name = "наименование_вкладаTextBox";
            this.наименование_вкладаTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименование_вкладаTextBox.TabIndex = 7;
            // 
            // минимальный_срок_вкладаLabel
            // 
            минимальный_срок_вкладаLabel.AutoSize = true;
            минимальный_срок_вкладаLabel.Location = new System.Drawing.Point(172, 185);
            минимальный_срок_вкладаLabel.Name = "минимальный_срок_вкладаLabel";
            минимальный_срок_вкладаLabel.Size = new System.Drawing.Size(148, 13);
            минимальный_срок_вкладаLabel.TabIndex = 7;
            минимальный_срок_вкладаLabel.Text = "минимальный срок вклада:";
            // 
            // минимальный_срок_вкладаTextBox
            // 
            this.минимальный_срок_вкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "минимальный срок вклада", true));
            this.минимальный_срок_вкладаTextBox.Location = new System.Drawing.Point(326, 182);
            this.минимальный_срок_вкладаTextBox.Name = "минимальный_срок_вкладаTextBox";
            this.минимальный_срок_вкладаTextBox.Size = new System.Drawing.Size(100, 20);
            this.минимальный_срок_вкладаTextBox.TabIndex = 8;
            // 
            // минимальная_сумма_вкладаLabel
            // 
            минимальная_сумма_вкладаLabel.AutoSize = true;
            минимальная_сумма_вкладаLabel.Location = new System.Drawing.Point(165, 211);
            минимальная_сумма_вкладаLabel.Name = "минимальная_сумма_вкладаLabel";
            минимальная_сумма_вкладаLabel.Size = new System.Drawing.Size(155, 13);
            минимальная_сумма_вкладаLabel.TabIndex = 8;
            минимальная_сумма_вкладаLabel.Text = "минимальная сумма вклада:";
            // 
            // минимальная_сумма_вкладаTextBox
            // 
            this.минимальная_сумма_вкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "минимальная сумма вклада", true));
            this.минимальная_сумма_вкладаTextBox.Location = new System.Drawing.Point(326, 208);
            this.минимальная_сумма_вкладаTextBox.Name = "минимальная_сумма_вкладаTextBox";
            this.минимальная_сумма_вкладаTextBox.Size = new System.Drawing.Size(100, 20);
            this.минимальная_сумма_вкладаTextBox.TabIndex = 9;
            // 
            // процентная_ставкаLabel
            // 
            процентная_ставкаLabel.AutoSize = true;
            процентная_ставкаLabel.Location = new System.Drawing.Point(213, 237);
            процентная_ставкаLabel.Name = "процентная_ставкаLabel";
            процентная_ставкаLabel.Size = new System.Drawing.Size(107, 13);
            процентная_ставкаLabel.TabIndex = 10;
            процентная_ставкаLabel.Text = "процентная ставка:";
            // 
            // процентная_ставкаTextBox
            // 
            this.процентная_ставкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "процентная ставка", true));
            this.процентная_ставкаTextBox.Location = new System.Drawing.Point(326, 234);
            this.процентная_ставкаTextBox.Name = "процентная_ставкаTextBox";
            this.процентная_ставкаTextBox.Size = new System.Drawing.Size(100, 20);
            this.процентная_ставкаTextBox.TabIndex = 11;
            // 
            // максимальная_сумма_вкладаLabel
            // 
            максимальная_сумма_вкладаLabel.AutoSize = true;
            максимальная_сумма_вкладаLabel.Location = new System.Drawing.Point(159, 263);
            максимальная_сумма_вкладаLabel.Name = "максимальная_сумма_вкладаLabel";
            максимальная_сумма_вкладаLabel.Size = new System.Drawing.Size(161, 13);
            максимальная_сумма_вкладаLabel.TabIndex = 12;
            максимальная_сумма_вкладаLabel.Text = "максимальная сумма вклада:";
            // 
            // максимальная_сумма_вкладаTextBox
            // 
            this.максимальная_сумма_вкладаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладыBindingSource, "максимальная сумма вклада", true));
            this.максимальная_сумма_вкладаTextBox.Location = new System.Drawing.Point(326, 260);
            this.максимальная_сумма_вкладаTextBox.Name = "максимальная_сумма_вкладаTextBox";
            this.максимальная_сумма_вкладаTextBox.Size = new System.Drawing.Size(100, 20);
            this.максимальная_сумма_вкладаTextBox.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(максимальная_сумма_вкладаLabel);
            this.Controls.Add(this.максимальная_сумма_вкладаTextBox);
            this.Controls.Add(процентная_ставкаLabel);
            this.Controls.Add(this.процентная_ставкаTextBox);
            this.Controls.Add(минимальная_сумма_вкладаLabel);
            this.Controls.Add(this.минимальная_сумма_вкладаTextBox);
            this.Controls.Add(минимальный_срок_вкладаLabel);
            this.Controls.Add(this.минимальный_срок_вкладаTextBox);
            this.Controls.Add(наименование_вкладаLabel);
            this.Controls.Add(this.наименование_вкладаTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.вкладыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Microsoft_Access_База_данных__2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладыBindingNavigator)).EndInit();
            this.вкладыBindingNavigator.ResumeLayout(false);
            this.вкладыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _Microsoft_Access_База_данных__2_DataSet _Microsoft_Access_База_данных__2_DataSet;
        private System.Windows.Forms.BindingSource вкладыBindingSource;
        private _Microsoft_Access_База_данных__2_DataSetTableAdapters.вкладыTableAdapter вкладыTableAdapter;
        private _Microsoft_Access_База_данных__2_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator вкладыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton вкладыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox наименование_вкладаTextBox;
        private System.Windows.Forms.TextBox минимальный_срок_вкладаTextBox;
        private System.Windows.Forms.TextBox минимальная_сумма_вкладаTextBox;
        private System.Windows.Forms.TextBox процентная_ставкаTextBox;
        private System.Windows.Forms.TextBox максимальная_сумма_вкладаTextBox;
    }
}