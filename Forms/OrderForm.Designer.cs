namespace Auto_Dealership_Management
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.cmbDiscountType = new System.Windows.Forms.ComboBox();
            this.btnCalcDiscount = new System.Windows.Forms.Button();
            this.txtDiscountPrice = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.btnAdvanceState = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCars = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(25, 25);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(250, 25);
            this.cmbCustomers.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(25, 322);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(250, 23);
            this.txtTotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preț total";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(300, 316);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(250, 30);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Plasează comandă";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(300, 25);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1004, 263);
            this.dgvOrders.TabIndex = 4;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // cmbDiscountType
            // 
            this.cmbDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscountType.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiscountType.FormattingEnabled = true;
            this.cmbDiscountType.Location = new System.Drawing.Point(25, 65);
            this.cmbDiscountType.Name = "cmbDiscountType";
            this.cmbDiscountType.Size = new System.Drawing.Size(250, 25);
            this.cmbDiscountType.TabIndex = 5;
            // 
            // btnCalcDiscount
            // 
            this.btnCalcDiscount.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcDiscount.Location = new System.Drawing.Point(25, 95);
            this.btnCalcDiscount.Name = "btnCalcDiscount";
            this.btnCalcDiscount.Size = new System.Drawing.Size(250, 30);
            this.btnCalcDiscount.TabIndex = 6;
            this.btnCalcDiscount.Text = "Calculează Preț Final\n";
            this.btnCalcDiscount.UseVisualStyleBackColor = true;
            this.btnCalcDiscount.Click += new System.EventHandler(this.btnCalcDiscount_Click);
            // 
            // txtDiscountPrice
            // 
            this.txtDiscountPrice.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPrice.Location = new System.Drawing.Point(25, 267);
            this.txtDiscountPrice.Name = "txtDiscountPrice";
            this.txtDiscountPrice.ReadOnly = true;
            this.txtDiscountPrice.Size = new System.Drawing.Size(250, 23);
            this.txtDiscountPrice.TabIndex = 7;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(25, 211);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(250, 23);
            this.txtBasePrice.TabIndex = 8;
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountType.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountType.Location = new System.Drawing.Point(25, 247);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(88, 17);
            this.lblDiscountType.TabIndex = 9;
            this.lblDiscountType.Text = "Reducere -";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(575, 317);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(250, 29);
            this.btnDeleteOrder.TabIndex = 10;
            this.btnDeleteOrder.Text = "Șterge Comanda";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentState.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentState.Location = new System.Drawing.Point(849, 298);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(64, 34);
            this.lblCurrentState.TabIndex = 11;
            this.lblCurrentState.Text = "Stare -\n\n";
            // 
            // btnAdvanceState
            // 
            this.btnAdvanceState.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvanceState.Location = new System.Drawing.Point(852, 317);
            this.btnAdvanceState.Name = "btnAdvanceState";
            this.btnAdvanceState.Size = new System.Drawing.Size(250, 29);
            this.btnAdvanceState.TabIndex = 12;
            this.btnAdvanceState.Text = "Avansează Stare\n";
            this.btnAdvanceState.UseVisualStyleBackColor = true;
            this.btnAdvanceState.Click += new System.EventHandler(this.btnAdvanceState_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selectare mașină";
            // 
            // cbCars
            // 
            this.cbCars.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCars.FormattingEnabled = true;
            this.cbCars.Location = new System.Drawing.Point(25, 166);
            this.cbCars.Name = "cbCars";
            this.cbCars.Size = new System.Drawing.Size(250, 25);
            this.cbCars.TabIndex = 14;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 369);
            this.Controls.Add(this.cbCars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdvanceState);
            this.Controls.Add(this.lblCurrentState);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.lblDiscountType);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtDiscountPrice);
            this.Controls.Add(this.btnCalcDiscount);
            this.Controls.Add(this.cmbDiscountType);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmbCustomers);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ComboBox cmbDiscountType;
        private System.Windows.Forms.Button btnCalcDiscount;
        private System.Windows.Forms.TextBox txtDiscountPrice;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.Button btnAdvanceState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCars;
    }
}