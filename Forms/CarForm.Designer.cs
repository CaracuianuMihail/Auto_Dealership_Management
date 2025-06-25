namespace Auto_Dealership_Management
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.txtKm = new System.Windows.Forms.Label();
            this.txtKilometers = new System.Windows.Forms.TextBox();
            this.btnExportCars = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.chkWarranty = new System.Windows.Forms.CheckBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFinalDescription = new System.Windows.Forms.TextBox();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.txtFilterMake = new System.Windows.Forms.TextBox();
            this.btnFilterCars = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(20, 40);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(200, 22);
            this.txtMake.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(20, 95);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 22);
            this.txtModel.TabIndex = 1;
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(20, 209);
            this.numYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(200, 22);
            this.numYear.TabIndex = 2;
            this.numYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marcă";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "An";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preț";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(20, 322);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 7;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.BackColor = System.Drawing.Color.Transparent;
            this.chkAvailable.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAvailable.Location = new System.Drawing.Point(20, 361);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(110, 21);
            this.chkAvailable.TabIndex = 9;
            this.chkAvailable.Text = "Disponibil";
            this.chkAvailable.UseVisualStyleBackColor = false;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(332, 441);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(200, 30);
            this.btnAddCar.TabIndex = 12;
            this.btnAddCar.Text = "Adaugă mașină";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Location = new System.Drawing.Point(332, 481);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(200, 30);
            this.btnEditCar.TabIndex = 13;
            this.btnEditCar.Text = "Editează";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Location = new System.Drawing.Point(332, 521);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(200, 30);
            this.btnDeleteCar.TabIndex = 14;
            this.btnDeleteCar.Text = "Șterge";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(244, 20);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(1265, 370);
            this.dgvCars.TabIndex = 15;
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellClick);
            // 
            // txtKm
            // 
            this.txtKm.AutoSize = true;
            this.txtKm.BackColor = System.Drawing.Color.Transparent;
            this.txtKm.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.Location = new System.Drawing.Point(20, 250);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(160, 17);
            this.txtKm.TabIndex = 16;
            this.txtKm.Text = "Kilometrii parcursi";
            // 
            // txtKilometers
            // 
            this.txtKilometers.Location = new System.Drawing.Point(20, 269);
            this.txtKilometers.Name = "txtKilometers";
            this.txtKilometers.Size = new System.Drawing.Size(200, 22);
            this.txtKilometers.TabIndex = 17;
            // 
            // btnExportCars
            // 
            this.btnExportCars.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportCars.Location = new System.Drawing.Point(1212, 547);
            this.btnExportCars.Name = "btnExportCars";
            this.btnExportCars.Size = new System.Drawing.Size(261, 43);
            this.btnExportCars.TabIndex = 18;
            this.btnExportCars.Text = "Generare";
            this.btnExportCars.UseVisualStyleBackColor = true;
            this.btnExportCars.Click += new System.EventHandler(this.btnExportCars_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1228, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Generare raport masini(CSV):";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCar.Location = new System.Drawing.Point(560, 396);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(625, 234);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCar.TabIndex = 20;
            this.pictureBoxCar.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.Location = new System.Drawing.Point(19, 387);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(200, 36);
            this.btnChooseImage.TabIndex = 21;
            this.btnChooseImage.Text = "Adauga Imagine";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // chkWarranty
            // 
            this.chkWarranty.AutoSize = true;
            this.chkWarranty.BackColor = System.Drawing.Color.Transparent;
            this.chkWarranty.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWarranty.Location = new System.Drawing.Point(19, 441);
            this.chkWarranty.Name = "chkWarranty";
            this.chkWarranty.Size = new System.Drawing.Size(262, 21);
            this.chkWarranty.TabIndex = 22;
            this.chkWarranty.Text = "Garanție extinsă (+2500 euro)";
            this.chkWarranty.UseVisualStyleBackColor = false;
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.BackColor = System.Drawing.Color.Transparent;
            this.chkAudio.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAudio.Location = new System.Drawing.Point(19, 467);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(294, 21);
            this.chkAudio.TabIndex = 23;
            this.chkAudio.Text = "Sistem audio premium (+1500 euro)";
            this.chkAudio.UseVisualStyleBackColor = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(19, 494);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(291, 25);
            this.btnCalculate.TabIndex = 24;
            this.btnCalculate.Text = "Calculează configurația\n";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFinalDescription
            // 
            this.txtFinalDescription.Location = new System.Drawing.Point(19, 580);
            this.txtFinalDescription.Name = "txtFinalDescription";
            this.txtFinalDescription.Size = new System.Drawing.Size(188, 22);
            this.txtFinalDescription.TabIndex = 25;
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.Location = new System.Drawing.Point(238, 580);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.Size = new System.Drawing.Size(203, 22);
            this.txtFinalPrice.TabIndex = 26;
            // 
            // txtFilterMake
            // 
            this.txtFilterMake.Location = new System.Drawing.Point(1209, 440);
            this.txtFilterMake.Name = "txtFilterMake";
            this.txtFilterMake.Size = new System.Drawing.Size(264, 22);
            this.txtFilterMake.TabIndex = 27;
            // 
            // btnFilterCars
            // 
            this.btnFilterCars.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterCars.Location = new System.Drawing.Point(1209, 468);
            this.btnFilterCars.Name = "btnFilterCars";
            this.btnFilterCars.Size = new System.Drawing.Size(264, 28);
            this.btnFilterCars.TabIndex = 28;
            this.btnFilterCars.Text = "Afișează mașini după marcă";
            this.btnFilterCars.UseVisualStyleBackColor = true;
            this.btnFilterCars.Click += new System.EventHandler(this.btnFilterCars_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1209, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Filtrare  automobile după marcă:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(19, 154);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(199, 22);
            this.txtColor.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Culoare";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Descriere Finală";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Preț Final";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1585, 642);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFilterCars);
            this.Controls.Add(this.txtFilterMake);
            this.Controls.Add(this.txtFinalPrice);
            this.Controls.Add(this.txtFinalDescription);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkAudio);
            this.Controls.Add(this.chkWarranty);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExportCars);
            this.Controls.Add(this.txtKilometers);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "CarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Label txtKm;
        private System.Windows.Forms.TextBox txtKilometers;
        private System.Windows.Forms.Button btnExportCars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.CheckBox chkWarranty;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtFinalDescription;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.TextBox txtFilterMake;
        private System.Windows.Forms.Button btnFilterCars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}