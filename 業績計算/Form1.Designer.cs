namespace HomeWork004
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pencil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.white = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSalesName = new System.Windows.Forms.Label();
            this.LblProName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "業務員業績";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "各產品總銷售額";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salse,
            this.pen,
            this.pencil,
            this.eraser,
            this.ruler,
            this.white,
            this.money});
            this.dataGridView1.Location = new System.Drawing.Point(86, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 204);
            this.dataGridView1.TabIndex = 2;
            // 
            // salse
            // 
            this.salse.DataPropertyName = "Name";
            this.salse.HeaderText = "業務員";
            this.salse.Name = "salse";
            this.salse.ReadOnly = true;
            // 
            // pen
            // 
            this.pen.DataPropertyName = "pen";
            this.pen.HeaderText = "原子筆";
            this.pen.Name = "pen";
            this.pen.ReadOnly = true;
            // 
            // pencil
            // 
            this.pencil.DataPropertyName = "pencil";
            this.pencil.HeaderText = "鉛筆";
            this.pencil.Name = "pencil";
            this.pencil.ReadOnly = true;
            // 
            // eraser
            // 
            this.eraser.DataPropertyName = "eraser";
            this.eraser.HeaderText = "橡皮擦";
            this.eraser.Name = "eraser";
            this.eraser.ReadOnly = true;
            // 
            // ruler
            // 
            this.ruler.DataPropertyName = "ruler";
            this.ruler.HeaderText = "尺";
            this.ruler.Name = "ruler";
            this.ruler.ReadOnly = true;
            // 
            // white
            // 
            this.white.DataPropertyName = "white";
            this.white.HeaderText = "立可白";
            this.white.Name = "white";
            this.white.ReadOnly = true;
            // 
            // money
            // 
            this.money.DataPropertyName = "money";
            this.money.HeaderText = "銷售總金額";
            this.money.Name = "money";
            this.money.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.price,
            this.sales,
            this.total});
            this.dataGridView2.Location = new System.Drawing.Point(86, 294);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(521, 216);
            this.dataGridView2.TabIndex = 3;
            // 
            // product
            // 
            this.product.DataPropertyName = "product";
            this.product.HeaderText = "產品";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "單價";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // sales
            // 
            this.sales.DataPropertyName = "sales";
            this.sales.HeaderText = "銷售數量";
            this.sales.Name = "sales";
            this.sales.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "銷售總金額";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "最佳業務員";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 635);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "最佳產品";
            // 
            // LblSalesName
            // 
            this.LblSalesName.AutoSize = true;
            this.LblSalesName.Location = new System.Drawing.Point(263, 568);
            this.LblSalesName.Name = "LblSalesName";
            this.LblSalesName.Size = new System.Drawing.Size(101, 12);
            this.LblSalesName.TabIndex = 6;
            this.LblSalesName.Text = "最佳業務員的名字";
            // 
            // LblProName
            // 
            this.LblProName.AutoSize = true;
            this.LblProName.Location = new System.Drawing.Point(263, 635);
            this.LblProName.Name = "LblProName";
            this.LblProName.Size = new System.Drawing.Size(89, 12);
            this.LblProName.TabIndex = 7;
            this.LblProName.Text = "最佳產品的名字";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 692);
            this.Controls.Add(this.LblProName);
            this.Controls.Add(this.LblSalesName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSalesName;
        private System.Windows.Forms.Label LblProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn salse;
        private System.Windows.Forms.DataGridViewTextBoxColumn pen;
        private System.Windows.Forms.DataGridViewTextBoxColumn pencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn eraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruler;
        private System.Windows.Forms.DataGridViewTextBoxColumn white;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}

