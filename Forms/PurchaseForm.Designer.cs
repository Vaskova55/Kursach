
namespace Biblioteka2.Forms
{
    partial class PurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.bt_import_Purchase = new System.Windows.Forms.Button();
            this.Export_Purchase = new System.Windows.Forms.Button();
            this.lb1_SearchPurchase = new System.Windows.Forms.Label();
            this.tb_SearchPurchase = new System.Windows.Forms.TextBox();
            this.Update_Purchase = new System.Windows.Forms.Button();
            this.Delete_Purchase = new System.Windows.Forms.Button();
            this.Edit_Purchase = new System.Windows.Forms.Button();
            this.Add_Purchase = new System.Windows.Forms.Button();
            this.dgv_Purchase = new System.Windows.Forms.DataGridView();
            this.ClassNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_import_Purchase
            // 
            this.bt_import_Purchase.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_import_Purchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_import_Purchase.BackgroundImage")));
            this.bt_import_Purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_import_Purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_import_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_import_Purchase.Location = new System.Drawing.Point(315, 26);
            this.bt_import_Purchase.Name = "bt_import_Purchase";
            this.bt_import_Purchase.Size = new System.Drawing.Size(46, 43);
            this.bt_import_Purchase.TabIndex = 49;
            this.bt_import_Purchase.UseVisualStyleBackColor = false;
            // 
            // Export_Purchase
            // 
            this.Export_Purchase.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Export_Purchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export_Purchase.BackgroundImage")));
            this.Export_Purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export_Purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export_Purchase.Location = new System.Drawing.Point(263, 26);
            this.Export_Purchase.Name = "Export_Purchase";
            this.Export_Purchase.Size = new System.Drawing.Size(46, 43);
            this.Export_Purchase.TabIndex = 48;
            this.Export_Purchase.UseVisualStyleBackColor = false;
            // 
            // lb1_SearchPurchase
            // 
            this.lb1_SearchPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_SearchPurchase.Location = new System.Drawing.Point(367, 19);
            this.lb1_SearchPurchase.Name = "lb1_SearchPurchase";
            this.lb1_SearchPurchase.Size = new System.Drawing.Size(151, 27);
            this.lb1_SearchPurchase.TabIndex = 47;
            this.lb1_SearchPurchase.Text = "Поиск данных.";
            this.lb1_SearchPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_SearchPurchase
            // 
            this.tb_SearchPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_SearchPurchase.Location = new System.Drawing.Point(367, 49);
            this.tb_SearchPurchase.Name = "tb_SearchPurchase";
            this.tb_SearchPurchase.Size = new System.Drawing.Size(147, 20);
            this.tb_SearchPurchase.TabIndex = 46;
            // 
            // Update_Purchase
            // 
            this.Update_Purchase.BackColor = System.Drawing.Color.Transparent;
            this.Update_Purchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_Purchase.BackgroundImage")));
            this.Update_Purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_Purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Purchase.Location = new System.Drawing.Point(55, 26);
            this.Update_Purchase.Name = "Update_Purchase";
            this.Update_Purchase.Size = new System.Drawing.Size(46, 43);
            this.Update_Purchase.TabIndex = 45;
            this.Update_Purchase.UseVisualStyleBackColor = false;
            // 
            // Delete_Purchase
            // 
            this.Delete_Purchase.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete_Purchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_Purchase.BackgroundImage")));
            this.Delete_Purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_Purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Purchase.Location = new System.Drawing.Point(211, 26);
            this.Delete_Purchase.Name = "Delete_Purchase";
            this.Delete_Purchase.Size = new System.Drawing.Size(46, 43);
            this.Delete_Purchase.TabIndex = 44;
            this.Delete_Purchase.UseVisualStyleBackColor = false;
            // 
            // Edit_Purchase
            // 
            this.Edit_Purchase.BackColor = System.Drawing.Color.Transparent;
            this.Edit_Purchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_Purchase.BackgroundImage")));
            this.Edit_Purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Edit_Purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_Purchase.Location = new System.Drawing.Point(159, 26);
            this.Edit_Purchase.Name = "Edit_Purchase";
            this.Edit_Purchase.Size = new System.Drawing.Size(46, 43);
            this.Edit_Purchase.TabIndex = 43;
            this.Edit_Purchase.UseVisualStyleBackColor = false;
            // 
            // Add_Purchase
            // 
            this.Add_Purchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Purchase.BackgroundImage")));
            this.Add_Purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Purchase.Location = new System.Drawing.Point(107, 26);
            this.Add_Purchase.Name = "Add_Purchase";
            this.Add_Purchase.Size = new System.Drawing.Size(46, 43);
            this.Add_Purchase.TabIndex = 42;
            this.Add_Purchase.UseVisualStyleBackColor = true;
            // 
            // dgv_Purchase
            // 
            this.dgv_Purchase.AllowUserToAddRows = false;
            this.dgv_Purchase.AllowUserToDeleteRows = false;
            this.dgv_Purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassNum,
            this.Name_Book,
            this.Publisher,
            this.Price,
            this.Count,
            this.PricePurchase});
            this.dgv_Purchase.Location = new System.Drawing.Point(12, 95);
            this.dgv_Purchase.MultiSelect = false;
            this.dgv_Purchase.Name = "dgv_Purchase";
            this.dgv_Purchase.ReadOnly = true;
            this.dgv_Purchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Purchase.Size = new System.Drawing.Size(577, 262);
            this.dgv_Purchase.TabIndex = 41;
            // 
            // ClassNum
            // 
            this.ClassNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassNum.HeaderText = "Класс";
            this.ClassNum.Name = "ClassNum";
            this.ClassNum.ReadOnly = true;
            this.ClassNum.Width = 63;
            // 
            // Name_Book
            // 
            this.Name_Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_Book.HeaderText = "Название";
            this.Name_Book.Name = "Name_Book";
            this.Name_Book.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Издательство";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 58;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 91;
            // 
            // PricePurchase
            // 
            this.PricePurchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PricePurchase.HeaderText = "Стоимость";
            this.PricePurchase.Name = "PricePurchase";
            this.PricePurchase.ReadOnly = true;
            this.PricePurchase.Width = 87;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 369);
            this.Controls.Add(this.bt_import_Purchase);
            this.Controls.Add(this.Export_Purchase);
            this.Controls.Add(this.lb1_SearchPurchase);
            this.Controls.Add(this.tb_SearchPurchase);
            this.Controls.Add(this.Update_Purchase);
            this.Controls.Add(this.Delete_Purchase);
            this.Controls.Add(this.Edit_Purchase);
            this.Controls.Add(this.Add_Purchase);
            this.Controls.Add(this.dgv_Purchase);
            this.Name = "PurchaseForm";
            this.Text = "Учетная книга";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_import_Purchase;
        private System.Windows.Forms.Button Export_Purchase;
        private System.Windows.Forms.Label lb1_SearchPurchase;
        private System.Windows.Forms.TextBox tb_SearchPurchase;
        private System.Windows.Forms.Button Update_Purchase;
        private System.Windows.Forms.Button Delete_Purchase;
        private System.Windows.Forms.Button Edit_Purchase;
        private System.Windows.Forms.Button Add_Purchase;
        private System.Windows.Forms.DataGridView dgv_Purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePurchase;
    }
}