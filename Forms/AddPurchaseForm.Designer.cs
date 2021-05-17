
namespace Biblioteka2.Forms
{
    partial class AddPurchaseForm
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
            this.Ok_AddPurchase = new System.Windows.Forms.Button();
            this.lb1_AddPurchase = new System.Windows.Forms.Label();
            this.lb2_AddPurchase = new System.Windows.Forms.Label();
            this.nud_AddPurchase = new System.Windows.Forms.NumericUpDown();
            this.lb3_AddPurchase = new System.Windows.Forms.Label();
            this.tb_AddPurchase = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AddPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok_AddPurchase
            // 
            this.Ok_AddPurchase.BackColor = System.Drawing.Color.Transparent;
            this.Ok_AddPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_AddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_AddPurchase.Location = new System.Drawing.Point(44, 186);
            this.Ok_AddPurchase.Name = "Ok_AddPurchase";
            this.Ok_AddPurchase.Size = new System.Drawing.Size(139, 36);
            this.Ok_AddPurchase.TabIndex = 82;
            this.Ok_AddPurchase.Text = "Добавить";
            this.Ok_AddPurchase.UseVisualStyleBackColor = false;
            this.Ok_AddPurchase.Click += new System.EventHandler(this.Ok_AddPurchase_Click);
            // 
            // lb1_AddPurchase
            // 
            this.lb1_AddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_AddPurchase.Location = new System.Drawing.Point(12, 9);
            this.lb1_AddPurchase.Name = "lb1_AddPurchase";
            this.lb1_AddPurchase.Size = new System.Drawing.Size(205, 82);
            this.lb1_AddPurchase.TabIndex = 83;
            this.lb1_AddPurchase.Text = "Пожалуйста, введите данные о закупке.";
            this.lb1_AddPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2_AddPurchase
            // 
            this.lb2_AddPurchase.AutoSize = true;
            this.lb2_AddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_AddPurchase.Location = new System.Drawing.Point(40, 91);
            this.lb2_AddPurchase.Name = "lb2_AddPurchase";
            this.lb2_AddPurchase.Size = new System.Drawing.Size(104, 20);
            this.lb2_AddPurchase.TabIndex = 84;
            this.lb2_AddPurchase.Text = "Количество:";
            // 
            // nud_AddPurchase
            // 
            this.nud_AddPurchase.Location = new System.Drawing.Point(44, 114);
            this.nud_AddPurchase.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_AddPurchase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_AddPurchase.Name = "nud_AddPurchase";
            this.nud_AddPurchase.Size = new System.Drawing.Size(139, 20);
            this.nud_AddPurchase.TabIndex = 85;
            this.nud_AddPurchase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb3_AddPurchase
            // 
            this.lb3_AddPurchase.AutoSize = true;
            this.lb3_AddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_AddPurchase.Location = new System.Drawing.Point(40, 137);
            this.lb3_AddPurchase.Name = "lb3_AddPurchase";
            this.lb3_AddPurchase.Size = new System.Drawing.Size(52, 20);
            this.lb3_AddPurchase.TabIndex = 86;
            this.lb3_AddPurchase.Text = "Цена:";
            // 
            // tb_AddPurchase
            // 
            this.tb_AddPurchase.Location = new System.Drawing.Point(44, 160);
            this.tb_AddPurchase.Name = "tb_AddPurchase";
            this.tb_AddPurchase.Size = new System.Drawing.Size(139, 20);
            this.tb_AddPurchase.TabIndex = 87;
            // 
            // AddPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(228, 233);
            this.Controls.Add(this.tb_AddPurchase);
            this.Controls.Add(this.lb3_AddPurchase);
            this.Controls.Add(this.nud_AddPurchase);
            this.Controls.Add(this.lb2_AddPurchase);
            this.Controls.Add(this.lb1_AddPurchase);
            this.Controls.Add(this.Ok_AddPurchase);
            this.Name = "AddPurchaseForm";
            this.Text = "Закупка";
            ((System.ComponentModel.ISupportInitialize)(this.nud_AddPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_AddPurchase;
        private System.Windows.Forms.Label lb1_AddPurchase;
        private System.Windows.Forms.Label lb2_AddPurchase;
        private System.Windows.Forms.NumericUpDown nud_AddPurchase;
        private System.Windows.Forms.Label lb3_AddPurchase;
        private System.Windows.Forms.TextBox tb_AddPurchase;
    }
}