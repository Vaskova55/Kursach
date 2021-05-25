
namespace Biblioteka2.Forms
{
    partial class AddLitTurnoverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLitTurnoverForm));
            this.lb3_Spisanie = new System.Windows.Forms.Label();
            this.cb_LiteratureSpisanie = new System.Windows.Forms.ComboBox();
            this.lb2_Spisanie = new System.Windows.Forms.Label();
            this.lb1_Spisanie = new System.Windows.Forms.Label();
            this.dtp_Spisanie = new System.Windows.Forms.DateTimePicker();
            this.lb_ListSpisanie = new System.Windows.Forms.ListBox();
            this.bt_MinusBookListSpisanie = new System.Windows.Forms.Button();
            this.bt_PlusBookListSpisanie = new System.Windows.Forms.Button();
            this.lb4_Spisanie = new System.Windows.Forms.Label();
            this.lb5_Spisanie = new System.Windows.Forms.Label();
            this.bt_Spisat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb3_Spisanie
            // 
            this.lb3_Spisanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb3_Spisanie.AutoSize = true;
            this.lb3_Spisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_Spisanie.Location = new System.Drawing.Point(12, 159);
            this.lb3_Spisanie.Name = "lb3_Spisanie";
            this.lb3_Spisanie.Size = new System.Drawing.Size(104, 20);
            this.lb3_Spisanie.TabIndex = 63;
            this.lb3_Spisanie.Text = "Литература:";
            // 
            // cb_LiteratureSpisanie
            // 
            this.cb_LiteratureSpisanie.FormattingEnabled = true;
            this.cb_LiteratureSpisanie.Location = new System.Drawing.Point(16, 182);
            this.cb_LiteratureSpisanie.Name = "cb_LiteratureSpisanie";
            this.cb_LiteratureSpisanie.Size = new System.Drawing.Size(179, 21);
            this.cb_LiteratureSpisanie.TabIndex = 62;
            // 
            // lb2_Spisanie
            // 
            this.lb2_Spisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_Spisanie.Location = new System.Drawing.Point(12, 59);
            this.lb2_Spisanie.Name = "lb2_Spisanie";
            this.lb2_Spisanie.Size = new System.Drawing.Size(198, 82);
            this.lb2_Spisanie.TabIndex = 65;
            this.lb2_Spisanie.Text = "Пожалуйста, введите данные для добавления.";
            this.lb2_Spisanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1_Spisanie
            // 
            this.lb1_Spisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_Spisanie.Location = new System.Drawing.Point(12, 9);
            this.lb1_Spisanie.Name = "lb1_Spisanie";
            this.lb1_Spisanie.Size = new System.Drawing.Size(198, 50);
            this.lb1_Spisanie.TabIndex = 64;
            this.lb1_Spisanie.Text = "Новый данные.";
            this.lb1_Spisanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_Spisanie
            // 
            this.dtp_Spisanie.Location = new System.Drawing.Point(16, 458);
            this.dtp_Spisanie.Name = "dtp_Spisanie";
            this.dtp_Spisanie.Size = new System.Drawing.Size(179, 20);
            this.dtp_Spisanie.TabIndex = 66;
            // 
            // lb_ListSpisanie
            // 
            this.lb_ListSpisanie.FormattingEnabled = true;
            this.lb_ListSpisanie.HorizontalScrollbar = true;
            this.lb_ListSpisanie.Items.AddRange(new object[] {
            ""});
            this.lb_ListSpisanie.Location = new System.Drawing.Point(16, 233);
            this.lb_ListSpisanie.Name = "lb_ListSpisanie";
            this.lb_ListSpisanie.Size = new System.Drawing.Size(179, 199);
            this.lb_ListSpisanie.TabIndex = 101;
            // 
            // bt_MinusBookListSpisanie
            // 
            this.bt_MinusBookListSpisanie.BackColor = System.Drawing.Color.Transparent;
            this.bt_MinusBookListSpisanie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_MinusBookListSpisanie.BackgroundImage")));
            this.bt_MinusBookListSpisanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_MinusBookListSpisanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_MinusBookListSpisanie.Location = new System.Drawing.Point(201, 260);
            this.bt_MinusBookListSpisanie.Name = "bt_MinusBookListSpisanie";
            this.bt_MinusBookListSpisanie.Size = new System.Drawing.Size(22, 21);
            this.bt_MinusBookListSpisanie.TabIndex = 103;
            this.bt_MinusBookListSpisanie.UseVisualStyleBackColor = false;
            this.bt_MinusBookListSpisanie.Click += new System.EventHandler(this.bt_MinusBookListSpisanie_Click);
            // 
            // bt_PlusBookListSpisanie
            // 
            this.bt_PlusBookListSpisanie.BackColor = System.Drawing.Color.Transparent;
            this.bt_PlusBookListSpisanie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_PlusBookListSpisanie.BackgroundImage")));
            this.bt_PlusBookListSpisanie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_PlusBookListSpisanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PlusBookListSpisanie.Location = new System.Drawing.Point(201, 233);
            this.bt_PlusBookListSpisanie.Name = "bt_PlusBookListSpisanie";
            this.bt_PlusBookListSpisanie.Size = new System.Drawing.Size(22, 21);
            this.bt_PlusBookListSpisanie.TabIndex = 102;
            this.bt_PlusBookListSpisanie.UseVisualStyleBackColor = false;
            this.bt_PlusBookListSpisanie.Click += new System.EventHandler(this.bt_PlusBookListSpisanie_Click);
            // 
            // lb4_Spisanie
            // 
            this.lb4_Spisanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb4_Spisanie.AutoSize = true;
            this.lb4_Spisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_Spisanie.Location = new System.Drawing.Point(12, 210);
            this.lb4_Spisanie.Name = "lb4_Spisanie";
            this.lb4_Spisanie.Size = new System.Drawing.Size(200, 20);
            this.lb4_Spisanie.TabIndex = 104;
            this.lb4_Spisanie.Text = "Литература на списание:";
            // 
            // lb5_Spisanie
            // 
            this.lb5_Spisanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb5_Spisanie.AutoSize = true;
            this.lb5_Spisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5_Spisanie.Location = new System.Drawing.Point(12, 435);
            this.lb5_Spisanie.Name = "lb5_Spisanie";
            this.lb5_Spisanie.Size = new System.Drawing.Size(126, 20);
            this.lb5_Spisanie.TabIndex = 105;
            this.lb5_Spisanie.Text = "Дата списания:";
            // 
            // bt_Spisat
            // 
            this.bt_Spisat.BackColor = System.Drawing.Color.Transparent;
            this.bt_Spisat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Spisat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Spisat.Location = new System.Drawing.Point(90, 490);
            this.bt_Spisat.Name = "bt_Spisat";
            this.bt_Spisat.Size = new System.Drawing.Size(105, 34);
            this.bt_Spisat.TabIndex = 106;
            this.bt_Spisat.Text = "Списать";
            this.bt_Spisat.UseVisualStyleBackColor = false;
            this.bt_Spisat.Click += new System.EventHandler(this.bt_BooksReturn_Click);
            // 
            // AddLitTurnoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(236, 534);
            this.Controls.Add(this.bt_Spisat);
            this.Controls.Add(this.lb5_Spisanie);
            this.Controls.Add(this.lb4_Spisanie);
            this.Controls.Add(this.bt_MinusBookListSpisanie);
            this.Controls.Add(this.bt_PlusBookListSpisanie);
            this.Controls.Add(this.lb_ListSpisanie);
            this.Controls.Add(this.dtp_Spisanie);
            this.Controls.Add(this.lb2_Spisanie);
            this.Controls.Add(this.lb1_Spisanie);
            this.Controls.Add(this.lb3_Spisanie);
            this.Controls.Add(this.cb_LiteratureSpisanie);
            this.Name = "AddLitTurnoverForm";
            this.Text = "Списать литературу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb3_Spisanie;
        private System.Windows.Forms.ComboBox cb_LiteratureSpisanie;
        private System.Windows.Forms.Label lb2_Spisanie;
        private System.Windows.Forms.Label lb1_Spisanie;
        private System.Windows.Forms.DateTimePicker dtp_Spisanie;
        private System.Windows.Forms.ListBox lb_ListSpisanie;
        private System.Windows.Forms.Button bt_MinusBookListSpisanie;
        private System.Windows.Forms.Button bt_PlusBookListSpisanie;
        private System.Windows.Forms.Label lb4_Spisanie;
        private System.Windows.Forms.Label lb5_Spisanie;
        private System.Windows.Forms.Button bt_Spisat;
    }
}