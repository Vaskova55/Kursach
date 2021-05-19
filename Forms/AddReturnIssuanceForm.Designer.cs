
namespace Biblioteka2.Forms
{
    partial class AddReturnIssuanceForm
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
            this.lb2_AdIssuance = new System.Windows.Forms.Label();
            this.lb1_AddIssuance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb2_AdIssuance
            // 
            this.lb2_AdIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2_AdIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_AdIssuance.Location = new System.Drawing.Point(12, 59);
            this.lb2_AdIssuance.Name = "lb2_AdIssuance";
            this.lb2_AdIssuance.Size = new System.Drawing.Size(205, 82);
            this.lb2_AdIssuance.TabIndex = 57;
            this.lb2_AdIssuance.Text = "Пожалуйста, выберите дату сдачи литературы.";
            this.lb2_AdIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1_AddIssuance
            // 
            this.lb1_AddIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1_AddIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_AddIssuance.Location = new System.Drawing.Point(12, 9);
            this.lb1_AddIssuance.Name = "lb1_AddIssuance";
            this.lb1_AddIssuance.Size = new System.Drawing.Size(202, 50);
            this.lb1_AddIssuance.TabIndex = 56;
            this.lb1_AddIssuance.Text = "Возврат литературы.";
            this.lb1_AddIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddReturnIssuanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(224, 458);
            this.Controls.Add(this.lb2_AdIssuance);
            this.Controls.Add(this.lb1_AddIssuance);
            this.Name = "AddReturnIssuanceForm";
            this.Text = "Возврат литературы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb2_AdIssuance;
        private System.Windows.Forms.Label lb1_AddIssuance;
    }
}