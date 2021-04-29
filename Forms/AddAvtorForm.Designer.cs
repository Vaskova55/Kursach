
namespace Biblioteka2.Forms
{
    partial class AddAvtorForm
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
            this.cb_noMiddle = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_middlename = new System.Windows.Forms.TextBox();
            this.lb2_AddTrainess = new System.Windows.Forms.Label();
            this.lb1_AddTrainess = new System.Windows.Forms.Label();
            this.Ok_AddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_noMiddle
            // 
            this.cb_noMiddle.AutoSize = true;
            this.cb_noMiddle.ForeColor = System.Drawing.Color.Black;
            this.cb_noMiddle.Location = new System.Drawing.Point(49, 289);
            this.cb_noMiddle.Name = "cb_noMiddle";
            this.cb_noMiddle.Size = new System.Drawing.Size(96, 17);
            this.cb_noMiddle.TabIndex = 78;
            this.cb_noMiddle.Text = "Нет отчества.";
            this.cb_noMiddle.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(45, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Отчество автора:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(45, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Имя автора:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(45, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "Фамилия автора:";
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(49, 170);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(139, 20);
            this.tb_firstname.TabIndex = 74;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(49, 216);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(139, 20);
            this.tb_lastname.TabIndex = 73;
            // 
            // tb_middlename
            // 
            this.tb_middlename.Location = new System.Drawing.Point(49, 263);
            this.tb_middlename.Name = "tb_middlename";
            this.tb_middlename.Size = new System.Drawing.Size(139, 20);
            this.tb_middlename.TabIndex = 72;
            // 
            // lb2_AddTrainess
            // 
            this.lb2_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_AddTrainess.Location = new System.Drawing.Point(14, 59);
            this.lb2_AddTrainess.Name = "lb2_AddTrainess";
            this.lb2_AddTrainess.Size = new System.Drawing.Size(205, 82);
            this.lb2_AddTrainess.TabIndex = 80;
            this.lb2_AddTrainess.Text = "Пожалуйста, введите данные для добавления.";
            this.lb2_AddTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1_AddTrainess
            // 
            this.lb1_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_AddTrainess.Location = new System.Drawing.Point(14, 9);
            this.lb1_AddTrainess.Name = "lb1_AddTrainess";
            this.lb1_AddTrainess.Size = new System.Drawing.Size(205, 50);
            this.lb1_AddTrainess.TabIndex = 79;
            this.lb1_AddTrainess.Text = "Новый данные.";
            this.lb1_AddTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ok_AddBook
            // 
            this.Ok_AddBook.BackColor = System.Drawing.Color.Transparent;
            this.Ok_AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_AddBook.Location = new System.Drawing.Point(49, 312);
            this.Ok_AddBook.Name = "Ok_AddBook";
            this.Ok_AddBook.Size = new System.Drawing.Size(139, 36);
            this.Ok_AddBook.TabIndex = 81;
            this.Ok_AddBook.Text = "Добавить";
            this.Ok_AddBook.UseVisualStyleBackColor = false;
            this.Ok_AddBook.Click += new System.EventHandler(this.Ok_AddBook_Click);
            // 
            // AddAvtorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(234, 370);
            this.Controls.Add(this.Ok_AddBook);
            this.Controls.Add(this.lb2_AddTrainess);
            this.Controls.Add(this.lb1_AddTrainess);
            this.Controls.Add(this.cb_noMiddle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_middlename);
            this.Name = "AddAvtorForm";
            this.Text = "Новые данные";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_noMiddle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_middlename;
        private System.Windows.Forms.Label lb2_AddTrainess;
        private System.Windows.Forms.Label lb1_AddTrainess;
        private System.Windows.Forms.Button Ok_AddBook;
    }
}