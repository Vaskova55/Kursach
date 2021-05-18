
namespace Biblioteka2.Forms
{
    partial class SearchTrainessForm
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
            this.dgv_SearchTrainess = new System.Windows.Forms.DataGridView();
            this.cb_SearchTrainess = new System.Windows.Forms.CheckBox();
            this.lb2_SearchTrainess = new System.Windows.Forms.Label();
            this.tb_FamillySearchTrainess = new System.Windows.Forms.TextBox();
            this.tb_NameSearchTrainess = new System.Windows.Forms.TextBox();
            this.lb5_SearchTrainess = new System.Windows.Forms.Label();
            this.lb4_SearchTrainess = new System.Windows.Forms.Label();
            this.lb1_SearchTrainess = new System.Windows.Forms.Label();
            this.lb3_SearchTrainess = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fimilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avtors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchTrainess)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SearchTrainess
            // 
            this.dgv_SearchTrainess.AllowUserToAddRows = false;
            this.dgv_SearchTrainess.AllowUserToDeleteRows = false;
            this.dgv_SearchTrainess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SearchTrainess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchTrainess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class,
            this.Fimilia,
            this.Name,
            this.Book,
            this.Avtors,
            this.Date_Issue,
            this.Date_Return});
            this.dgv_SearchTrainess.Location = new System.Drawing.Point(223, 15);
            this.dgv_SearchTrainess.Name = "dgv_SearchTrainess";
            this.dgv_SearchTrainess.ReadOnly = true;
            this.dgv_SearchTrainess.Size = new System.Drawing.Size(663, 269);
            this.dgv_SearchTrainess.TabIndex = 0;
            // 
            // cb_SearchTrainess
            // 
            this.cb_SearchTrainess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_SearchTrainess.Location = new System.Drawing.Point(16, 150);
            this.cb_SearchTrainess.Name = "cb_SearchTrainess";
            this.cb_SearchTrainess.Size = new System.Drawing.Size(201, 38);
            this.cb_SearchTrainess.TabIndex = 1;
            this.cb_SearchTrainess.Text = "Проверить наличие долга по возврату литературы";
            this.cb_SearchTrainess.UseVisualStyleBackColor = true;
            // 
            // lb2_SearchTrainess
            // 
            this.lb2_SearchTrainess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb2_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_SearchTrainess.Location = new System.Drawing.Point(12, 59);
            this.lb2_SearchTrainess.Name = "lb2_SearchTrainess";
            this.lb2_SearchTrainess.Size = new System.Drawing.Size(205, 57);
            this.lb2_SearchTrainess.TabIndex = 54;
            this.lb2_SearchTrainess.Text = "Пожалуйста, введите критерии для поиска.";
            this.lb2_SearchTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_FamillySearchTrainess
            // 
            this.tb_FamillySearchTrainess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_FamillySearchTrainess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_FamillySearchTrainess.Location = new System.Drawing.Point(56, 261);
            this.tb_FamillySearchTrainess.Name = "tb_FamillySearchTrainess";
            this.tb_FamillySearchTrainess.Size = new System.Drawing.Size(128, 20);
            this.tb_FamillySearchTrainess.TabIndex = 58;
            // 
            // tb_NameSearchTrainess
            // 
            this.tb_NameSearchTrainess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_NameSearchTrainess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_NameSearchTrainess.Location = new System.Drawing.Point(56, 215);
            this.tb_NameSearchTrainess.Name = "tb_NameSearchTrainess";
            this.tb_NameSearchTrainess.Size = new System.Drawing.Size(128, 20);
            this.tb_NameSearchTrainess.TabIndex = 57;
            // 
            // lb5_SearchTrainess
            // 
            this.lb5_SearchTrainess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb5_SearchTrainess.AutoSize = true;
            this.lb5_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5_SearchTrainess.Location = new System.Drawing.Point(52, 238);
            this.lb5_SearchTrainess.Name = "lb5_SearchTrainess";
            this.lb5_SearchTrainess.Size = new System.Drawing.Size(40, 20);
            this.lb5_SearchTrainess.TabIndex = 56;
            this.lb5_SearchTrainess.Text = "Имя";
            // 
            // lb4_SearchTrainess
            // 
            this.lb4_SearchTrainess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb4_SearchTrainess.AutoSize = true;
            this.lb4_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_SearchTrainess.Location = new System.Drawing.Point(52, 192);
            this.lb4_SearchTrainess.Name = "lb4_SearchTrainess";
            this.lb4_SearchTrainess.Size = new System.Drawing.Size(81, 20);
            this.lb4_SearchTrainess.TabIndex = 55;
            this.lb4_SearchTrainess.Text = "Фамилия";
            // 
            // lb1_SearchTrainess
            // 
            this.lb1_SearchTrainess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb1_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_SearchTrainess.Location = new System.Drawing.Point(12, 9);
            this.lb1_SearchTrainess.Name = "lb1_SearchTrainess";
            this.lb1_SearchTrainess.Size = new System.Drawing.Size(205, 50);
            this.lb1_SearchTrainess.TabIndex = 59;
            this.lb1_SearchTrainess.Text = "Поиск данных.";
            this.lb1_SearchTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3_SearchTrainess
            // 
            this.lb3_SearchTrainess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb3_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_SearchTrainess.ForeColor = System.Drawing.Color.Black;
            this.lb3_SearchTrainess.Location = new System.Drawing.Point(12, 116);
            this.lb3_SearchTrainess.Name = "lb3_SearchTrainess";
            this.lb3_SearchTrainess.Size = new System.Drawing.Size(205, 31);
            this.lb3_SearchTrainess.TabIndex = 60;
            this.lb3_SearchTrainess.Text = "Пожалуйста, введите критерии для поиска.";
            this.lb3_SearchTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Class
            // 
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 45;
            // 
            // Fimilia
            // 
            this.Fimilia.HeaderText = "Фамилия";
            this.Fimilia.Name = "Fimilia";
            this.Fimilia.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Book
            // 
            this.Book.HeaderText = "Издание";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            this.Book.Width = 115;
            // 
            // Avtors
            // 
            this.Avtors.HeaderText = "Авторы";
            this.Avtors.Name = "Avtors";
            this.Avtors.ReadOnly = true;
            // 
            // Date_Issue
            // 
            this.Date_Issue.HeaderText = "Дата выдачи";
            this.Date_Issue.Name = "Date_Issue";
            this.Date_Issue.ReadOnly = true;
            this.Date_Issue.Width = 80;
            // 
            // Date_Return
            // 
            this.Date_Return.HeaderText = "Дата возврата";
            this.Date_Return.Name = "Date_Return";
            this.Date_Return.ReadOnly = true;
            this.Date_Return.Width = 80;
            // 
            // SearchTrainessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 296);
            this.Controls.Add(this.lb3_SearchTrainess);
            this.Controls.Add(this.lb1_SearchTrainess);
            this.Controls.Add(this.tb_FamillySearchTrainess);
            this.Controls.Add(this.tb_NameSearchTrainess);
            this.Controls.Add(this.lb5_SearchTrainess);
            this.Controls.Add(this.lb4_SearchTrainess);
            this.Controls.Add(this.lb2_SearchTrainess);
            this.Controls.Add(this.cb_SearchTrainess);
            this.Controls.Add(this.dgv_SearchTrainess);
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchTrainess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SearchTrainess;
        private System.Windows.Forms.CheckBox cb_SearchTrainess;
        private System.Windows.Forms.Label lb2_SearchTrainess;
        private System.Windows.Forms.TextBox tb_FamillySearchTrainess;
        private System.Windows.Forms.TextBox tb_NameSearchTrainess;
        private System.Windows.Forms.Label lb5_SearchTrainess;
        private System.Windows.Forms.Label lb4_SearchTrainess;
        private System.Windows.Forms.Label lb1_SearchTrainess;
        private System.Windows.Forms.Label lb3_SearchTrainess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fimilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avtors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Issue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Return;
    }
}