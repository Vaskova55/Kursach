
namespace Biblioteka2.Forms
{
    partial class IssuanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuanceForm));
            this.Export_Issuance = new System.Windows.Forms.Button();
            this.lb1_SearchIssuance = new System.Windows.Forms.Label();
            this.tb_SearchIssuance = new System.Windows.Forms.TextBox();
            this.Update_Issuance = new System.Windows.Forms.Button();
            this.Delete_Issuance = new System.Windows.Forms.Button();
            this.Edit_Issuance = new System.Windows.Forms.Button();
            this.Add_Issuance = new System.Windows.Forms.Button();
            this.dgv_Issuance = new System.Windows.Forms.DataGridView();
            this.Сlass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Import_Issuance = new System.Windows.Forms.Button();
            this.ofd_load_Issuance = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Issuance)).BeginInit();
            this.SuspendLayout();
            // 
            // Export_Issuance
            // 
            this.Export_Issuance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Export_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export_Issuance.BackgroundImage")));
            this.Export_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_Issuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export_Issuance.Location = new System.Drawing.Point(230, 24);
            this.Export_Issuance.Name = "Export_Issuance";
            this.Export_Issuance.Size = new System.Drawing.Size(46, 43);
            this.Export_Issuance.TabIndex = 39;
            this.Export_Issuance.UseVisualStyleBackColor = false;
            this.Export_Issuance.Click += new System.EventHandler(this.Export_Issuance_Click);
            // 
            // lb1_SearchIssuance
            // 
            this.lb1_SearchIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_SearchIssuance.Location = new System.Drawing.Point(330, 17);
            this.lb1_SearchIssuance.Name = "lb1_SearchIssuance";
            this.lb1_SearchIssuance.Size = new System.Drawing.Size(151, 27);
            this.lb1_SearchIssuance.TabIndex = 37;
            this.lb1_SearchIssuance.Text = "Поиск данных.";
            this.lb1_SearchIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_SearchIssuance
            // 
            this.tb_SearchIssuance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_SearchIssuance.Location = new System.Drawing.Point(334, 47);
            this.tb_SearchIssuance.Name = "tb_SearchIssuance";
            this.tb_SearchIssuance.Size = new System.Drawing.Size(147, 20);
            this.tb_SearchIssuance.TabIndex = 36;
            // 
            // Update_Issuance
            // 
            this.Update_Issuance.BackColor = System.Drawing.Color.Transparent;
            this.Update_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_Issuance.BackgroundImage")));
            this.Update_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Issuance.Location = new System.Drawing.Point(22, 24);
            this.Update_Issuance.Name = "Update_Issuance";
            this.Update_Issuance.Size = new System.Drawing.Size(46, 43);
            this.Update_Issuance.TabIndex = 35;
            this.Update_Issuance.UseVisualStyleBackColor = false;
            this.Update_Issuance.Click += new System.EventHandler(this.Update_Issuance_Click);
            // 
            // Delete_Issuance
            // 
            this.Delete_Issuance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_Issuance.BackgroundImage")));
            this.Delete_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Issuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Issuance.Location = new System.Drawing.Point(178, 24);
            this.Delete_Issuance.Name = "Delete_Issuance";
            this.Delete_Issuance.Size = new System.Drawing.Size(46, 43);
            this.Delete_Issuance.TabIndex = 34;
            this.Delete_Issuance.UseVisualStyleBackColor = false;
            this.Delete_Issuance.Click += new System.EventHandler(this.Delete_Issuance_Click);
            // 
            // Edit_Issuance
            // 
            this.Edit_Issuance.BackColor = System.Drawing.Color.Transparent;
            this.Edit_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_Issuance.BackgroundImage")));
            this.Edit_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Edit_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Issuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_Issuance.Location = new System.Drawing.Point(126, 24);
            this.Edit_Issuance.Name = "Edit_Issuance";
            this.Edit_Issuance.Size = new System.Drawing.Size(46, 43);
            this.Edit_Issuance.TabIndex = 33;
            this.Edit_Issuance.UseVisualStyleBackColor = false;
            // 
            // Add_Issuance
            // 
            this.Add_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Issuance.BackgroundImage")));
            this.Add_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Issuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Issuance.Location = new System.Drawing.Point(74, 24);
            this.Add_Issuance.Name = "Add_Issuance";
            this.Add_Issuance.Size = new System.Drawing.Size(46, 43);
            this.Add_Issuance.TabIndex = 32;
            this.Add_Issuance.UseVisualStyleBackColor = true;
            this.Add_Issuance.Click += new System.EventHandler(this.Add_Issuance_Click);
            // 
            // dgv_Issuance
            // 
            this.dgv_Issuance.AllowUserToAddRows = false;
            this.dgv_Issuance.AllowUserToDeleteRows = false;
            this.dgv_Issuance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Issuance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Сlass,
            this.family_name,
            this.first_name,
            this.name_book,
            this.date_of_issue});
            this.dgv_Issuance.Location = new System.Drawing.Point(12, 91);
            this.dgv_Issuance.MultiSelect = false;
            this.dgv_Issuance.Name = "dgv_Issuance";
            this.dgv_Issuance.ReadOnly = true;
            this.dgv_Issuance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Issuance.Size = new System.Drawing.Size(492, 262);
            this.dgv_Issuance.TabIndex = 31;
            // 
            // Сlass
            // 
            this.Сlass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Сlass.HeaderText = "Класс";
            this.Сlass.Name = "Сlass";
            this.Сlass.ReadOnly = true;
            // 
            // family_name
            // 
            this.family_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.family_name.HeaderText = "Фамилия";
            this.family_name.Name = "family_name";
            this.family_name.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.first_name.HeaderText = "Имя";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // name_book
            // 
            this.name_book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_book.HeaderText = "Название книги";
            this.name_book.Name = "name_book";
            this.name_book.ReadOnly = true;
            // 
            // date_of_issue
            // 
            this.date_of_issue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_of_issue.HeaderText = "Дата выдачи";
            this.date_of_issue.Name = "date_of_issue";
            this.date_of_issue.ReadOnly = true;
            // 
            // bt_Import_Issuance
            // 
            this.bt_Import_Issuance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_Import_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Import_Issuance.BackgroundImage")));
            this.bt_Import_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Import_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Import_Issuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Import_Issuance.Location = new System.Drawing.Point(282, 24);
            this.bt_Import_Issuance.Name = "bt_Import_Issuance";
            this.bt_Import_Issuance.Size = new System.Drawing.Size(46, 43);
            this.bt_Import_Issuance.TabIndex = 40;
            this.bt_Import_Issuance.UseVisualStyleBackColor = false;
            this.bt_Import_Issuance.Click += new System.EventHandler(this.bt_Import_Issuance_Click);
            // 
            // ofd_load_Issuance
            // 
            this.ofd_load_Issuance.FileName = "openFileDialog1";
            // 
            // IssuanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 364);
            this.Controls.Add(this.bt_Import_Issuance);
            this.Controls.Add(this.Export_Issuance);
            this.Controls.Add(this.lb1_SearchIssuance);
            this.Controls.Add(this.tb_SearchIssuance);
            this.Controls.Add(this.Update_Issuance);
            this.Controls.Add(this.Delete_Issuance);
            this.Controls.Add(this.Edit_Issuance);
            this.Controls.Add(this.Add_Issuance);
            this.Controls.Add(this.dgv_Issuance);
            this.Name = "IssuanceForm";
            this.Text = "Выдача литературы";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Issuance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Export_Issuance;
        private System.Windows.Forms.Label lb1_SearchIssuance;
        private System.Windows.Forms.TextBox tb_SearchIssuance;
        private System.Windows.Forms.Button Update_Issuance;
        private System.Windows.Forms.Button Delete_Issuance;
        private System.Windows.Forms.Button Edit_Issuance;
        private System.Windows.Forms.Button Add_Issuance;
        private System.Windows.Forms.DataGridView dgv_Issuance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сlass;
        private System.Windows.Forms.DataGridViewTextBoxColumn family_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_issue;
        private System.Windows.Forms.Button bt_Import_Issuance;
        private System.Windows.Forms.OpenFileDialog ofd_load_Issuance;
    }
}