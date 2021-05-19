
namespace Biblioteka2.Forms
{
    partial class AddPublisherForm
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
            this.lb1_AddPublisher = new System.Windows.Forms.Label();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.lb2_AddPublisher = new System.Windows.Forms.Label();
            this.lb3_AddPublisher = new System.Windows.Forms.Label();
            this.tb_NamePublisher = new System.Windows.Forms.TextBox();
            this.Ok_AddPublisher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1_AddPublisher
            // 
            this.lb1_AddPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1_AddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_AddPublisher.Location = new System.Drawing.Point(12, 9);
            this.lb1_AddPublisher.Name = "lb1_AddPublisher";
            this.lb1_AddPublisher.Size = new System.Drawing.Size(205, 50);
            this.lb1_AddPublisher.TabIndex = 80;
            this.lb1_AddPublisher.Text = "Новый данные.";
            this.lb1_AddPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_City
            // 
            this.tb_City.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_City.Location = new System.Drawing.Point(48, 82);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(139, 20);
            this.tb_City.TabIndex = 82;
            // 
            // lb2_AddPublisher
            // 
            this.lb2_AddPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2_AddPublisher.AutoSize = true;
            this.lb2_AddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_AddPublisher.Location = new System.Drawing.Point(44, 59);
            this.lb2_AddPublisher.Name = "lb2_AddPublisher";
            this.lb2_AddPublisher.Size = new System.Drawing.Size(60, 20);
            this.lb2_AddPublisher.TabIndex = 83;
            this.lb2_AddPublisher.Text = "Город:";
            // 
            // lb3_AddPublisher
            // 
            this.lb3_AddPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb3_AddPublisher.AutoSize = true;
            this.lb3_AddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_AddPublisher.Location = new System.Drawing.Point(44, 105);
            this.lb3_AddPublisher.Name = "lb3_AddPublisher";
            this.lb3_AddPublisher.Size = new System.Drawing.Size(87, 20);
            this.lb3_AddPublisher.TabIndex = 85;
            this.lb3_AddPublisher.Text = "Название:";
            // 
            // tb_NamePublisher
            // 
            this.tb_NamePublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NamePublisher.Location = new System.Drawing.Point(48, 128);
            this.tb_NamePublisher.Name = "tb_NamePublisher";
            this.tb_NamePublisher.Size = new System.Drawing.Size(139, 20);
            this.tb_NamePublisher.TabIndex = 84;
            // 
            // Ok_AddPublisher
            // 
            this.Ok_AddPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok_AddPublisher.BackColor = System.Drawing.Color.Transparent;
            this.Ok_AddPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_AddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_AddPublisher.Location = new System.Drawing.Point(48, 154);
            this.Ok_AddPublisher.Name = "Ok_AddPublisher";
            this.Ok_AddPublisher.Size = new System.Drawing.Size(139, 36);
            this.Ok_AddPublisher.TabIndex = 86;
            this.Ok_AddPublisher.Text = "Добавить";
            this.Ok_AddPublisher.UseVisualStyleBackColor = false;
            this.Ok_AddPublisher.Click += new System.EventHandler(this.Ok_AddPublisher_Click);
            // 
            // AddPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(230, 214);
            this.Controls.Add(this.Ok_AddPublisher);
            this.Controls.Add(this.lb3_AddPublisher);
            this.Controls.Add(this.tb_NamePublisher);
            this.Controls.Add(this.lb2_AddPublisher);
            this.Controls.Add(this.tb_City);
            this.Controls.Add(this.lb1_AddPublisher);
            this.Name = "AddPublisherForm";
            this.Text = "Добавить данные";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1_AddPublisher;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.Label lb2_AddPublisher;
        private System.Windows.Forms.Label lb3_AddPublisher;
        private System.Windows.Forms.TextBox tb_NamePublisher;
        private System.Windows.Forms.Button Ok_AddPublisher;
    }
}