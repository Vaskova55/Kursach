
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
            this.lb2_AddReturnIssuance = new System.Windows.Forms.Label();
            this.lb1_AddReturnIssuance = new System.Windows.Forms.Label();
            this.lb4_AddReturnIssuance = new System.Windows.Forms.Label();
            this.lb3_AddReturnIssuance = new System.Windows.Forms.Label();
            this.bt_PlusBookReturn = new System.Windows.Forms.Button();
            this.bt_MinusBookReturn = new System.Windows.Forms.Button();
            this.bt_BooksReturn = new System.Windows.Forms.Button();
            this.cb_TrainessIssRet = new System.Windows.Forms.ComboBox();
            this.dtp_ReturnIssuance = new System.Windows.Forms.DateTimePicker();
            this.lb_RetLit = new System.Windows.Forms.ListBox();
            this.lb_OkRetLit = new System.Windows.Forms.ListBox();
            this.lb6_AddReturnIssuance = new System.Windows.Forms.Label();
            this.lb5_AddReturnIssuance = new System.Windows.Forms.Label();
            this.lb7_AddReturnIssuance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb2_AddReturnIssuance
            // 
            this.lb2_AddReturnIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2_AddReturnIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_AddReturnIssuance.Location = new System.Drawing.Point(23, 59);
            this.lb2_AddReturnIssuance.Name = "lb2_AddReturnIssuance";
            this.lb2_AddReturnIssuance.Size = new System.Drawing.Size(376, 64);
            this.lb2_AddReturnIssuance.TabIndex = 57;
            this.lb2_AddReturnIssuance.Text = "Пожалуйста, убедитесь в том, что обучающийся возвращает верное количество литерат" +
    "уры и она готова к возврату.";
            this.lb2_AddReturnIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1_AddReturnIssuance
            // 
            this.lb1_AddReturnIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1_AddReturnIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_AddReturnIssuance.Location = new System.Drawing.Point(26, 9);
            this.lb1_AddReturnIssuance.Name = "lb1_AddReturnIssuance";
            this.lb1_AddReturnIssuance.Size = new System.Drawing.Size(373, 50);
            this.lb1_AddReturnIssuance.TabIndex = 56;
            this.lb1_AddReturnIssuance.Text = "Возврат литературы.";
            this.lb1_AddReturnIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4_AddReturnIssuance
            // 
            this.lb4_AddReturnIssuance.AutoSize = true;
            this.lb4_AddReturnIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_AddReturnIssuance.Location = new System.Drawing.Point(22, 191);
            this.lb4_AddReturnIssuance.Name = "lb4_AddReturnIssuance";
            this.lb4_AddReturnIssuance.Size = new System.Drawing.Size(104, 20);
            this.lb4_AddReturnIssuance.TabIndex = 61;
            this.lb4_AddReturnIssuance.Text = "Литература:";
            // 
            // lb3_AddReturnIssuance
            // 
            this.lb3_AddReturnIssuance.AutoSize = true;
            this.lb3_AddReturnIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_AddReturnIssuance.Location = new System.Drawing.Point(22, 144);
            this.lb3_AddReturnIssuance.Name = "lb3_AddReturnIssuance";
            this.lb3_AddReturnIssuance.Size = new System.Drawing.Size(85, 20);
            this.lb3_AddReturnIssuance.TabIndex = 62;
            this.lb3_AddReturnIssuance.Text = "Фамилия:";
            // 
            // bt_PlusBookReturn
            // 
            this.bt_PlusBookReturn.BackColor = System.Drawing.Color.Transparent;
            this.bt_PlusBookReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_PlusBookReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PlusBookReturn.Location = new System.Drawing.Point(201, 242);
            this.bt_PlusBookReturn.Name = "bt_PlusBookReturn";
            this.bt_PlusBookReturn.Size = new System.Drawing.Size(31, 29);
            this.bt_PlusBookReturn.TabIndex = 92;
            this.bt_PlusBookReturn.Text = ">>";
            this.bt_PlusBookReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_PlusBookReturn.UseVisualStyleBackColor = false;
            this.bt_PlusBookReturn.Click += new System.EventHandler(this.bt_PlusBookReturn_Click);
            // 
            // bt_MinusBookReturn
            // 
            this.bt_MinusBookReturn.BackColor = System.Drawing.Color.Transparent;
            this.bt_MinusBookReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_MinusBookReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_MinusBookReturn.Location = new System.Drawing.Point(201, 277);
            this.bt_MinusBookReturn.Name = "bt_MinusBookReturn";
            this.bt_MinusBookReturn.Size = new System.Drawing.Size(31, 29);
            this.bt_MinusBookReturn.TabIndex = 93;
            this.bt_MinusBookReturn.Text = "<<";
            this.bt_MinusBookReturn.UseVisualStyleBackColor = false;
            this.bt_MinusBookReturn.Click += new System.EventHandler(this.bt_MinusBookReturn_Click);
            // 
            // bt_BooksReturn
            // 
            this.bt_BooksReturn.BackColor = System.Drawing.Color.Transparent;
            this.bt_BooksReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_BooksReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_BooksReturn.Location = new System.Drawing.Point(324, 447);
            this.bt_BooksReturn.Name = "bt_BooksReturn";
            this.bt_BooksReturn.Size = new System.Drawing.Size(83, 34);
            this.bt_BooksReturn.TabIndex = 94;
            this.bt_BooksReturn.Text = "Сдать";
            this.bt_BooksReturn.UseVisualStyleBackColor = false;
            this.bt_BooksReturn.Click += new System.EventHandler(this.bt_BooksReturn_Click);
            // 
            // cb_TrainessIssRet
            // 
            this.cb_TrainessIssRet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TrainessIssRet.FormattingEnabled = true;
            this.cb_TrainessIssRet.Location = new System.Drawing.Point(30, 167);
            this.cb_TrainessIssRet.Name = "cb_TrainessIssRet";
            this.cb_TrainessIssRet.Size = new System.Drawing.Size(202, 21);
            this.cb_TrainessIssRet.TabIndex = 98;
            this.cb_TrainessIssRet.SelectedValueChanged += new System.EventHandler(this.cb_TrainessIssRet_SelectedValueChanged);
            // 
            // dtp_ReturnIssuance
            // 
            this.dtp_ReturnIssuance.Location = new System.Drawing.Point(238, 167);
            this.dtp_ReturnIssuance.Name = "dtp_ReturnIssuance";
            this.dtp_ReturnIssuance.Size = new System.Drawing.Size(169, 20);
            this.dtp_ReturnIssuance.TabIndex = 99;
            // 
            // lb_RetLit
            // 
            this.lb_RetLit.FormattingEnabled = true;
            this.lb_RetLit.Location = new System.Drawing.Point(26, 242);
            this.lb_RetLit.Name = "lb_RetLit";
            this.lb_RetLit.Size = new System.Drawing.Size(169, 199);
            this.lb_RetLit.TabIndex = 100;
            // 
            // lb_OkRetLit
            // 
            this.lb_OkRetLit.FormattingEnabled = true;
            this.lb_OkRetLit.Location = new System.Drawing.Point(238, 242);
            this.lb_OkRetLit.Name = "lb_OkRetLit";
            this.lb_OkRetLit.Size = new System.Drawing.Size(170, 199);
            this.lb_OkRetLit.TabIndex = 101;
            // 
            // lb6_AddReturnIssuance
            // 
            this.lb6_AddReturnIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb6_AddReturnIssuance.Location = new System.Drawing.Point(238, 218);
            this.lb6_AddReturnIssuance.Name = "lb6_AddReturnIssuance";
            this.lb6_AddReturnIssuance.Size = new System.Drawing.Size(173, 21);
            this.lb6_AddReturnIssuance.TabIndex = 102;
            this.lb6_AddReturnIssuance.Text = "Возвращаемая литература:";
            // 
            // lb5_AddReturnIssuance
            // 
            this.lb5_AddReturnIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5_AddReturnIssuance.Location = new System.Drawing.Point(22, 218);
            this.lb5_AddReturnIssuance.Name = "lb5_AddReturnIssuance";
            this.lb5_AddReturnIssuance.Size = new System.Drawing.Size(173, 21);
            this.lb5_AddReturnIssuance.TabIndex = 103;
            this.lb5_AddReturnIssuance.Text = "Принимаемая литература:";
            // 
            // lb7_AddReturnIssuance
            // 
            this.lb7_AddReturnIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb7_AddReturnIssuance.Location = new System.Drawing.Point(235, 143);
            this.lb7_AddReturnIssuance.Name = "lb7_AddReturnIssuance";
            this.lb7_AddReturnIssuance.Size = new System.Drawing.Size(173, 21);
            this.lb7_AddReturnIssuance.TabIndex = 104;
            this.lb7_AddReturnIssuance.Text = "Дата возврата литературы:";
            // 
            // AddReturnIssuanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 491);
            this.Controls.Add(this.lb7_AddReturnIssuance);
            this.Controls.Add(this.lb5_AddReturnIssuance);
            this.Controls.Add(this.lb6_AddReturnIssuance);
            this.Controls.Add(this.lb_OkRetLit);
            this.Controls.Add(this.lb_RetLit);
            this.Controls.Add(this.dtp_ReturnIssuance);
            this.Controls.Add(this.cb_TrainessIssRet);
            this.Controls.Add(this.bt_BooksReturn);
            this.Controls.Add(this.bt_MinusBookReturn);
            this.Controls.Add(this.bt_PlusBookReturn);
            this.Controls.Add(this.lb3_AddReturnIssuance);
            this.Controls.Add(this.lb4_AddReturnIssuance);
            this.Controls.Add(this.lb2_AddReturnIssuance);
            this.Controls.Add(this.lb1_AddReturnIssuance);
            this.Name = "AddReturnIssuanceForm";
            this.Text = "Возврат литературы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb2_AddReturnIssuance;
        private System.Windows.Forms.Label lb1_AddReturnIssuance;
        private System.Windows.Forms.Label lb4_AddReturnIssuance;
        private System.Windows.Forms.Label lb3_AddReturnIssuance;
        private System.Windows.Forms.Button bt_PlusBookReturn;
        private System.Windows.Forms.Button bt_MinusBookReturn;
        private System.Windows.Forms.Button bt_BooksReturn;
        private System.Windows.Forms.ComboBox cb_TrainessIssRet;
        private System.Windows.Forms.DateTimePicker dtp_ReturnIssuance;
        private System.Windows.Forms.ListBox lb_RetLit;
        private System.Windows.Forms.ListBox lb_OkRetLit;
        private System.Windows.Forms.Label lb6_AddReturnIssuance;
        private System.Windows.Forms.Label lb5_AddReturnIssuance;
        private System.Windows.Forms.Label lb7_AddReturnIssuance;
    }
}