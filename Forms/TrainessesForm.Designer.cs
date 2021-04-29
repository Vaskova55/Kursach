
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
            this.dgv_Trainess = new System.Windows.Forms.DataGridView();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trainess)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Trainess
            // 
            this.dgv_Trainess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Trainess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class,
            this.Family_name,
            this.First_name,
            this.Middle_name});
            this.dgv_Trainess.Location = new System.Drawing.Point(163, 94);
            this.dgv_Trainess.MultiSelect = false;
            this.dgv_Trainess.Name = "dgv_Trainess";
            this.dgv_Trainess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Trainess.Size = new System.Drawing.Size(475, 262);
            this.dgv_Trainess.TabIndex = 1;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            // 
            // Family_name
            // 
            this.Family_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Family_name.HeaderText = "Фамилия";
            this.Family_name.Name = "Family_name";
            // 
            // First_name
            // 
            this.First_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.First_name.HeaderText = "Имя";
            this.First_name.Name = "First_name";
            // 
            // Middle_name
            // 
            this.Middle_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Middle_name.HeaderText = "Отчество";
            this.Middle_name.Name = "Middle_name";
            // 
            // Trainess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Trainess);
            this.Name = "Trainess";
            this.Text = "Trainess";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trainess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Trainess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middle_name;
    }
}