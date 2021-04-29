
namespace Biblioteka2.Forms
{
    partial class AddTrainessForm
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
            this.lb2_AddTrainess = new System.Windows.Forms.Label();
            this.lb1_AddTrainess = new System.Windows.Forms.Label();
            this.Ok_AddTrainess = new System.Windows.Forms.Button();
            this.cb_noMiddle = new System.Windows.Forms.CheckBox();
            this.tb_AddTrainess_name = new System.Windows.Forms.TextBox();
            this.tb_AddTrainess_middle = new System.Windows.Forms.TextBox();
            this.tb_AddTrainess_fam = new System.Windows.Forms.TextBox();
            this.lb6_AddTrainess = new System.Windows.Forms.Label();
            this.lb5_AddTrainess = new System.Windows.Forms.Label();
            this.lb4_AddTrainess = new System.Windows.Forms.Label();
            this.lb3_AddTrainess = new System.Windows.Forms.Label();
            this.nud_AddTrainess_class = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AddTrainess_class)).BeginInit();
            this.SuspendLayout();
            // 
            // lb2_AddTrainess
            // 
            this.lb2_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_AddTrainess.Location = new System.Drawing.Point(30, 62);
            this.lb2_AddTrainess.Name = "lb2_AddTrainess";
            this.lb2_AddTrainess.Size = new System.Drawing.Size(205, 82);
            this.lb2_AddTrainess.TabIndex = 31;
            this.lb2_AddTrainess.Text = "Пожалуйста, введите данные для добавления.";
            this.lb2_AddTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1_AddTrainess
            // 
            this.lb1_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_AddTrainess.Location = new System.Drawing.Point(30, 12);
            this.lb1_AddTrainess.Name = "lb1_AddTrainess";
            this.lb1_AddTrainess.Size = new System.Drawing.Size(205, 50);
            this.lb1_AddTrainess.TabIndex = 30;
            this.lb1_AddTrainess.Text = "Новый данные.";
            this.lb1_AddTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ok_AddTrainess
            // 
            this.Ok_AddTrainess.BackColor = System.Drawing.Color.Transparent;
            this.Ok_AddTrainess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_AddTrainess.Location = new System.Drawing.Point(68, 376);
            this.Ok_AddTrainess.Name = "Ok_AddTrainess";
            this.Ok_AddTrainess.Size = new System.Drawing.Size(128, 36);
            this.Ok_AddTrainess.TabIndex = 41;
            this.Ok_AddTrainess.Text = "Добавить";
            this.Ok_AddTrainess.UseVisualStyleBackColor = false;
            this.Ok_AddTrainess.Click += new System.EventHandler(this.Ok_AddTrainess_Click);
            // 
            // cb_noMiddle
            // 
            this.cb_noMiddle.AutoSize = true;
            this.cb_noMiddle.ForeColor = System.Drawing.Color.Black;
            this.cb_noMiddle.Location = new System.Drawing.Point(68, 340);
            this.cb_noMiddle.Name = "cb_noMiddle";
            this.cb_noMiddle.Size = new System.Drawing.Size(96, 17);
            this.cb_noMiddle.TabIndex = 40;
            this.cb_noMiddle.Text = "Нет отчества.";
            this.cb_noMiddle.UseVisualStyleBackColor = true;
            // 
            // tb_AddTrainess_name
            // 
            this.tb_AddTrainess_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_AddTrainess_name.Location = new System.Drawing.Point(68, 268);
            this.tb_AddTrainess_name.Name = "tb_AddTrainess_name";
            this.tb_AddTrainess_name.Size = new System.Drawing.Size(128, 20);
            this.tb_AddTrainess_name.TabIndex = 39;
            // 
            // tb_AddTrainess_middle
            // 
            this.tb_AddTrainess_middle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_AddTrainess_middle.Location = new System.Drawing.Point(68, 314);
            this.tb_AddTrainess_middle.Name = "tb_AddTrainess_middle";
            this.tb_AddTrainess_middle.Size = new System.Drawing.Size(128, 20);
            this.tb_AddTrainess_middle.TabIndex = 38;
            // 
            // tb_AddTrainess_fam
            // 
            this.tb_AddTrainess_fam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_AddTrainess_fam.Location = new System.Drawing.Point(68, 222);
            this.tb_AddTrainess_fam.Name = "tb_AddTrainess_fam";
            this.tb_AddTrainess_fam.Size = new System.Drawing.Size(128, 20);
            this.tb_AddTrainess_fam.TabIndex = 37;
            // 
            // lb6_AddTrainess
            // 
            this.lb6_AddTrainess.AutoSize = true;
            this.lb6_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb6_AddTrainess.Location = new System.Drawing.Point(64, 291);
            this.lb6_AddTrainess.Name = "lb6_AddTrainess";
            this.lb6_AddTrainess.Size = new System.Drawing.Size(87, 20);
            this.lb6_AddTrainess.TabIndex = 36;
            this.lb6_AddTrainess.Text = "Отчество:";
            // 
            // lb5_AddTrainess
            // 
            this.lb5_AddTrainess.AutoSize = true;
            this.lb5_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5_AddTrainess.Location = new System.Drawing.Point(64, 245);
            this.lb5_AddTrainess.Name = "lb5_AddTrainess";
            this.lb5_AddTrainess.Size = new System.Drawing.Size(40, 20);
            this.lb5_AddTrainess.TabIndex = 35;
            this.lb5_AddTrainess.Text = "Имя";
            // 
            // lb4_AddTrainess
            // 
            this.lb4_AddTrainess.AutoSize = true;
            this.lb4_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_AddTrainess.Location = new System.Drawing.Point(64, 199);
            this.lb4_AddTrainess.Name = "lb4_AddTrainess";
            this.lb4_AddTrainess.Size = new System.Drawing.Size(81, 20);
            this.lb4_AddTrainess.TabIndex = 34;
            this.lb4_AddTrainess.Text = "Фамилия";
            // 
            // lb3_AddTrainess
            // 
            this.lb3_AddTrainess.AutoSize = true;
            this.lb3_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_AddTrainess.Location = new System.Drawing.Point(64, 153);
            this.lb3_AddTrainess.Name = "lb3_AddTrainess";
            this.lb3_AddTrainess.Size = new System.Drawing.Size(58, 20);
            this.lb3_AddTrainess.TabIndex = 33;
            this.lb3_AddTrainess.Text = "Класс:";
            // 
            // nud_AddTrainess_class
            // 
            this.nud_AddTrainess_class.Location = new System.Drawing.Point(68, 176);
            this.nud_AddTrainess_class.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nud_AddTrainess_class.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_AddTrainess_class.Name = "nud_AddTrainess_class";
            this.nud_AddTrainess_class.Size = new System.Drawing.Size(128, 20);
            this.nud_AddTrainess_class.TabIndex = 32;
            this.nud_AddTrainess_class.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddTrainessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(264, 428);
            this.Controls.Add(this.Ok_AddTrainess);
            this.Controls.Add(this.cb_noMiddle);
            this.Controls.Add(this.tb_AddTrainess_name);
            this.Controls.Add(this.tb_AddTrainess_middle);
            this.Controls.Add(this.tb_AddTrainess_fam);
            this.Controls.Add(this.lb6_AddTrainess);
            this.Controls.Add(this.lb5_AddTrainess);
            this.Controls.Add(this.lb4_AddTrainess);
            this.Controls.Add(this.lb3_AddTrainess);
            this.Controls.Add(this.nud_AddTrainess_class);
            this.Controls.Add(this.lb2_AddTrainess);
            this.Controls.Add(this.lb1_AddTrainess);
            this.Name = "AddTrainessForm";
            this.Text = "Новые данные";
            ((System.ComponentModel.ISupportInitialize)(this.nud_AddTrainess_class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb2_AddTrainess;
        private System.Windows.Forms.Label lb1_AddTrainess;
        private System.Windows.Forms.Button Ok_AddTrainess;
        private System.Windows.Forms.CheckBox cb_noMiddle;
        private System.Windows.Forms.TextBox tb_AddTrainess_name;
        private System.Windows.Forms.TextBox tb_AddTrainess_middle;
        private System.Windows.Forms.TextBox tb_AddTrainess_fam;
        private System.Windows.Forms.Label lb6_AddTrainess;
        private System.Windows.Forms.Label lb5_AddTrainess;
        private System.Windows.Forms.Label lb4_AddTrainess;
        private System.Windows.Forms.Label lb3_AddTrainess;
        private System.Windows.Forms.NumericUpDown nud_AddTrainess_class;
    }
}