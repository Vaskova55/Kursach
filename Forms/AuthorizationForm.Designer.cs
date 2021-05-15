
namespace Biblioteka2.Forms
{
    partial class AuthorizationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb4_Autorization = new System.Windows.Forms.Label();
            this.Ok_Autorization = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb3_Autorization = new System.Windows.Forms.Label();
            this.lb1_Autorization = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "Авторизация.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4_Autorization
            // 
            this.lb4_Autorization.AutoSize = true;
            this.lb4_Autorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_Autorization.Location = new System.Drawing.Point(54, 193);
            this.lb4_Autorization.Name = "lb4_Autorization";
            this.lb4_Autorization.Size = new System.Drawing.Size(71, 20);
            this.lb4_Autorization.TabIndex = 15;
            this.lb4_Autorization.Text = "Пароль:";
            // 
            // Ok_Autorization
            // 
            this.Ok_Autorization.BackColor = System.Drawing.Color.Transparent;
            this.Ok_Autorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_Autorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_Autorization.Location = new System.Drawing.Point(113, 253);
            this.Ok_Autorization.Name = "Ok_Autorization";
            this.Ok_Autorization.Size = new System.Drawing.Size(73, 36);
            this.Ok_Autorization.TabIndex = 14;
            this.Ok_Autorization.Text = "Вход";
            this.Ok_Autorization.UseVisualStyleBackColor = false;
            this.Ok_Autorization.Click += new System.EventHandler(this.Ok_Autorization_Click);
            // 
            // tb_password
            // 
            this.tb_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_password.Location = new System.Drawing.Point(58, 216);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(128, 20);
            this.tb_password.TabIndex = 13;
            // 
            // tb_login
            // 
            this.tb_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_login.Location = new System.Drawing.Point(58, 170);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(128, 20);
            this.tb_login.TabIndex = 12;
            // 
            // lb3_Autorization
            // 
            this.lb3_Autorization.AutoSize = true;
            this.lb3_Autorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_Autorization.Location = new System.Drawing.Point(54, 173);
            this.lb3_Autorization.Name = "lb3_Autorization";
            this.lb3_Autorization.Size = new System.Drawing.Size(59, 20);
            this.lb3_Autorization.TabIndex = 11;
            this.lb3_Autorization.Text = "Логин:";
            // 
            // lb1_Autorization
            // 
            this.lb1_Autorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_Autorization.Location = new System.Drawing.Point(12, 59);
            this.lb1_Autorization.Name = "lb1_Autorization";
            this.lb1_Autorization.Size = new System.Drawing.Size(205, 88);
            this.lb1_Autorization.TabIndex = 10;
            this.lb1_Autorization.Text = "Пожалуйста, введите данные вашего пользователя.";
            this.lb1_Autorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Логин:";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(229, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb4_Autorization);
            this.Controls.Add(this.Ok_Autorization);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lb3_Autorization);
            this.Controls.Add(this.lb1_Autorization);
            this.Name = "AuthorizationForm";
            this.Text = "ЫЫы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb4_Autorization;
        private System.Windows.Forms.Button Ok_Autorization;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb3_Autorization;
        private System.Windows.Forms.Label lb1_Autorization;
        private System.Windows.Forms.Label label2;
    }
}