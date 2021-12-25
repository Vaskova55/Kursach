
namespace Biblioteka2.Forms
{
    partial class Home_pageForm
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
            this.lbl8_Home_page = new System.Windows.Forms.Label();
            this.tb_Nam = new System.Windows.Forms.TextBox();
            this.lbl7_Home_page = new System.Windows.Forms.Label();
            this.tb_Fam = new System.Windows.Forms.TextBox();
            this.lbl6_Home_page = new System.Windows.Forms.Label();
            this.lbl5_Home_page = new System.Windows.Forms.Label();
            this.tb_NameBook = new System.Windows.Forms.TextBox();
            this.lb4_Home_page = new System.Windows.Forms.Label();
            this.tb_Avtor = new System.Windows.Forms.TextBox();
            this.lbl3_Home_page = new System.Windows.Forms.Label();
            this.rb_IssLit = new System.Windows.Forms.RadioButton();
            this.lbl2_Home_page = new System.Windows.Forms.Label();
            this.rb_Dolg = new System.Windows.Forms.RadioButton();
            this.lb1_Home_page = new System.Windows.Forms.Label();
            this.dgv_Home_page = new System.Windows.Forms.DataGridView();
            this.ms_Home_page = new System.Windows.Forms.MenuStrip();
            this.tsmi1_Issuance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2_Library = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3_Treiness = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi4_LiteratureTurnover = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi5_Accounting_book = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi6_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.rb_Chitatel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home_page)).BeginInit();
            this.ms_Home_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl8_Home_page
            // 
            this.lbl8_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl8_Home_page.Location = new System.Drawing.Point(12, 372);
            this.lbl8_Home_page.Name = "lbl8_Home_page";
            this.lbl8_Home_page.Size = new System.Drawing.Size(90, 21);
            this.lbl8_Home_page.TabIndex = 48;
            this.lbl8_Home_page.Text = "Имя:";
            // 
            // tb_Nam
            // 
            this.tb_Nam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_Nam.Location = new System.Drawing.Point(108, 374);
            this.tb_Nam.Name = "tb_Nam";
            this.tb_Nam.Size = new System.Drawing.Size(128, 20);
            this.tb_Nam.TabIndex = 47;
            this.tb_Nam.TextChanged += new System.EventHandler(this.tb_Nam_TextChanged);
            // 
            // lbl7_Home_page
            // 
            this.lbl7_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl7_Home_page.Location = new System.Drawing.Point(12, 347);
            this.lbl7_Home_page.Name = "lbl7_Home_page";
            this.lbl7_Home_page.Size = new System.Drawing.Size(90, 21);
            this.lbl7_Home_page.TabIndex = 46;
            this.lbl7_Home_page.Text = "Фамилия:";
            // 
            // tb_Fam
            // 
            this.tb_Fam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_Fam.Location = new System.Drawing.Point(108, 347);
            this.tb_Fam.Name = "tb_Fam";
            this.tb_Fam.Size = new System.Drawing.Size(128, 20);
            this.tb_Fam.TabIndex = 45;
            this.tb_Fam.TextChanged += new System.EventHandler(this.tb_Fam_TextChanged);
            // 
            // lbl6_Home_page
            // 
            this.lbl6_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl6_Home_page.Location = new System.Drawing.Point(9, 294);
            this.lbl6_Home_page.Name = "lbl6_Home_page";
            this.lbl6_Home_page.Size = new System.Drawing.Size(239, 50);
            this.lbl6_Home_page.TabIndex = 44;
            this.lbl6_Home_page.Text = "Вывод в таблицу истории читателя:";
            this.lbl6_Home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5_Home_page
            // 
            this.lbl5_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl5_Home_page.Location = new System.Drawing.Point(5, 263);
            this.lbl5_Home_page.Name = "lbl5_Home_page";
            this.lbl5_Home_page.Size = new System.Drawing.Size(90, 21);
            this.lbl5_Home_page.TabIndex = 43;
            this.lbl5_Home_page.Text = "Название:";
            // 
            // tb_NameBook
            // 
            this.tb_NameBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_NameBook.Location = new System.Drawing.Point(108, 263);
            this.tb_NameBook.Name = "tb_NameBook";
            this.tb_NameBook.Size = new System.Drawing.Size(128, 20);
            this.tb_NameBook.TabIndex = 42;
            this.tb_NameBook.TextChanged += new System.EventHandler(this.tb_NameBook_TextChanged);
            // 
            // lb4_Home_page
            // 
            this.lb4_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_Home_page.Location = new System.Drawing.Point(5, 234);
            this.lb4_Home_page.Name = "lb4_Home_page";
            this.lb4_Home_page.Size = new System.Drawing.Size(90, 21);
            this.lb4_Home_page.TabIndex = 41;
            this.lb4_Home_page.Text = "Автор:";
            // 
            // tb_Avtor
            // 
            this.tb_Avtor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_Avtor.Location = new System.Drawing.Point(108, 237);
            this.tb_Avtor.Name = "tb_Avtor";
            this.tb_Avtor.Size = new System.Drawing.Size(128, 20);
            this.tb_Avtor.TabIndex = 40;
            this.tb_Avtor.TextChanged += new System.EventHandler(this.tb_Avtor_TextChanged);
            // 
            // lbl3_Home_page
            // 
            this.lbl3_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3_Home_page.Location = new System.Drawing.Point(9, 184);
            this.lbl3_Home_page.Name = "lbl3_Home_page";
            this.lbl3_Home_page.Size = new System.Drawing.Size(242, 50);
            this.lbl3_Home_page.TabIndex = 39;
            this.lbl3_Home_page.Text = "Вывод в таблицу истории литературы:";
            this.lbl3_Home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_IssLit
            // 
            this.rb_IssLit.AutoSize = true;
            this.rb_IssLit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_IssLit.Location = new System.Drawing.Point(18, 162);
            this.rb_IssLit.Name = "rb_IssLit";
            this.rb_IssLit.Size = new System.Drawing.Size(84, 19);
            this.rb_IssLit.TabIndex = 37;
            this.rb_IssLit.TabStop = true;
            this.rb_IssLit.Text = "Выданной";
            this.rb_IssLit.UseVisualStyleBackColor = true;
            this.rb_IssLit.CheckedChanged += new System.EventHandler(this.ChangeSelected);
            // 
            // lbl2_Home_page
            // 
            this.lbl2_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2_Home_page.Location = new System.Drawing.Point(-1, 109);
            this.lbl2_Home_page.Name = "lbl2_Home_page";
            this.lbl2_Home_page.Size = new System.Drawing.Size(252, 50);
            this.lbl2_Home_page.TabIndex = 36;
            this.lbl2_Home_page.Text = "Вывод в таблицу литературы:";
            this.lbl2_Home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_Dolg
            // 
            this.rb_Dolg.AutoSize = true;
            this.rb_Dolg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Dolg.Location = new System.Drawing.Point(16, 87);
            this.rb_Dolg.Name = "rb_Dolg";
            this.rb_Dolg.Size = new System.Drawing.Size(91, 19);
            this.rb_Dolg.TabIndex = 34;
            this.rb_Dolg.TabStop = true;
            this.rb_Dolg.Text = "Должников";
            this.rb_Dolg.UseVisualStyleBackColor = true;
            this.rb_Dolg.CheckedChanged += new System.EventHandler(this.ChangeSelected);
            // 
            // lb1_Home_page
            // 
            this.lb1_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_Home_page.Location = new System.Drawing.Point(8, 34);
            this.lb1_Home_page.Name = "lb1_Home_page";
            this.lb1_Home_page.Size = new System.Drawing.Size(243, 50);
            this.lb1_Home_page.TabIndex = 33;
            this.lb1_Home_page.Text = "Вывод в таблицу читателей:";
            this.lb1_Home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Home_page
            // 
            this.dgv_Home_page.AllowUserToAddRows = false;
            this.dgv_Home_page.AllowUserToDeleteRows = false;
            this.dgv_Home_page.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Home_page.Location = new System.Drawing.Point(264, 34);
            this.dgv_Home_page.MultiSelect = false;
            this.dgv_Home_page.Name = "dgv_Home_page";
            this.dgv_Home_page.ReadOnly = true;
            this.dgv_Home_page.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Home_page.Size = new System.Drawing.Size(550, 359);
            this.dgv_Home_page.TabIndex = 30;
            // 
            // ms_Home_page
            // 
            this.ms_Home_page.AllowMerge = false;
            this.ms_Home_page.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Home_page.AutoSize = false;
            this.ms_Home_page.BackColor = System.Drawing.Color.Transparent;
            this.ms_Home_page.Dock = System.Windows.Forms.DockStyle.None;
            this.ms_Home_page.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ms_Home_page.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi1_Issuance,
            this.tsmi2_Library,
            this.tsmi3_Treiness,
            this.tsmi4_LiteratureTurnover,
            this.tsmi5_Accounting_book,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.tsmi6_Exit});
            this.ms_Home_page.Location = new System.Drawing.Point(0, 0);
            this.ms_Home_page.Name = "ms_Home_page";
            this.ms_Home_page.Size = new System.Drawing.Size(822, 38);
            this.ms_Home_page.TabIndex = 31;
            this.ms_Home_page.Text = "menuStrip1";
            // 
            // tsmi1_Issuance
            // 
            this.tsmi1_Issuance.Name = "tsmi1_Issuance";
            this.tsmi1_Issuance.Size = new System.Drawing.Size(76, 34);
            this.tsmi1_Issuance.Text = "Выдача";
            this.tsmi1_Issuance.Click += new System.EventHandler(this.tsmi1_Issuance_Click);
            // 
            // tsmi2_Library
            // 
            this.tsmi2_Library.Name = "tsmi2_Library";
            this.tsmi2_Library.Size = new System.Drawing.Size(106, 34);
            this.tsmi2_Library.Text = "Библиотека";
            this.tsmi2_Library.Click += new System.EventHandler(this.tsmi2_Library_Click);
            // 
            // tsmi3_Treiness
            // 
            this.tsmi3_Treiness.Name = "tsmi3_Treiness";
            this.tsmi3_Treiness.Size = new System.Drawing.Size(126, 34);
            this.tsmi3_Treiness.Text = "Обучающиеся";
            this.tsmi3_Treiness.Click += new System.EventHandler(this.tsmi3_Treiness_Click);
            // 
            // tsmi4_LiteratureTurnover
            // 
            this.tsmi4_LiteratureTurnover.Name = "tsmi4_LiteratureTurnover";
            this.tsmi4_LiteratureTurnover.Size = new System.Drawing.Size(184, 34);
            this.tsmi4_LiteratureTurnover.Text = "Списанная литература";
            this.tsmi4_LiteratureTurnover.Click += new System.EventHandler(this.tsmi4_LiteratureTurnover_Click);
            // 
            // tsmi5_Accounting_book
            // 
            this.tsmi5_Accounting_book.Name = "tsmi5_Accounting_book";
            this.tsmi5_Accounting_book.Size = new System.Drawing.Size(124, 34);
            this.tsmi5_Accounting_book.Text = "Учётная книга";
            this.tsmi5_Accounting_book.Click += new System.EventHandler(this.tsmi5_Accounting_book_Click);
            
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(62, 34);
            this.toolStripMenuItem2.Text = "          ";
            // 
            // tsmi6_Exit
            // 
            this.tsmi6_Exit.Name = "tsmi6_Exit";
            this.tsmi6_Exit.Size = new System.Drawing.Size(67, 34);
            this.tsmi6_Exit.Text = "Выход";
            this.tsmi6_Exit.Click += new System.EventHandler(this.tsmi6_Exit_Click);
            // 
            // rb_Chitatel
            // 
            this.rb_Chitatel.AutoSize = true;
            this.rb_Chitatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Chitatel.Location = new System.Drawing.Point(130, 87);
            this.rb_Chitatel.Name = "rb_Chitatel";
            this.rb_Chitatel.Size = new System.Drawing.Size(89, 19);
            this.rb_Chitatel.TabIndex = 49;
            this.rb_Chitatel.TabStop = true;
            this.rb_Chitatel.Text = "Читателей";
            this.rb_Chitatel.UseVisualStyleBackColor = true;
            this.rb_Chitatel.CheckedChanged += new System.EventHandler(this.ChangeSelected);
            // 
            // Home_pageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 408);
            this.Controls.Add(this.rb_Chitatel);
            this.Controls.Add(this.lbl8_Home_page);
            this.Controls.Add(this.tb_Nam);
            this.Controls.Add(this.lbl7_Home_page);
            this.Controls.Add(this.tb_Fam);
            this.Controls.Add(this.lbl6_Home_page);
            this.Controls.Add(this.lbl5_Home_page);
            this.Controls.Add(this.tb_NameBook);
            this.Controls.Add(this.lb4_Home_page);
            this.Controls.Add(this.tb_Avtor);
            this.Controls.Add(this.lbl3_Home_page);
            this.Controls.Add(this.rb_IssLit);
            this.Controls.Add(this.lbl2_Home_page);
            this.Controls.Add(this.rb_Dolg);
            this.Controls.Add(this.lb1_Home_page);
            this.Controls.Add(this.dgv_Home_page);
            this.Controls.Add(this.ms_Home_page);
            this.Name = "Home_pageForm";
            this.Text = "Главная страница";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home_page)).EndInit();
            this.ms_Home_page.ResumeLayout(false);
            this.ms_Home_page.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl8_Home_page;
        private System.Windows.Forms.TextBox tb_Nam;
        private System.Windows.Forms.Label lbl7_Home_page;
        private System.Windows.Forms.TextBox tb_Fam;
        private System.Windows.Forms.Label lbl6_Home_page;
        private System.Windows.Forms.Label lbl5_Home_page;
        private System.Windows.Forms.TextBox tb_NameBook;
        private System.Windows.Forms.Label lb4_Home_page;
        private System.Windows.Forms.TextBox tb_Avtor;
        private System.Windows.Forms.Label lbl3_Home_page;
        private System.Windows.Forms.RadioButton rb_IssLit;
        private System.Windows.Forms.Label lbl2_Home_page;
        private System.Windows.Forms.RadioButton rb_Dolg;
        private System.Windows.Forms.Label lb1_Home_page;
        private System.Windows.Forms.DataGridView dgv_Home_page;
        private System.Windows.Forms.MenuStrip ms_Home_page;
        private System.Windows.Forms.ToolStripMenuItem tsmi1_Issuance;
        private System.Windows.Forms.ToolStripMenuItem tsmi2_Library;
        private System.Windows.Forms.ToolStripMenuItem tsmi3_Treiness;
        private System.Windows.Forms.ToolStripMenuItem tsmi4_LiteratureTurnover;
        private System.Windows.Forms.ToolStripMenuItem tsmi5_Accounting_book;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmi6_Exit;
        private System.Windows.Forms.RadioButton rb_Chitatel;
    }
}