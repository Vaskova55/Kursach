﻿
namespace Biblioteka2.Forms
{
    partial class TrainessesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainessesForm));
            this.Export_Trainess = new System.Windows.Forms.Button();
            this.lb1_Trainess = new System.Windows.Forms.Label();
            this.tb_SearchTrainess = new System.Windows.Forms.TextBox();
            this.Update_Trainess = new System.Windows.Forms.Button();
            this.Delete_Trainess = new System.Windows.Forms.Button();
            this.Edit_Trainess = new System.Windows.Forms.Button();
            this.Add_Trainess = new System.Windows.Forms.Button();
            this.dgv_Trainess = new System.Windows.Forms.DataGridView();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Import_Trainess = new System.Windows.Forms.Button();
            this.ofd_load_Trainess = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trainess)).BeginInit();
            this.SuspendLayout();
            // 
            // Export_Trainess
            // 
            this.Export_Trainess.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Export_Trainess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export_Trainess.BackgroundImage")));
            this.Export_Trainess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export_Trainess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_Trainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export_Trainess.Location = new System.Drawing.Point(230, 24);
            this.Export_Trainess.Name = "Export_Trainess";
            this.Export_Trainess.Size = new System.Drawing.Size(46, 43);
            this.Export_Trainess.TabIndex = 38;
            this.Export_Trainess.UseVisualStyleBackColor = false;
            this.Export_Trainess.Click += new System.EventHandler(this.Export_Trainess_Click_1);
            // 
            // lb1_Trainess
            // 
            this.lb1_Trainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_Trainess.Location = new System.Drawing.Point(334, 16);
            this.lb1_Trainess.Name = "lb1_Trainess";
            this.lb1_Trainess.Size = new System.Drawing.Size(151, 27);
            this.lb1_Trainess.TabIndex = 36;
            this.lb1_Trainess.Text = "Поиск данных.";
            this.lb1_Trainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_SearchTrainess
            // 
            this.tb_SearchTrainess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_SearchTrainess.Location = new System.Drawing.Point(334, 46);
            this.tb_SearchTrainess.Name = "tb_SearchTrainess";
            this.tb_SearchTrainess.Size = new System.Drawing.Size(147, 20);
            this.tb_SearchTrainess.TabIndex = 35;
            this.tb_SearchTrainess.TextChanged += new System.EventHandler(this.tb_SearchTrainess_TextChanged);
            // 
            // Update_Trainess
            // 
            this.Update_Trainess.BackColor = System.Drawing.Color.Transparent;
            this.Update_Trainess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_Trainess.BackgroundImage")));
            this.Update_Trainess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_Trainess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Trainess.Location = new System.Drawing.Point(22, 23);
            this.Update_Trainess.Name = "Update_Trainess";
            this.Update_Trainess.Size = new System.Drawing.Size(46, 43);
            this.Update_Trainess.TabIndex = 34;
            this.Update_Trainess.UseVisualStyleBackColor = false;
            this.Update_Trainess.Click += new System.EventHandler(this.Update_Trainess_Click);
            // 
            // Delete_Trainess
            // 
            this.Delete_Trainess.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete_Trainess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_Trainess.BackgroundImage")));
            this.Delete_Trainess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_Trainess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Trainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Trainess.Location = new System.Drawing.Point(178, 23);
            this.Delete_Trainess.Name = "Delete_Trainess";
            this.Delete_Trainess.Size = new System.Drawing.Size(46, 44);
            this.Delete_Trainess.TabIndex = 33;
            this.Delete_Trainess.UseVisualStyleBackColor = false;
            this.Delete_Trainess.Click += new System.EventHandler(this.Delete_Trainess_Click);
            // 
            // Edit_Trainess
            // 
            this.Edit_Trainess.BackColor = System.Drawing.Color.Transparent;
            this.Edit_Trainess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_Trainess.BackgroundImage")));
            this.Edit_Trainess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Edit_Trainess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Trainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_Trainess.Location = new System.Drawing.Point(126, 23);
            this.Edit_Trainess.Name = "Edit_Trainess";
            this.Edit_Trainess.Size = new System.Drawing.Size(46, 43);
            this.Edit_Trainess.TabIndex = 32;
            this.Edit_Trainess.UseVisualStyleBackColor = false;
            this.Edit_Trainess.Click += new System.EventHandler(this.Edit_Trainess_Click);
            // 
            // Add_Trainess
            // 
            this.Add_Trainess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Trainess.BackgroundImage")));
            this.Add_Trainess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Trainess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Trainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Trainess.Location = new System.Drawing.Point(74, 23);
            this.Add_Trainess.Name = "Add_Trainess";
            this.Add_Trainess.Size = new System.Drawing.Size(46, 43);
            this.Add_Trainess.TabIndex = 31;
            this.Add_Trainess.UseVisualStyleBackColor = true;
            this.Add_Trainess.Click += new System.EventHandler(this.Add_Trainess_Click);
            // 
            // dgv_Trainess
            // 
            this.dgv_Trainess.AllowUserToAddRows = false;
            this.dgv_Trainess.AllowUserToDeleteRows = false;
            this.dgv_Trainess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Trainess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class,
            this.Family_name,
            this.First_name,
            this.Middle_name});
            this.dgv_Trainess.Location = new System.Drawing.Point(12, 91);
            this.dgv_Trainess.MultiSelect = false;
            this.dgv_Trainess.Name = "dgv_Trainess";
            this.dgv_Trainess.ReadOnly = true;
            this.dgv_Trainess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Trainess.Size = new System.Drawing.Size(473, 262);
            this.dgv_Trainess.TabIndex = 30;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // Family_name
            // 
            this.Family_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Family_name.HeaderText = "Фамилия";
            this.Family_name.Name = "Family_name";
            this.Family_name.ReadOnly = true;
            // 
            // First_name
            // 
            this.First_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.First_name.HeaderText = "Имя";
            this.First_name.Name = "First_name";
            this.First_name.ReadOnly = true;
            // 
            // Middle_name
            // 
            this.Middle_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Middle_name.HeaderText = "Отчество";
            this.Middle_name.Name = "Middle_name";
            this.Middle_name.ReadOnly = true;
            // 
            // bt_Import_Trainess
            // 
            this.bt_Import_Trainess.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_Import_Trainess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Import_Trainess.BackgroundImage")));
            this.bt_Import_Trainess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Import_Trainess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Import_Trainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Import_Trainess.Location = new System.Drawing.Point(282, 24);
            this.bt_Import_Trainess.Name = "bt_Import_Trainess";
            this.bt_Import_Trainess.Size = new System.Drawing.Size(46, 43);
            this.bt_Import_Trainess.TabIndex = 39;
            this.bt_Import_Trainess.UseVisualStyleBackColor = false;
            this.bt_Import_Trainess.Click += new System.EventHandler(this.bt_import_Click);
            // 
            // ofd_load_Trainess
            // 
            this.ofd_load_Trainess.Filter = "Excel table|*.xlsx";
            // 
            // TrainessesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 363);
            this.Controls.Add(this.bt_Import_Trainess);
            this.Controls.Add(this.Export_Trainess);
            this.Controls.Add(this.lb1_Trainess);
            this.Controls.Add(this.tb_SearchTrainess);
            this.Controls.Add(this.Update_Trainess);
            this.Controls.Add(this.Delete_Trainess);
            this.Controls.Add(this.Edit_Trainess);
            this.Controls.Add(this.Add_Trainess);
            this.Controls.Add(this.dgv_Trainess);
            this.Name = "TrainessesForm";
            this.Text = "Обучающиеся";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trainess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Export_Trainess;
        private System.Windows.Forms.Label lb1_Trainess;
        private System.Windows.Forms.TextBox tb_SearchTrainess;
        private System.Windows.Forms.Button Update_Trainess;
        private System.Windows.Forms.Button Delete_Trainess;
        private System.Windows.Forms.Button Edit_Trainess;
        private System.Windows.Forms.Button Add_Trainess;
        private System.Windows.Forms.DataGridView dgv_Trainess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middle_name;
        private System.Windows.Forms.Button bt_Import_Trainess;
        private System.Windows.Forms.OpenFileDialog ofd_load_Trainess;
    }
}