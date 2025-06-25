namespace Auto_Dealership_Management
{
    partial class CustomCarForm
    {
        private System.ComponentModel.IContainer components = null;

        // Declarații controale UI
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtKilometers;
        private System.Windows.Forms.CheckBox chkElectric;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtInterior;
        private System.Windows.Forms.TextBox txtTransmission;
        private System.Windows.Forms.CheckBox chkSunroof;
        private System.Windows.Forms.TextBox txtWheel;
        private System.Windows.Forms.TextBox txtInfotainment;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnCreateCar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomCarForm));
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtKilometers = new System.Windows.Forms.TextBox();
            this.chkElectric = new System.Windows.Forms.CheckBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtInterior = new System.Windows.Forms.TextBox();
            this.txtTransmission = new System.Windows.Forms.TextBox();
            this.chkSunroof = new System.Windows.Forms.CheckBox();
            this.txtWheel = new System.Windows.Forms.TextBox();
            this.txtInfotainment = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(201, 162);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(200, 23);
            this.txtMake.TabIndex = 0;
            this.txtMake.TextChanged += new System.EventHandler(this.txtMake_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(201, 192);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 23);
            this.txtModel.TabIndex = 1;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(201, 222);
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
            this.numYear.Size = new System.Drawing.Size(120, 22);
            this.numYear.TabIndex = 2;
            this.numYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numYear.ValueChanged += new System.EventHandler(this.numYear_ValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(201, 252);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 23);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtKilometers
            // 
            this.txtKilometers.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometers.Location = new System.Drawing.Point(201, 282);
            this.txtKilometers.Name = "txtKilometers";
            this.txtKilometers.Size = new System.Drawing.Size(200, 23);
            this.txtKilometers.TabIndex = 4;
            this.txtKilometers.TextChanged += new System.EventHandler(this.txtKilometers_TextChanged);
            // 
            // chkElectric
            // 
            this.chkElectric.BackColor = System.Drawing.Color.Transparent;
            this.chkElectric.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkElectric.Location = new System.Drawing.Point(201, 312);
            this.chkElectric.Name = "chkElectric";
            this.chkElectric.Size = new System.Drawing.Size(104, 24);
            this.chkElectric.TabIndex = 5;
            this.chkElectric.Text = "Electric";
            this.chkElectric.UseVisualStyleBackColor = false;
            this.chkElectric.CheckedChanged += new System.EventHandler(this.chkElectric_CheckedChanged);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(201, 342);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(200, 23);
            this.txtColor.TabIndex = 6;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // txtInterior
            // 
            this.txtInterior.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterior.Location = new System.Drawing.Point(540, 165);
            this.txtInterior.Name = "txtInterior";
            this.txtInterior.Size = new System.Drawing.Size(200, 23);
            this.txtInterior.TabIndex = 7;
            this.txtInterior.TextChanged += new System.EventHandler(this.txtInterior_TextChanged);
            // 
            // txtTransmission
            // 
            this.txtTransmission.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransmission.Location = new System.Drawing.Point(540, 195);
            this.txtTransmission.Name = "txtTransmission";
            this.txtTransmission.Size = new System.Drawing.Size(200, 23);
            this.txtTransmission.TabIndex = 8;
            this.txtTransmission.TextChanged += new System.EventHandler(this.txtTransmission_TextChanged);
            // 
            // chkSunroof
            // 
            this.chkSunroof.BackColor = System.Drawing.Color.Transparent;
            this.chkSunroof.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSunroof.Location = new System.Drawing.Point(540, 225);
            this.chkSunroof.Name = "chkSunroof";
            this.chkSunroof.Size = new System.Drawing.Size(172, 24);
            this.chkSunroof.TabIndex = 9;
            this.chkSunroof.Text = "Trapă panoramică";
            this.chkSunroof.UseVisualStyleBackColor = false;
            this.chkSunroof.CheckedChanged += new System.EventHandler(this.chkSunroof_CheckedChanged);
            // 
            // txtWheel
            // 
            this.txtWheel.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWheel.Location = new System.Drawing.Point(540, 255);
            this.txtWheel.Name = "txtWheel";
            this.txtWheel.Size = new System.Drawing.Size(200, 23);
            this.txtWheel.TabIndex = 10;
            this.txtWheel.TextChanged += new System.EventHandler(this.txtWheel_TextChanged);
            // 
            // txtInfotainment
            // 
            this.txtInfotainment.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfotainment.Location = new System.Drawing.Point(540, 285);
            this.txtInfotainment.Name = "txtInfotainment";
            this.txtInfotainment.Size = new System.Drawing.Size(200, 23);
            this.txtInfotainment.TabIndex = 11;
            this.txtInfotainment.TextChanged += new System.EventHandler(this.txtInfotainment_TextChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(540, 315);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(200, 60);
            this.txtNotes.TabIndex = 12;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCar.Location = new System.Drawing.Point(344, 407);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(200, 40);
            this.btnCreateCar.TabIndex = 13;
            this.btnCreateCar.Text = "Creează mașină";
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Marca:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Anul:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pret:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kilometraj:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Culoare:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Interior:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Transmisie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Anvelope:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(484, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Note:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(420, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Infotainment:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(222, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(481, 37);
            this.label12.TabIndex = 25;
            this.label12.Text = "Creare Mașină Personalizată!!";
            // 
            // CustomCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 519);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtKilometers);
            this.Controls.Add(this.chkElectric);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtInterior);
            this.Controls.Add(this.txtTransmission);
            this.Controls.Add(this.chkSunroof);
            this.Controls.Add(this.txtWheel);
            this.Controls.Add(this.txtInfotainment);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnCreateCar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurare Mașină Personalizată";
            this.Load += new System.EventHandler(this.CustomCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
