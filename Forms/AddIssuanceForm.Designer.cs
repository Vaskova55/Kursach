
namespace Biblioteka2.Forms
{
    partial class AddIssuanceForm
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
            this.lb4_AddIssuance = new System.Windows.Forms.Label();
            this.cb_FIOTrIssuance = new System.Windows.Forms.ComboBox();
            this.lb5_AddIssuance = new System.Windows.Forms.Label();
            this.cb_LiteratureIssuance = new System.Windows.Forms.ComboBox();
            this.lb7_AddIssuance = new System.Windows.Forms.Label();
            this.dtp_Issuance = new System.Windows.Forms.DateTimePicker();
            this.Ok_AddIssuance = new System.Windows.Forms.Button();
            this.lb3_classTrIssuance = new System.Windows.Forms.Label();
            this.nud_classTrIssuance = new System.Windows.Forms.NumericUpDown();
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            this.cb_mountmax = new System.Windows.Forms.ComboBox();
            this.lb8_AddIssuance = new System.Windows.Forms.Label();
            this.lb9_AddIssuance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_classTrIssuance)).BeginInit();
            this.SuspendLayout();
            // 
            // lb2_AdIssuance
            // 
            this.lb2_AdIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2_AdIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_AdIssuance.Location = new System.Drawing.Point(9, 59);
            this.lb2_AdIssuance.Name = "lb2_AdIssuance";
            this.lb2_AdIssuance.Size = new System.Drawing.Size(205, 82);
            this.lb2_AdIssuance.TabIndex = 55;
            this.lb2_AdIssuance.Text = "Пожалуйста, введите данные для добавления.";
            this.lb2_AdIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1_AddIssuance
            // 
            this.lb1_AddIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1_AddIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_AddIssuance.Location = new System.Drawing.Point(12, 9);
            this.lb1_AddIssuance.Name = "lb1_AddIssuance";
            this.lb1_AddIssuance.Size = new System.Drawing.Size(202, 50);
            this.lb1_AddIssuance.TabIndex = 54;
            this.lb1_AddIssuance.Text = "Новый данные.";
            this.lb1_AddIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4_AddIssuance
            // 
            this.lb4_AddIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb4_AddIssuance.AutoSize = true;
            this.lb4_AddIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_AddIssuance.Location = new System.Drawing.Point(45, 187);
            this.lb4_AddIssuance.Name = "lb4_AddIssuance";
            this.lb4_AddIssuance.Size = new System.Drawing.Size(119, 20);
            this.lb4_AddIssuance.TabIndex = 59;
            this.lb4_AddIssuance.Text = "Обучающийся:";
            // 
            // cb_FIOTrIssuance
            // 
            this.cb_FIOTrIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_FIOTrIssuance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FIOTrIssuance.FormattingEnabled = true;
            this.cb_FIOTrIssuance.Location = new System.Drawing.Point(43, 210);
            this.cb_FIOTrIssuance.Name = "cb_FIOTrIssuance";
            this.cb_FIOTrIssuance.Size = new System.Drawing.Size(146, 21);
            this.cb_FIOTrIssuance.TabIndex = 58;
            this.cb_FIOTrIssuance.SelectedIndexChanged += new System.EventHandler(this.cb_FIOTrIssuance_SelectedIndexChanged);
            // 
            // lb5_AddIssuance
            // 
            this.lb5_AddIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb5_AddIssuance.AutoSize = true;
            this.lb5_AddIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5_AddIssuance.Location = new System.Drawing.Point(45, 234);
            this.lb5_AddIssuance.Name = "lb5_AddIssuance";
            this.lb5_AddIssuance.Size = new System.Drawing.Size(104, 20);
            this.lb5_AddIssuance.TabIndex = 61;
            this.lb5_AddIssuance.Text = "Литература:";
            // 
            // cb_LiteratureIssuance
            // 
            this.cb_LiteratureIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_LiteratureIssuance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LiteratureIssuance.FormattingEnabled = true;
            this.cb_LiteratureIssuance.Location = new System.Drawing.Point(43, 257);
            this.cb_LiteratureIssuance.Name = "cb_LiteratureIssuance";
            this.cb_LiteratureIssuance.Size = new System.Drawing.Size(146, 21);
            this.cb_LiteratureIssuance.TabIndex = 60;
            // 
            // lb7_AddIssuance
            // 
            this.lb7_AddIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb7_AddIssuance.AutoSize = true;
            this.lb7_AddIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb7_AddIssuance.Location = new System.Drawing.Point(40, 281);
            this.lb7_AddIssuance.Name = "lb7_AddIssuance";
            this.lb7_AddIssuance.Size = new System.Drawing.Size(114, 20);
            this.lb7_AddIssuance.TabIndex = 63;
            this.lb7_AddIssuance.Text = "Дата выдачи:";
            // 
            // dtp_Issuance
            // 
            this.dtp_Issuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Issuance.Location = new System.Drawing.Point(43, 304);
            this.dtp_Issuance.Name = "dtp_Issuance";
            this.dtp_Issuance.Size = new System.Drawing.Size(146, 20);
            this.dtp_Issuance.TabIndex = 64;
            this.dtp_Issuance.ValueChanged += new System.EventHandler(this.date_info_update);
            // 
            // Ok_AddIssuance
            // 
            this.Ok_AddIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok_AddIssuance.BackColor = System.Drawing.Color.Transparent;
            this.Ok_AddIssuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_AddIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_AddIssuance.Location = new System.Drawing.Point(49, 448);
            this.Ok_AddIssuance.Name = "Ok_AddIssuance";
            this.Ok_AddIssuance.Size = new System.Drawing.Size(132, 48);
            this.Ok_AddIssuance.TabIndex = 65;
            this.Ok_AddIssuance.Text = "Добавить";
            this.Ok_AddIssuance.UseVisualStyleBackColor = false;
            this.Ok_AddIssuance.Click += new System.EventHandler(this.Ok_AddIssuance_Click);
            // 
            // lb3_classTrIssuance
            // 
            this.lb3_classTrIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb3_classTrIssuance.AutoSize = true;
            this.lb3_classTrIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_classTrIssuance.Location = new System.Drawing.Point(45, 141);
            this.lb3_classTrIssuance.Name = "lb3_classTrIssuance";
            this.lb3_classTrIssuance.Size = new System.Drawing.Size(58, 20);
            this.lb3_classTrIssuance.TabIndex = 68;
            this.lb3_classTrIssuance.Text = "Класс:";
            // 
            // nud_classTrIssuance
            // 
            this.nud_classTrIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_classTrIssuance.Location = new System.Drawing.Point(43, 164);
            this.nud_classTrIssuance.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nud_classTrIssuance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_classTrIssuance.Name = "nud_classTrIssuance";
            this.nud_classTrIssuance.Size = new System.Drawing.Size(146, 20);
            this.nud_classTrIssuance.TabIndex = 67;
            this.nud_classTrIssuance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_classTrIssuance.ValueChanged += new System.EventHandler(this.nud_classTrIssuance_ValueChanged);
            // 
            // dtp_return
            // 
            this.dtp_return.Location = new System.Drawing.Point(43, 418);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.Size = new System.Drawing.Size(146, 20);
            this.dtp_return.TabIndex = 71;
            this.dtp_return.ValueChanged += new System.EventHandler(this.date_info_update);
            // 
            // cb_mountmax
            // 
            this.cb_mountmax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mountmax.FormattingEnabled = true;
            this.cb_mountmax.Items.AddRange(new object[] {
            "1 Год",
            "2 Года",
            "3 Года"});
            this.cb_mountmax.Location = new System.Drawing.Point(43, 373);
            this.cb_mountmax.Name = "cb_mountmax";
            this.cb_mountmax.Size = new System.Drawing.Size(146, 21);
            this.cb_mountmax.TabIndex = 72;
            this.cb_mountmax.SelectedIndexChanged += new System.EventHandler(this.date_info_update);
            // 
            // lb8_AddIssuance
            // 
            this.lb8_AddIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb8_AddIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb8_AddIssuance.Location = new System.Drawing.Point(40, 327);
            this.lb8_AddIssuance.Name = "lb8_AddIssuance";
            this.lb8_AddIssuance.Size = new System.Drawing.Size(149, 43);
            this.lb8_AddIssuance.TabIndex = 73;
            this.lb8_AddIssuance.Text = "Максимальный срок выдачи:";
            // 
            // lb9_AddIssuance
            // 
            this.lb9_AddIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb9_AddIssuance.AutoSize = true;
            this.lb9_AddIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb9_AddIssuance.Location = new System.Drawing.Point(40, 395);
            this.lb9_AddIssuance.Name = "lb9_AddIssuance";
            this.lb9_AddIssuance.Size = new System.Drawing.Size(104, 20);
            this.lb9_AddIssuance.TabIndex = 74;
            this.lb9_AddIssuance.Text = "Литература:";
            // 
            // AddIssuanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(226, 508);
            this.Controls.Add(this.lb9_AddIssuance);
            this.Controls.Add(this.lb8_AddIssuance);
            this.Controls.Add(this.cb_mountmax);
            this.Controls.Add(this.dtp_return);
            this.Controls.Add(this.lb3_classTrIssuance);
            this.Controls.Add(this.nud_classTrIssuance);
            this.Controls.Add(this.Ok_AddIssuance);
            this.Controls.Add(this.dtp_Issuance);
            this.Controls.Add(this.lb7_AddIssuance);
            this.Controls.Add(this.lb5_AddIssuance);
            this.Controls.Add(this.cb_LiteratureIssuance);
            this.Controls.Add(this.lb4_AddIssuance);
            this.Controls.Add(this.cb_FIOTrIssuance);
            this.Controls.Add(this.lb2_AdIssuance);
            this.Controls.Add(this.lb1_AddIssuance);
            this.Name = "AddIssuanceForm";
            this.Text = "Новые данные";
            ((System.ComponentModel.ISupportInitialize)(this.nud_classTrIssuance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb2_AdIssuance;
        private System.Windows.Forms.Label lb1_AddIssuance;
        private System.Windows.Forms.Label lb4_AddIssuance;
        private System.Windows.Forms.ComboBox cb_FIOTrIssuance;
        private System.Windows.Forms.Label lb5_AddIssuance;
        private System.Windows.Forms.ComboBox cb_LiteratureIssuance;
        private System.Windows.Forms.Label lb7_AddIssuance;
        private System.Windows.Forms.DateTimePicker dtp_Issuance;
        private System.Windows.Forms.Button Ok_AddIssuance;
        private System.Windows.Forms.Label lb3_classTrIssuance;
        private System.Windows.Forms.NumericUpDown nud_classTrIssuance;
        private System.Windows.Forms.DateTimePicker dtp_return;
        private System.Windows.Forms.ComboBox cb_mountmax;
        private System.Windows.Forms.Label lb8_AddIssuance;
        private System.Windows.Forms.Label lb9_AddIssuance;
    }
}