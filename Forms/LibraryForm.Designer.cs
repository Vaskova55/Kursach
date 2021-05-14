
namespace Biblioteka2.Forms
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.Export_Library = new System.Windows.Forms.Button();
            this.Search_SearchLibrary = new System.Windows.Forms.Label();
            this.lb1_SearchLibrary = new System.Windows.Forms.Label();
            this.tb_SearchLibrary = new System.Windows.Forms.TextBox();
            this.Update_Library = new System.Windows.Forms.Button();
            this.Delete_Library = new System.Windows.Forms.Button();
            this.Edit_Library = new System.Windows.Forms.Button();
            this.Add_Library = new System.Windows.Forms.Button();
            this.dgv_Library = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publishing_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Library)).BeginInit();
            this.SuspendLayout();
            // 
            // Export_Library
            // 
            this.Export_Library.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Export_Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export_Library.BackgroundImage")));
            this.Export_Library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export_Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export_Library.Location = new System.Drawing.Point(263, 25);
            this.Export_Library.Name = "Export_Library";
            this.Export_Library.Size = new System.Drawing.Size(46, 43);
            this.Export_Library.TabIndex = 37;
            this.Export_Library.UseVisualStyleBackColor = false;
            this.Export_Library.Click += new System.EventHandler(this.Export_Library_Click);
            // 
            // Search_SearchLibrary
            // 
            this.Search_SearchLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_SearchLibrary.Location = new System.Drawing.Point(374, 62);
            this.Search_SearchLibrary.Name = "Search_SearchLibrary";
            this.Search_SearchLibrary.Size = new System.Drawing.Size(147, 27);
            this.Search_SearchLibrary.TabIndex = 36;
            this.Search_SearchLibrary.Text = "Больше параметров для поиска";
            this.Search_SearchLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1_SearchLibrary
            // 
            this.lb1_SearchLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_SearchLibrary.Location = new System.Drawing.Point(370, 8);
            this.lb1_SearchLibrary.Name = "lb1_SearchLibrary";
            this.lb1_SearchLibrary.Size = new System.Drawing.Size(151, 28);
            this.lb1_SearchLibrary.TabIndex = 35;
            this.lb1_SearchLibrary.Text = "Поиск данных.";
            this.lb1_SearchLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_SearchLibrary
            // 
            this.tb_SearchLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_SearchLibrary.Location = new System.Drawing.Point(374, 39);
            this.tb_SearchLibrary.Name = "tb_SearchLibrary";
            this.tb_SearchLibrary.Size = new System.Drawing.Size(147, 20);
            this.tb_SearchLibrary.TabIndex = 34;
            // 
            // Update_Library
            // 
            this.Update_Library.BackColor = System.Drawing.Color.Transparent;
            this.Update_Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_Library.BackgroundImage")));
            this.Update_Library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Library.Location = new System.Drawing.Point(55, 25);
            this.Update_Library.Name = "Update_Library";
            this.Update_Library.Size = new System.Drawing.Size(46, 43);
            this.Update_Library.TabIndex = 33;
            this.Update_Library.UseVisualStyleBackColor = false;
            this.Update_Library.Click += new System.EventHandler(this.Update_Library_Click);
            // 
            // Delete_Library
            // 
            this.Delete_Library.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete_Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_Library.BackgroundImage")));
            this.Delete_Library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Library.Location = new System.Drawing.Point(211, 25);
            this.Delete_Library.Name = "Delete_Library";
            this.Delete_Library.Size = new System.Drawing.Size(46, 43);
            this.Delete_Library.TabIndex = 32;
            this.Delete_Library.UseVisualStyleBackColor = false;
            this.Delete_Library.Click += new System.EventHandler(this.Delete_Library_Click);
            // 
            // Edit_Library
            // 
            this.Edit_Library.BackColor = System.Drawing.Color.Transparent;
            this.Edit_Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_Library.BackgroundImage")));
            this.Edit_Library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Edit_Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_Library.Location = new System.Drawing.Point(159, 25);
            this.Edit_Library.Name = "Edit_Library";
            this.Edit_Library.Size = new System.Drawing.Size(46, 43);
            this.Edit_Library.TabIndex = 31;
            this.Edit_Library.UseVisualStyleBackColor = false;
            this.Edit_Library.Click += new System.EventHandler(this.Edit_Library_Click);
            // 
            // Add_Library
            // 
            this.Add_Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Library.BackgroundImage")));
            this.Add_Library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Library.Location = new System.Drawing.Point(107, 25);
            this.Add_Library.Name = "Add_Library";
            this.Add_Library.Size = new System.Drawing.Size(46, 43);
            this.Add_Library.TabIndex = 30;
            this.Add_Library.UseVisualStyleBackColor = true;
            this.Add_Library.Click += new System.EventHandler(this.Add_Library_Click);
            // 
            // dgv_Library
            // 
            this.dgv_Library.AllowUserToAddRows = false;
            this.dgv_Library.AllowUserToDeleteRows = false;
            this.dgv_Library.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Library.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.Class,
            this.NameColumn,
            this.Author,
            this.Publisher,
            this.Publishing_year});
            this.dgv_Library.Location = new System.Drawing.Point(12, 94);
            this.dgv_Library.MultiSelect = false;
            this.dgv_Library.Name = "dgv_Library";
            this.dgv_Library.ReadOnly = true;
            this.dgv_Library.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Library.Size = new System.Drawing.Size(575, 262);
            this.dgv_Library.TabIndex = 29;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Publisher.HeaderText = "Издательство";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // Publishing_year
            // 
            this.Publishing_year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Publishing_year.HeaderText = "Год публикации";
            this.Publishing_year.Name = "Publishing_year";
            this.Publishing_year.ReadOnly = true;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 367);
            this.Controls.Add(this.Export_Library);
            this.Controls.Add(this.Search_SearchLibrary);
            this.Controls.Add(this.lb1_SearchLibrary);
            this.Controls.Add(this.tb_SearchLibrary);
            this.Controls.Add(this.Update_Library);
            this.Controls.Add(this.Delete_Library);
            this.Controls.Add(this.Edit_Library);
            this.Controls.Add(this.Add_Library);
            this.Controls.Add(this.dgv_Library);
            this.Name = "LibraryForm";
            this.Text = "Библиотека";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Library)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Export_Library;
        private System.Windows.Forms.Label Search_SearchLibrary;
        private System.Windows.Forms.Label lb1_SearchLibrary;
        private System.Windows.Forms.TextBox tb_SearchLibrary;
        private System.Windows.Forms.Button Update_Library;
        private System.Windows.Forms.Button Delete_Library;
        private System.Windows.Forms.Button Edit_Library;
        private System.Windows.Forms.Button Add_Library;
        private System.Windows.Forms.DataGridView dgv_Library;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publishing_year;
    }
}