﻿namespace LibCatalog
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.contextMenuStripForGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditBookMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveBookMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DatePublishedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBooks)).BeginInit();
            this.contextMenuStripForGrid.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.AddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewBooks
            // 
            this.DataGridViewBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBooks.ContextMenuStrip = this.contextMenuStripForGrid;
            this.DataGridViewBooks.Location = new System.Drawing.Point(8, 77);
            this.DataGridViewBooks.Name = "DataGridViewBooks";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            this.DataGridViewBooks.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewBooks.RowTemplate.Height = 24;
            this.DataGridViewBooks.Size = new System.Drawing.Size(752, 374);
            this.DataGridViewBooks.TabIndex = 0;
            this.DataGridViewBooks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBooks_CellEndEdit);
            this.DataGridViewBooks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridViewBooks_MouseDown);
            // 
            // contextMenuStripForGrid
            // 
            this.contextMenuStripForGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditBookMenuItem,
            this.RemoveBookMenuItem});
            this.contextMenuStripForGrid.Name = "contextMenuStripForGrid";
            this.contextMenuStripForGrid.Size = new System.Drawing.Size(309, 52);
            this.contextMenuStripForGrid.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripForGrid_Opening);
            // 
            // EditBookMenuItem
            // 
            this.EditBookMenuItem.Name = "EditBookMenuItem";
            this.EditBookMenuItem.Size = new System.Drawing.Size(308, 24);
            this.EditBookMenuItem.Text = "Редактировать выбранную книгу";
            this.EditBookMenuItem.Click += new System.EventHandler(this.EditBookMenuItem_Click);
            // 
            // RemoveBookMenuItem
            // 
            this.RemoveBookMenuItem.Name = "RemoveBookMenuItem";
            this.RemoveBookMenuItem.Size = new System.Drawing.Size(308, 24);
            this.RemoveBookMenuItem.Text = "Удалить выбранную книгу";
            this.RemoveBookMenuItem.Click += new System.EventHandler(this.RemoveBookMenuItem_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Location = new System.Drawing.Point(8, 12);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(752, 59);
            this.SearchGroupBox.TabIndex = 1;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Поиск:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(86, 17);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(659, 30);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // AddGroupBox
            // 
            this.AddGroupBox.Controls.Add(this.AddButton);
            this.AddGroupBox.Controls.Add(this.DatePublishedDateTimePicker);
            this.AddGroupBox.Controls.Add(this.label3);
            this.AddGroupBox.Controls.Add(this.AuthorTextBox);
            this.AddGroupBox.Controls.Add(this.label2);
            this.AddGroupBox.Controls.Add(this.NameTextBox);
            this.AddGroupBox.Controls.Add(this.label1);
            this.AddGroupBox.Location = new System.Drawing.Point(12, 468);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Size = new System.Drawing.Size(748, 122);
            this.AddGroupBox.TabIndex = 2;
            this.AddGroupBox.TabStop = false;
            this.AddGroupBox.Text = "Добавить новую книгу в каталог";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(616, 35);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 36);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DatePublishedDateTimePicker
            // 
            this.DatePublishedDateTimePicker.CustomFormat = "yyyy";
            this.DatePublishedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePublishedDateTimePicker.Location = new System.Drawing.Point(519, 38);
            this.DatePublishedDateTimePicker.Name = "DatePublishedDateTimePicker";
            this.DatePublishedDateTimePicker.Size = new System.Drawing.Size(69, 30);
            this.DatePublishedDateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год издания:";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(117, 76);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(253, 30);
            this.AuthorTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автор:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(117, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(253, 30);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 610);
            this.Controls.Add(this.AddGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.DataGridViewBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBooks)).EndInit();
            this.contextMenuStripForGrid.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.AddGroupBox.ResumeLayout(false);
            this.AddGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewBooks;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox AddGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker DatePublishedDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForGrid;
        private System.Windows.Forms.ToolStripMenuItem EditBookMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveBookMenuItem;
    }
}

