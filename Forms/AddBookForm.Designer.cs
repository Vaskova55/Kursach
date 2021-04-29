
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
            this.bt_addtype = new System.Windows.Forms.Button();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_publisher_city = new System.Windows.Forms.TextBox();
            this.tb_publisher_name = new System.Windows.Forms.TextBox();
            this.bt_add_publisher = new System.Windows.Forms.Button();
            this.tb_bookname = new System.Windows.Forms.TextBox();
            this.NUD_Class = new System.Windows.Forms.NumericUpDown();
            this.NUD_Year = new System.Windows.Forms.NumericUpDown();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_publisher = new System.Windows.Forms.ComboBox();
            this.bt_book = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_Autor = new System.Windows.Forms.Button();
            this.tb_midlename = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.cb_Author = new System.Windows.Forms.ComboBox();
            this.lb_author = new System.Windows.Forms.ListBox();
            this.bt_add_autor = new System.Windows.Forms.Button();
            this.BookNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPublicsherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookYearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_addtype
            // 
            this.bt_addtype.Location = new System.Drawing.Point(478, 52);
            this.bt_addtype.Name = "bt_addtype";
            this.bt_addtype.Size = new System.Drawing.Size(100, 23);
            this.bt_addtype.TabIndex = 0;
            this.bt_addtype.Text = "button1";
            this.bt_addtype.UseVisualStyleBackColor = true;
            this.bt_addtype.Click += new System.EventHandler(this.bt_addtype_Click);
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(478, 15);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(100, 20);
            this.tb_type.TabIndex = 1;
            // 
            // tb_publisher_city
            // 
            this.tb_publisher_city.Location = new System.Drawing.Point(306, 15);
            this.tb_publisher_city.Name = "tb_publisher_city";
            this.tb_publisher_city.Size = new System.Drawing.Size(100, 20);
            this.tb_publisher_city.TabIndex = 2;
            // 
            // tb_publisher_name
            // 
            this.tb_publisher_name.Location = new System.Drawing.Point(306, 52);
            this.tb_publisher_name.Name = "tb_publisher_name";
            this.tb_publisher_name.Size = new System.Drawing.Size(100, 20);
            this.tb_publisher_name.TabIndex = 3;
            // 
            // bt_add_publisher
            // 
            this.bt_add_publisher.Location = new System.Drawing.Point(306, 87);
            this.bt_add_publisher.Name = "bt_add_publisher";
            this.bt_add_publisher.Size = new System.Drawing.Size(100, 23);
            this.bt_add_publisher.TabIndex = 4;
            this.bt_add_publisher.Text = "button1";
            this.bt_add_publisher.UseVisualStyleBackColor = true;
            this.bt_add_publisher.Click += new System.EventHandler(this.bt_add_publisher_Click);
            // 
            // tb_bookname
            // 
            this.tb_bookname.Location = new System.Drawing.Point(161, 15);
            this.tb_bookname.Name = "tb_bookname";
            this.tb_bookname.Size = new System.Drawing.Size(100, 20);
            this.tb_bookname.TabIndex = 5;
            // 
            // NUD_Class
            // 
            this.NUD_Class.Location = new System.Drawing.Point(161, 41);
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
            this.NUD_Class.Size = new System.Drawing.Size(100, 20);
            this.NUD_Class.TabIndex = 6;
            this.NUD_Class.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUD_Year
            // 
            this.NUD_Year.Location = new System.Drawing.Point(161, 67);
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
            this.NUD_Year.Size = new System.Drawing.Size(100, 20);
            this.NUD_Year.TabIndex = 7;
            this.NUD_Year.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(161, 93);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(100, 21);
            this.cb_type.TabIndex = 8;
            // 
            // cb_publisher
            // 
            this.cb_publisher.FormattingEnabled = true;
            this.cb_publisher.Location = new System.Drawing.Point(161, 120);
            this.cb_publisher.Name = "cb_publisher";
            this.cb_publisher.Size = new System.Drawing.Size(100, 21);
            this.cb_publisher.TabIndex = 9;
            // 
            // bt_book
            // 
            this.bt_book.Location = new System.Drawing.Point(173, 282);
            this.bt_book.Name = "bt_book";
            this.bt_book.Size = new System.Drawing.Size(100, 23);
            this.bt_book.TabIndex = 10;
            this.bt_book.Text = "button1";
            this.bt_book.UseVisualStyleBackColor = true;
            this.bt_book.Click += new System.EventHandler(this.bt_book_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(18, 15);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(75, 23);
            this.bt_refresh.TabIndex = 11;
            this.bt_refresh.Text = "button1";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // dgv_books
            // 
            this.dgv_books.AllowUserToAddRows = false;
            this.dgv_books.AllowUserToDeleteRows = false;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookNameColumn,
            this.AuthorColumn,
            this.BookPublicsherColumn,
            this.BookTypeColumn,
            this.BookYearColumn,
            this.ClassColumn});
            this.dgv_books.Location = new System.Drawing.Point(18, 328);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.ReadOnly = true;
            this.dgv_books.Size = new System.Drawing.Size(719, 216);
            this.dgv_books.TabIndex = 12;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(656, 193);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 13;
            this.bt_update.Text = "button1";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_Autor
            // 
            this.bt_Autor.Location = new System.Drawing.Point(646, 135);
            this.bt_Autor.Name = "bt_Autor";
            this.bt_Autor.Size = new System.Drawing.Size(85, 23);
            this.bt_Autor.TabIndex = 14;
            this.bt_Autor.Text = "button1";
            this.bt_Autor.UseVisualStyleBackColor = true;
            this.bt_Autor.Click += new System.EventHandler(this.bt_Autor_Click);
            // 
            // tb_midlename
            // 
            this.tb_midlename.Location = new System.Drawing.Point(646, 109);
            this.tb_midlename.Name = "tb_midlename";
            this.tb_midlename.Size = new System.Drawing.Size(85, 20);
            this.tb_midlename.TabIndex = 15;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(646, 83);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(85, 20);
            this.tb_lastname.TabIndex = 16;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(646, 57);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(85, 20);
            this.tb_firstname.TabIndex = 17;
            // 
            // cb_Author
            // 
            this.cb_Author.FormattingEnabled = true;
            this.cb_Author.Location = new System.Drawing.Point(161, 147);
            this.cb_Author.Name = "cb_Author";
            this.cb_Author.Size = new System.Drawing.Size(100, 21);
            this.cb_Author.TabIndex = 18;
            // 
            // lb_author
            // 
            this.lb_author.FormattingEnabled = true;
            this.lb_author.Location = new System.Drawing.Point(161, 181);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(146, 95);
            this.lb_author.TabIndex = 19;
            // 
            // bt_add_autor
            // 
            this.bt_add_autor.Location = new System.Drawing.Point(268, 145);
            this.bt_add_autor.Name = "bt_add_autor";
            this.bt_add_autor.Size = new System.Drawing.Size(39, 23);
            this.bt_add_autor.TabIndex = 21;
            this.bt_add_autor.Text = "+";
            this.bt_add_autor.UseVisualStyleBackColor = true;
            this.bt_add_autor.Click += new System.EventHandler(this.bt_add_autor_Click);
            // 
            // BookNameColumn
            // 
            this.BookNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookNameColumn.HeaderText = "Название книги";
            this.BookNameColumn.Name = "BookNameColumn";
            this.BookNameColumn.ReadOnly = true;
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.HeaderText = "Авторы";
            this.AuthorColumn.Name = "AuthorColumn";
            this.AuthorColumn.ReadOnly = true;
            // 
            // BookPublicsherColumn
            // 
            this.BookPublicsherColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPublicsherColumn.HeaderText = "Издатель";
            this.BookPublicsherColumn.Name = "BookPublicsherColumn";
            this.BookPublicsherColumn.ReadOnly = true;
            // 
            // BookTypeColumn
            // 
            this.BookTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTypeColumn.HeaderText = "Тип книги";
            this.BookTypeColumn.Name = "BookTypeColumn";
            this.BookTypeColumn.ReadOnly = true;
            // 
            // BookYearColumn
            // 
            this.BookYearColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookYearColumn.HeaderText = "Год издания";
            this.BookYearColumn.Name = "BookYearColumn";
            this.BookYearColumn.ReadOnly = true;
            // 
            // ClassColumn
            // 
            this.ClassColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassColumn.HeaderText = "Класс";
            this.ClassColumn.Name = "ClassColumn";
            this.ClassColumn.ReadOnly = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.bt_add_autor);
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.cb_Author);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_midlename);
            this.Controls.Add(this.bt_Autor);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.bt_book);
            this.Controls.Add(this.cb_publisher);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.NUD_Year);
            this.Controls.Add(this.NUD_Class);
            this.Controls.Add(this.tb_bookname);
            this.Controls.Add(this.bt_add_publisher);
            this.Controls.Add(this.tb_publisher_name);
            this.Controls.Add(this.tb_publisher_city);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.bt_addtype);
            this.Name = "TestForm";
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_addtype;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_publisher_city;
        private System.Windows.Forms.TextBox tb_publisher_name;
        private System.Windows.Forms.Button bt_add_publisher;
        private System.Windows.Forms.TextBox tb_bookname;
        private System.Windows.Forms.NumericUpDown NUD_Class;
        private System.Windows.Forms.NumericUpDown NUD_Year;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox cb_publisher;
        private System.Windows.Forms.Button bt_book;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_Autor;
        private System.Windows.Forms.TextBox tb_midlename;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.ComboBox cb_Author;
        private System.Windows.Forms.ListBox lb_author;
        private System.Windows.Forms.Button bt_add_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPublicsherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookYearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassColumn;
    }
}