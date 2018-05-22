namespace UseCar
{
    partial class Form1
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
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblCylinders = new System.Windows.Forms.Label();
            this.txtCylinders = new System.Windows.Forms.TextBox();
            this.lblDoors = new System.Windows.Forms.Label();
            this.txtDoors = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnViewCars = new System.Windows.Forms.Button();
            this.rbtnSedan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSuv = new System.Windows.Forms.RadioButton();
            this.rbtnTruck = new System.Windows.Forms.RadioButton();
            this.lblOption = new System.Windows.Forms.Label();
            this.txtOption = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(51, 34);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            this.lblMake.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(107, 27);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(172, 20);
            this.txtMake.TabIndex = 1;
            this.txtMake.TextChanged += new System.EventHandler(this.txtMake_TextChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(51, 78);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(107, 71);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(172, 20);
            this.txtModel.TabIndex = 2;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(51, 123);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(107, 116);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(172, 20);
            this.txtColor.TabIndex = 3;
            // 
            // lblCylinders
            // 
            this.lblCylinders.AutoSize = true;
            this.lblCylinders.Location = new System.Drawing.Point(51, 164);
            this.lblCylinders.Name = "lblCylinders";
            this.lblCylinders.Size = new System.Drawing.Size(49, 13);
            this.lblCylinders.TabIndex = 0;
            this.lblCylinders.Text = "Cylinders";
            // 
            // txtCylinders
            // 
            this.txtCylinders.Location = new System.Drawing.Point(107, 156);
            this.txtCylinders.Name = "txtCylinders";
            this.txtCylinders.Size = new System.Drawing.Size(172, 20);
            this.txtCylinders.TabIndex = 4;
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Location = new System.Drawing.Point(54, 208);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(35, 13);
            this.lblDoors.TabIndex = 0;
            this.lblDoors.Text = "Doors";
            // 
            // txtDoors
            // 
            this.txtDoors.Location = new System.Drawing.Point(107, 201);
            this.txtDoors.Name = "txtDoors";
            this.txtDoors.Size = new System.Drawing.Size(172, 20);
            this.txtDoors.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(57, 251);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(107, 243);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(172, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(107, 486);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 64);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create Car";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnViewCars
            // 
            this.btnViewCars.Location = new System.Drawing.Point(147, 556);
            this.btnViewCars.Name = "btnViewCars";
            this.btnViewCars.Size = new System.Drawing.Size(75, 40);
            this.btnViewCars.TabIndex = 8;
            this.btnViewCars.Text = "View Cars";
            this.btnViewCars.UseVisualStyleBackColor = true;
            this.btnViewCars.Click += new System.EventHandler(this.btnViewCars_Click);
            // 
            // rbtnSedan
            // 
            this.rbtnSedan.AutoSize = true;
            this.rbtnSedan.Location = new System.Drawing.Point(6, 19);
            this.rbtnSedan.Name = "rbtnSedan";
            this.rbtnSedan.Size = new System.Drawing.Size(56, 17);
            this.rbtnSedan.TabIndex = 7;
            this.rbtnSedan.TabStop = true;
            this.rbtnSedan.Text = "Sedan";
            this.rbtnSedan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSuv);
            this.groupBox1.Controls.Add(this.rbtnTruck);
            this.groupBox1.Controls.Add(this.rbtnSedan);
            this.groupBox1.Location = new System.Drawing.Point(79, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnSuv
            // 
            this.rbtnSuv.AutoSize = true;
            this.rbtnSuv.Location = new System.Drawing.Point(6, 65);
            this.rbtnSuv.Name = "rbtnSuv";
            this.rbtnSuv.Size = new System.Drawing.Size(47, 17);
            this.rbtnSuv.TabIndex = 9;
            this.rbtnSuv.TabStop = true;
            this.rbtnSuv.Text = "SUV";
            this.rbtnSuv.UseVisualStyleBackColor = true;
            // 
            // rbtnTruck
            // 
            this.rbtnTruck.AutoSize = true;
            this.rbtnTruck.Location = new System.Drawing.Point(6, 42);
            this.rbtnTruck.Name = "rbtnTruck";
            this.rbtnTruck.Size = new System.Drawing.Size(53, 17);
            this.rbtnTruck.TabIndex = 8;
            this.rbtnTruck.TabStop = true;
            this.rbtnTruck.Text = "Truck";
            this.rbtnTruck.UseVisualStyleBackColor = true;
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Location = new System.Drawing.Point(12, 419);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(0, 13);
            this.lblOption.TabIndex = 11;
            // 
            // txtOption
            // 
            this.txtOption.Location = new System.Drawing.Point(107, 412);
            this.txtOption.Name = "txtOption";
            this.txtOption.Size = new System.Drawing.Size(172, 20);
            this.txtOption.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 622);
            this.Controls.Add(this.txtOption);
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnViewCars);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtDoors);
            this.Controls.Add(this.lblDoors);
            this.Controls.Add(this.txtCylinders);
            this.Controls.Add(this.lblCylinders);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMake);
            this.Name = "Form1";
            this.Text = "Create A Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblCylinders;
        private System.Windows.Forms.TextBox txtCylinders;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.TextBox txtDoors;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnViewCars;
        private System.Windows.Forms.RadioButton rbtnSedan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSuv;
        private System.Windows.Forms.RadioButton rbtnTruck;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.TextBox txtOption;
    }
}

