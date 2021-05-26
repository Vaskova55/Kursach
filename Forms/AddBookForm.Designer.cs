
namespace Biblioteka2.Forms
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.Ok_AddBook = new System.Windows.Forms.Button();
            this.bt_add_autor = new System.Windows.Forms.Button();
            this.lb_author = new System.Windows.Forms.ListBox();
            this.cb_Author = new System.Windows.Forms.ComboBox();
            this.cb_publisher = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.NUD_Year = new System.Windows.Forms.NumericUpDown();
            this.NUD_Class = new System.Windows.Forms.NumericUpDown();
            this.tb_bookname = new System.Windows.Forms.TextBox();
            this.lb2_AddTrainess = new System.Windows.Forms.Label();
            this.lb1_AddTrainess = new System.Windows.Forms.Label();
            this.lb3_AddTrainess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_NoAvtor = new System.Windows.Forms.CheckBox();
            this.cb_NoUchLit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Class)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok_AddBook
            // 
            this.Ok_AddBook.BackColor = System.Drawing.Color.Transparent;
            this.Ok_AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_AddBook.Location = new System.Drawing.Point(51, 548);
            this.Ok_AddBook.Name = "Ok_AddBook";
            this.Ok_AddBook.Size = new System.Drawing.Size(128, 36);
            this.Ok_AddBook.TabIndex = 51;
            this.Ok_AddBook.Text = "Добавить";
            this.Ok_AddBook.UseVisualStyleBackColor = false;
            this.Ok_AddBook.Click += new System.EventHandler(this.Ok_AddBook_Click);
            // 
            // bt_add_autor
            // 
            this.bt_add_autor.BackColor = System.Drawing.Color.Transparent;
            this.bt_add_autor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_add_autor.BackgroundImage")));
            this.bt_add_autor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_add_autor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add_autor.Location = new System.Drawing.Point(194, 418);
            this.bt_add_autor.Name = "bt_add_autor";
            this.bt_add_autor.Size = new System.Drawing.Size(26, 21);
            this.bt_add_autor.TabIndex = 50;
            this.bt_add_autor.UseVisualStyleBackColor = false;
            this.bt_add_autor.Click += new System.EventHandler(this.bt_add_autor_Click);
            // 
            // lb_author
            // 
            this.lb_author.FormattingEnabled = true;
            this.lb_author.Location = new System.Drawing.Point(44, 484);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(146, 56);
            this.lb_author.TabIndex = 49;
            // 
            // cb_Author
            // 
            this.cb_Author.FormattingEnabled = true;
            this.cb_Author.Location = new System.Drawing.Point(42, 419);
            this.cb_Author.Name = "cb_Author";
            this.cb_Author.Size = new System.Drawing.Size(146, 21);
            this.cb_Author.TabIndex = 48;
            // 
            // cb_publisher
            // 
            this.cb_publisher.FormattingEnabled = true;
            this.cb_publisher.Location = new System.Drawing.Point(42, 372);
            this.cb_publisher.Name = "cb_publisher";
            this.cb_publisher.Size = new System.Drawing.Size(146, 21);
            this.cb_publisher.TabIndex = 47;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(44, 325);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(146, 21);
            this.cb_type.TabIndex = 46;
            // 
            // NUD_Year
            // 
            this.NUD_Year.Location = new System.Drawing.Point(42, 279);
            this.NUD_Year.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NUD_Year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.NUD_Year.Name = "NUD_Year";
            this.NUD_Year.Size = new System.Drawing.Size(146, 20);
            this.NUD_Year.TabIndex = 45;
            this.NUD_Year.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // NUD_Class
            // 
            this.NUD_Class.Location = new System.Drawing.Point(42, 164);
            this.NUD_Class.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NUD_Class.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Class.Name = "NUD_Class";
            this.NUD_Class.Size = new System.Drawing.Size(146, 20);
            this.NUD_Class.TabIndex = 44;
            this.NUD_Class.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_bookname
            // 
            this.tb_bookname.Location = new System.Drawing.Point(42, 233);
            this.tb_bookname.Name = "tb_bookname";
            this.tb_bookname.Size = new System.Drawing.Size(146, 20);
            this.tb_bookname.TabIndex = 43;
            // 
            // lb2_AddTrainess
            // 
            this.lb2_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_AddTrainess.Location = new System.Drawing.Point(12, 59);
            this.lb2_AddTrainess.Name = "lb2_AddTrainess";
            this.lb2_AddTrainess.Size = new System.Drawing.Size(205, 82);
            this.lb2_AddTrainess.TabIndex = 53;
            this.lb2_AddTrainess.Text = "Пожалуйста, введите данные для добавления.";
            this.lb2_AddTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1_AddTrainess
            // 
            this.lb1_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_AddTrainess.Location = new System.Drawing.Point(12, 9);
            this.lb1_AddTrainess.Name = "lb1_AddTrainess";
            this.lb1_AddTrainess.Size = new System.Drawing.Size(205, 50);
            this.lb1_AddTrainess.TabIndex = 52;
            this.lb1_AddTrainess.Text = "Новый данные.";
            this.lb1_AddTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3_AddTrainess
            // 
            this.lb3_AddTrainess.AutoSize = true;
            this.lb3_AddTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_AddTrainess.Location = new System.Drawing.Point(38, 141);
            this.lb3_AddTrainess.Name = "lb3_AddTrainess";
            this.lb3_AddTrainess.Size = new System.Drawing.Size(58, 20);
            this.lb3_AddTrainess.TabIndex = 54;
            this.lb3_AddTrainess.Text = "Класс:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Год издания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Тип:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Издатель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(38, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Автор:";
            // 
            // cb_NoAvtor
            // 
            this.cb_NoAvtor.ForeColor = System.Drawing.Color.Black;
            this.cb_NoAvtor.Location = new System.Drawing.Point(42, 446);
            this.cb_NoAvtor.Name = "cb_NoAvtor";
            this.cb_NoAvtor.Size = new System.Drawing.Size(146, 32);
            this.cb_NoAvtor.TabIndex = 71;
            this.cb_NoAvtor.Text = "Необходимый автор отсутствует в списке.";
            this.cb_NoAvtor.UseVisualStyleBackColor = true;
            // 
            // cb_NoUchLit
            // 
            this.cb_NoUchLit.AutoSize = true;
            this.cb_NoUchLit.Location = new System.Drawing.Point(42, 190);
            this.cb_NoUchLit.Name = "cb_NoUchLit";
            this.cb_NoUchLit.Size = new System.Drawing.Size(143, 17);
            this.cb_NoUchLit.TabIndex = 72;
            this.cb_NoUchLit.Text = "Не учебная литература";
            this.cb_NoUchLit.UseVisualStyleBackColor = true;
            this.cb_NoUchLit.CheckedChanged += new System.EventHandler(this.cb_NoAvtor_CheckedChanged);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(228, 597);
            this.Controls.Add(this.cb_NoUchLit);
            this.Controls.Add(this.cb_NoAvtor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb3_AddTrainess);
            this.Controls.Add(this.lb2_AddTrainess);
            this.Controls.Add(this.lb1_AddTrainess);
            this.Controls.Add(this.Ok_AddBook);
            this.Controls.Add(this.bt_add_autor);
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.cb_Author);
            this.Controls.Add(this.cb_publisher);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.NUD_Year);
            this.Controls.Add(this.NUD_Class);
            this.Controls.Add(this.tb_bookname);
            this.Name = "AddBookForm";
            this.Text = "Новые данные";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_AddBook;
        private System.Windows.Forms.Button bt_add_autor;
        private System.Windows.Forms.ListBox lb_author;
        private System.Windows.Forms.ComboBox cb_Author;
        private System.Windows.Forms.ComboBox cb_publisher;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.NumericUpDown NUD_Year;
        private System.Windows.Forms.NumericUpDown NUD_Class;
        private System.Windows.Forms.TextBox tb_bookname;
        private System.Windows.Forms.Label lb2_AddTrainess;
        private System.Windows.Forms.Label lb1_AddTrainess;
        private System.Windows.Forms.Label lb3_AddTrainess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_NoAvtor;
        private System.Windows.Forms.CheckBox cb_NoUchLit;
    }
}