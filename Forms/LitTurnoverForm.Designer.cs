
namespace Biblioteka2.Forms
{
    partial class LitTurnoverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LitTurnoverForm));
            this.dgv_LitTurnover = new System.Windows.Forms.DataGridView();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publishing_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_import_LitTurnover = new System.Windows.Forms.Button();
            this.Export_LitTurnover = new System.Windows.Forms.Button();
            this.lb1_SearchLitTurnover = new System.Windows.Forms.Label();
            this.tb_SearchLitTurnover = new System.Windows.Forms.TextBox();
            this.Update_LitTurnover = new System.Windows.Forms.Button();
            this.Delete_LitTurnover = new System.Windows.Forms.Button();
            this.Edit_LitTurnover = new System.Windows.Forms.Button();
            this.Add_LitTurnover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LitTurnover)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LitTurnover
            // 
            this.dgv_LitTurnover.AllowUserToAddRows = false;
            this.dgv_LitTurnover.AllowUserToDeleteRows = false;
            this.dgv_LitTurnover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LitTurnover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LitTurnover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Year,
            this.type,
            this.Class,
            this.NameColumn,
            this.Author,
            this.Publisher,
            this.Publishing_year,
            this.Count});
            this.dgv_LitTurnover.Location = new System.Drawing.Point(12, 93);
            this.dgv_LitTurnover.MultiSelect = false;
            this.dgv_LitTurnover.Name = "dgv_LitTurnover";
            this.dgv_LitTurnover.ReadOnly = true;
            this.dgv_LitTurnover.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LitTurnover.Size = new System.Drawing.Size(764, 321);
            this.dgv_LitTurnover.TabIndex = 30;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год списания";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
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
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 63;
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
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // bt_import_LitTurnover
            // 
            this.bt_import_LitTurnover.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_import_LitTurnover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_import_LitTurnover.BackgroundImage")));
            this.bt_import_LitTurnover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_import_LitTurnover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_import_LitTurnover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_import_LitTurnover.Location = new System.Drawing.Point(294, 26);
            this.bt_import_LitTurnover.Name = "bt_import_LitTurnover";
            this.bt_import_LitTurnover.Size = new System.Drawing.Size(46, 43);
            this.bt_import_LitTurnover.TabIndex = 48;
            this.bt_import_LitTurnover.UseVisualStyleBackColor = false;
            // 
            // Export_LitTurnover
            // 
            this.Export_LitTurnover.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Export_LitTurnover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export_LitTurnover.BackgroundImage")));
            this.Export_LitTurnover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export_LitTurnover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_LitTurnover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export_LitTurnover.Location = new System.Drawing.Point(242, 26);
            this.Export_LitTurnover.Name = "Export_LitTurnover";
            this.Export_LitTurnover.Size = new System.Drawing.Size(46, 43);
            this.Export_LitTurnover.TabIndex = 47;
            this.Export_LitTurnover.UseVisualStyleBackColor = false;
            // 
            // lb1_SearchLitTurnover
            // 
            this.lb1_SearchLitTurnover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1_SearchLitTurnover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_SearchLitTurnover.Location = new System.Drawing.Point(346, 19);
            this.lb1_SearchLitTurnover.Name = "lb1_SearchLitTurnover";
            this.lb1_SearchLitTurnover.Size = new System.Drawing.Size(151, 27);
            this.lb1_SearchLitTurnover.TabIndex = 46;
            this.lb1_SearchLitTurnover.Text = "Поиск данных.";
            this.lb1_SearchLitTurnover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_SearchLitTurnover
            // 
            this.tb_SearchLitTurnover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SearchLitTurnover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_SearchLitTurnover.Location = new System.Drawing.Point(346, 49);
            this.tb_SearchLitTurnover.Name = "tb_SearchLitTurnover";
            this.tb_SearchLitTurnover.Size = new System.Drawing.Size(147, 20);
            this.tb_SearchLitTurnover.TabIndex = 45;
            this.tb_SearchLitTurnover.TextChanged += new System.EventHandler(this.tb_SearchLitTurnover_TextChanged);
            // 
            // Update_LitTurnover
            // 
            this.Update_LitTurnover.BackColor = System.Drawing.Color.Transparent;
            this.Update_LitTurnover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_LitTurnover.BackgroundImage")));
            this.Update_LitTurnover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_LitTurnover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_LitTurnover.Location = new System.Drawing.Point(34, 26);
            this.Update_LitTurnover.Name = "Update_LitTurnover";
            this.Update_LitTurnover.Size = new System.Drawing.Size(46, 43);
            this.Update_LitTurnover.TabIndex = 44;
            this.Update_LitTurnover.UseVisualStyleBackColor = false;
            this.Update_LitTurnover.Click += new System.EventHandler(this.Update_LitTurnover_Click);
            // 
            // Delete_LitTurnover
            // 
            this.Delete_LitTurnover.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete_LitTurnover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_LitTurnover.BackgroundImage")));
            this.Delete_LitTurnover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_LitTurnover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_LitTurnover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_LitTurnover.Location = new System.Drawing.Point(190, 26);
            this.Delete_LitTurnover.Name = "Delete_LitTurnover";
            this.Delete_LitTurnover.Size = new System.Drawing.Size(46, 43);
            this.Delete_LitTurnover.TabIndex = 43;
            this.Delete_LitTurnover.UseVisualStyleBackColor = false;
            this.Delete_LitTurnover.Click += new System.EventHandler(this.Delete_LitTurnover_Click);
            // 
            // Edit_LitTurnover
            // 
            this.Edit_LitTurnover.BackColor = System.Drawing.Color.Transparent;
            this.Edit_LitTurnover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_LitTurnover.BackgroundImage")));
            this.Edit_LitTurnover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Edit_LitTurnover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_LitTurnover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_LitTurnover.Location = new System.Drawing.Point(138, 26);
            this.Edit_LitTurnover.Name = "Edit_LitTurnover";
            this.Edit_LitTurnover.Size = new System.Drawing.Size(46, 43);
            this.Edit_LitTurnover.TabIndex = 42;
            this.Edit_LitTurnover.UseVisualStyleBackColor = false;
            // 
            // Add_LitTurnover
            // 
            this.Add_LitTurnover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_LitTurnover.BackgroundImage")));
            this.Add_LitTurnover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_LitTurnover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_LitTurnover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_LitTurnover.Location = new System.Drawing.Point(86, 26);
            this.Add_LitTurnover.Name = "Add_LitTurnover";
            this.Add_LitTurnover.Size = new System.Drawing.Size(46, 43);
            this.Add_LitTurnover.TabIndex = 41;
            this.Add_LitTurnover.UseVisualStyleBackColor = true;
            // 
            // LitTurnoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 426);
            this.Controls.Add(this.bt_import_LitTurnover);
            this.Controls.Add(this.Export_LitTurnover);
            this.Controls.Add(this.lb1_SearchLitTurnover);
            this.Controls.Add(this.tb_SearchLitTurnover);
            this.Controls.Add(this.Update_LitTurnover);
            this.Controls.Add(this.Delete_LitTurnover);
            this.Controls.Add(this.Edit_LitTurnover);
            this.Controls.Add(this.Add_LitTurnover);
            this.Controls.Add(this.dgv_LitTurnover);
            this.Name = "LitTurnoverForm";
            this.Text = "Списанная литература";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LitTurnover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LitTurnover;
        private System.Windows.Forms.Button Export_LitTurnover;
        private System.Windows.Forms.Label lb1_SearchLitTurnover;
        private System.Windows.Forms.TextBox tb_SearchLitTurnover;
        private System.Windows.Forms.Button Update_LitTurnover;
        private System.Windows.Forms.Button Delete_LitTurnover;
        private System.Windows.Forms.Button Edit_LitTurnover;
        private System.Windows.Forms.Button Add_LitTurnover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publishing_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Button bt_import_LitTurnover;
    }
}