
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPurchaseForm));
            this.Ok_AddPurchase = new System.Windows.Forms.Button();
            this.lb1_AddPurchase = new System.Windows.Forms.Label();
            this.lb4_AddPurchase = new System.Windows.Forms.Label();
            this.lb3_AddPurchase = new System.Windows.Forms.Label();
            this.tb_PricePurchase = new System.Windows.Forms.TextBox();
            this.tb_CountPurchase = new System.Windows.Forms.TextBox();
            this.cb_BookPurchase = new System.Windows.Forms.ComboBox();
            this.cb_NotBook = new System.Windows.Forms.CheckBox();
            this.bt_PlusBookListPurchase = new System.Windows.Forms.Button();
            this.bt_MinusBookListPurchase = new System.Windows.Forms.Button();
            this.lb2_AddPurchase = new System.Windows.Forms.Label();
            this.dgv_PurchaseList = new System.Windows.Forms.DataGridView();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_datePurchase = new System.Windows.Forms.DateTimePicker();
            this.lb5_AddPurchase = new System.Windows.Forms.Label();
            this.dgv_ResultPurchaseList = new System.Windows.Forms.DataGridView();
            this.ResultCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb6_AddPurchase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultPurchaseList)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok_AddPurchase
            // 
            this.Ok_AddPurchase.BackColor = System.Drawing.Color.Transparent;
            this.Ok_AddPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_AddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_AddPurchase.Location = new System.Drawing.Point(285, 380);
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
            this.lb1_AddPurchase.Size = new System.Drawing.Size(408, 51);
            this.lb1_AddPurchase.TabIndex = 83;
            this.lb1_AddPurchase.Text = "Пожалуйста, введите данные о закупке.";
            this.lb1_AddPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4_AddPurchase
            // 
            this.lb4_AddPurchase.AutoSize = true;
            this.lb4_AddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_AddPurchase.Location = new System.Drawing.Point(165, 133);
            this.lb4_AddPurchase.Name = "lb4_AddPurchase";
            this.lb4_AddPurchase.Size = new System.Drawing.Size(104, 20);
            this.lb4_AddPurchase.TabIndex = 84;
            this.lb4_AddPurchase.Text = "Количество:";
            // 
            // lb3_AddPurchase
            // 
            this.lb3_AddPurchase.AutoSize = true;
            this.lb3_AddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_AddPurchase.Location = new System.Drawing.Point(12, 133);
            this.lb3_AddPurchase.Name = "lb3_AddPurchase";
            this.lb3_AddPurchase.Size = new System.Drawing.Size(52, 20);
            this.lb3_AddPurchase.TabIndex = 86;
            this.lb3_AddPurchase.Text = "Цена:";
            // 
            // tb_PricePurchase
            // 
            this.tb_PricePurchase.Location = new System.Drawing.Point(70, 133);
            this.tb_PricePurchase.Name = "tb_PricePurchase";
            this.tb_PricePurchase.Size = new System.Drawing.Size(89, 20);
            this.tb_PricePurchase.TabIndex = 87;
            // 
            // tb_CountPurchase
            // 
            this.tb_CountPurchase.Location = new System.Drawing.Point(275, 133);
            this.tb_CountPurchase.Name = "tb_CountPurchase";
            this.tb_CountPurchase.Size = new System.Drawing.Size(89, 20);
            this.tb_CountPurchase.TabIndex = 88;
            // 
            // cb_BookPurchase
            // 
            this.cb_BookPurchase.FormattingEnabled = true;
            this.cb_BookPurchase.Location = new System.Drawing.Point(16, 84);
            this.cb_BookPurchase.Name = "cb_BookPurchase";
            this.cb_BookPurchase.Size = new System.Drawing.Size(352, 21);
            this.cb_BookPurchase.TabIndex = 89;
            // 
            // cb_NotBook
            // 
            this.cb_NotBook.AutoSize = true;
            this.cb_NotBook.Location = new System.Drawing.Point(16, 110);
            this.cb_NotBook.Name = "cb_NotBook";
            this.cb_NotBook.Size = new System.Drawing.Size(260, 17);
            this.cb_NotBook.TabIndex = 90;
            this.cb_NotBook.Text = "Данная литература закупается в первый раз.";
            this.cb_NotBook.UseVisualStyleBackColor = true;
            this.cb_NotBook.CheckedChanged += new System.EventHandler(this.cb_NotBook_CheckedChanged);
            // 
            // bt_PlusBookListPurchase
            // 
            this.bt_PlusBookListPurchase.BackColor = System.Drawing.Color.Transparent;
            this.bt_PlusBookListPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_PlusBookListPurchase.BackgroundImage")));
            this.bt_PlusBookListPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_PlusBookListPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_PlusBookListPurchase.Location = new System.Drawing.Point(370, 133);
            this.bt_PlusBookListPurchase.Name = "bt_PlusBookListPurchase";
            this.bt_PlusBookListPurchase.Size = new System.Drawing.Size(22, 21);
            this.bt_PlusBookListPurchase.TabIndex = 91;
            this.bt_PlusBookListPurchase.UseVisualStyleBackColor = false;
            this.bt_PlusBookListPurchase.Click += new System.EventHandler(this.bt_PlusBookListPurchase_Click);
            // 
            // bt_MinusBookListPurchase
            // 
            this.bt_MinusBookListPurchase.BackColor = System.Drawing.Color.Transparent;
            this.bt_MinusBookListPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_MinusBookListPurchase.BackgroundImage")));
            this.bt_MinusBookListPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_MinusBookListPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_MinusBookListPurchase.Location = new System.Drawing.Point(398, 134);
            this.bt_MinusBookListPurchase.Name = "bt_MinusBookListPurchase";
            this.bt_MinusBookListPurchase.Size = new System.Drawing.Size(22, 21);
            this.bt_MinusBookListPurchase.TabIndex = 92;
            this.bt_MinusBookListPurchase.UseVisualStyleBackColor = false;
            this.bt_MinusBookListPurchase.Click += new System.EventHandler(this.bt_MinusBookListPurchase_Click);
            // 
            // lb2_AddPurchase
            // 
            this.lb2_AddPurchase.AutoSize = true;
            this.lb2_AddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2_AddPurchase.Location = new System.Drawing.Point(12, 60);
            this.lb2_AddPurchase.Name = "lb2_AddPurchase";
            this.lb2_AddPurchase.Size = new System.Drawing.Size(104, 20);
            this.lb2_AddPurchase.TabIndex = 93;
            this.lb2_AddPurchase.Text = "Литература:";
            // 
            // dgv_PurchaseList
            // 
            this.dgv_PurchaseList.AllowUserToAddRows = false;
            this.dgv_PurchaseList.AllowUserToDeleteRows = false;
            this.dgv_PurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book,
            this.Count,
            this.Price,
            this.Cost});
            this.dgv_PurchaseList.Location = new System.Drawing.Point(16, 161);
            this.dgv_PurchaseList.Name = "dgv_PurchaseList";
            this.dgv_PurchaseList.ReadOnly = true;
            this.dgv_PurchaseList.RowHeadersVisible = false;
            this.dgv_PurchaseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PurchaseList.Size = new System.Drawing.Size(408, 150);
            this.dgv_PurchaseList.TabIndex = 94;
            // 
            // Book
            // 
            this.Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book.FillWeight = 150F;
            this.Book.HeaderText = "Литература";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.FillWeight = 50F;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.FillWeight = 30F;
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cost.FillWeight = 50F;
            this.Cost.HeaderText = "Стоимость";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // dtp_datePurchase
            // 
            this.dtp_datePurchase.Location = new System.Drawing.Point(132, 388);
            this.dtp_datePurchase.Name = "dtp_datePurchase";
            this.dtp_datePurchase.Size = new System.Drawing.Size(144, 20);
            this.dtp_datePurchase.TabIndex = 95;
            // 
            // lb5_AddPurchase
            // 
            this.lb5_AddPurchase.AutoSize = true;
            this.lb5_AddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5_AddPurchase.Location = new System.Drawing.Point(12, 389);
            this.lb5_AddPurchase.Name = "lb5_AddPurchase";
            this.lb5_AddPurchase.Size = new System.Drawing.Size(114, 20);
            this.lb5_AddPurchase.TabIndex = 96;
            this.lb5_AddPurchase.Text = "Дата закупки:";
            // 
            // dgv_ResultPurchaseList
            // 
            this.dgv_ResultPurchaseList.AllowUserToAddRows = false;
            this.dgv_ResultPurchaseList.AllowUserToDeleteRows = false;
            this.dgv_ResultPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ResultPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResultCount,
            this.ResultCost});
            this.dgv_ResultPurchaseList.Location = new System.Drawing.Point(185, 318);
            this.dgv_ResultPurchaseList.Name = "dgv_ResultPurchaseList";
            this.dgv_ResultPurchaseList.ReadOnly = true;
            this.dgv_ResultPurchaseList.RowHeadersVisible = false;
            this.dgv_ResultPurchaseList.Size = new System.Drawing.Size(239, 56);
            this.dgv_ResultPurchaseList.TabIndex = 97;
            // 
            // ResultCount
            // 
            this.ResultCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ResultCount.HeaderText = "Общее количество";
            this.ResultCount.Name = "ResultCount";
            this.ResultCount.ReadOnly = true;
            // 
            // ResultCost
            // 
            this.ResultCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ResultCost.HeaderText = "Общая стоимость";
            this.ResultCost.Name = "ResultCost";
            this.ResultCost.ReadOnly = true;
            // 
            // lb6_AddPurchase
            // 
            this.lb6_AddPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb6_AddPurchase.Location = new System.Drawing.Point(12, 317);
            this.lb6_AddPurchase.Name = "lb6_AddPurchase";
            this.lb6_AddPurchase.Size = new System.Drawing.Size(163, 56);
            this.lb6_AddPurchase.TabIndex = 98;
            this.lb6_AddPurchase.Text = "Общая информация о закупке";
            // 
            // AddPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 465);
            this.Controls.Add(this.lb6_AddPurchase);
            this.Controls.Add(this.dgv_ResultPurchaseList);
            this.Controls.Add(this.lb5_AddPurchase);
            this.Controls.Add(this.dtp_datePurchase);
            this.Controls.Add(this.dgv_PurchaseList);
            this.Controls.Add(this.lb2_AddPurchase);
            this.Controls.Add(this.bt_MinusBookListPurchase);
            this.Controls.Add(this.bt_PlusBookListPurchase);
            this.Controls.Add(this.cb_NotBook);
            this.Controls.Add(this.cb_BookPurchase);
            this.Controls.Add(this.tb_CountPurchase);
            this.Controls.Add(this.tb_PricePurchase);
            this.Controls.Add(this.lb3_AddPurchase);
            this.Controls.Add(this.lb4_AddPurchase);
            this.Controls.Add(this.lb1_AddPurchase);
            this.Controls.Add(this.Ok_AddPurchase);
            this.Name = "AddPurchaseForm";
            this.Text = "Закупка";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultPurchaseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_AddPurchase;
        private System.Windows.Forms.Label lb1_AddPurchase;
        private System.Windows.Forms.Label lb4_AddPurchase;
        private System.Windows.Forms.Label lb3_AddPurchase;
        private System.Windows.Forms.TextBox tb_PricePurchase;
        private System.Windows.Forms.TextBox tb_CountPurchase;
        private System.Windows.Forms.ComboBox cb_BookPurchase;
        private System.Windows.Forms.CheckBox cb_NotBook;
        private System.Windows.Forms.Button bt_PlusBookListPurchase;
        private System.Windows.Forms.Button bt_MinusBookListPurchase;
        private System.Windows.Forms.Label lb2_AddPurchase;
        private System.Windows.Forms.DataGridView dgv_PurchaseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DateTimePicker dtp_datePurchase;
        private System.Windows.Forms.Label lb5_AddPurchase;
        private System.Windows.Forms.DataGridView dgv_ResultPurchaseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultCost;
        private System.Windows.Forms.Label lb6_AddPurchase;
    }
}