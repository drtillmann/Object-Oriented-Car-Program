namespace UseCar
{
    partial class ViewCars
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
            this.components = new System.ComponentModel.Container();
            this.cmbBoxCars = new System.Windows.Forms.ComboBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewMake = new System.Windows.Forms.TextBox();
            this.viewModel = new System.Windows.Forms.TextBox();
            this.viewColor = new System.Windows.Forms.TextBox();
            this.viewCylinders = new System.Windows.Forms.TextBox();
            this.viewDoors = new System.Windows.Forms.TextBox();
            this.viewPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxCars
            // 
            this.cmbBoxCars.DataSource = this.programBindingSource;
            this.cmbBoxCars.FormattingEnabled = true;
            this.cmbBoxCars.Location = new System.Drawing.Point(12, 24);
            this.cmbBoxCars.Name = "cmbBoxCars";
            this.cmbBoxCars.Size = new System.Drawing.Size(260, 21);
            this.cmbBoxCars.TabIndex = 0;
            this.cmbBoxCars.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(UseCar.Program);
            // 
            // viewMake
            // 
            this.viewMake.Location = new System.Drawing.Point(97, 141);
            this.viewMake.Name = "viewMake";
            this.viewMake.Size = new System.Drawing.Size(175, 20);
            this.viewMake.TabIndex = 1;
            this.viewMake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewModel
            // 
            this.viewModel.Location = new System.Drawing.Point(97, 167);
            this.viewModel.Name = "viewModel";
            this.viewModel.Size = new System.Drawing.Size(175, 20);
            this.viewModel.TabIndex = 2;
            this.viewModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewColor
            // 
            this.viewColor.Location = new System.Drawing.Point(97, 193);
            this.viewColor.Name = "viewColor";
            this.viewColor.Size = new System.Drawing.Size(175, 20);
            this.viewColor.TabIndex = 3;
            this.viewColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewCylinders
            // 
            this.viewCylinders.Location = new System.Drawing.Point(97, 219);
            this.viewCylinders.Name = "viewCylinders";
            this.viewCylinders.Size = new System.Drawing.Size(175, 20);
            this.viewCylinders.TabIndex = 4;
            this.viewCylinders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewDoors
            // 
            this.viewDoors.Location = new System.Drawing.Point(97, 245);
            this.viewDoors.Name = "viewDoors";
            this.viewDoors.Size = new System.Drawing.Size(175, 20);
            this.viewDoors.TabIndex = 5;
            this.viewDoors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewPrice
            // 
            this.viewPrice.Location = new System.Drawing.Point(97, 271);
            this.viewPrice.Name = "viewPrice";
            this.viewPrice.Size = new System.Drawing.Size(175, 20);
            this.viewPrice.TabIndex = 6;
            this.viewPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(97, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cylinders";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price";
            // 
            // ViewCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 394);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.viewPrice);
            this.Controls.Add(this.viewDoors);
            this.Controls.Add(this.viewCylinders);
            this.Controls.Add(this.viewColor);
            this.Controls.Add(this.viewModel);
            this.Controls.Add(this.viewMake);
            this.Controls.Add(this.cmbBoxCars);
            this.Name = "ViewCars";
            this.Text = "View Cars";
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxCars;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.TextBox viewMake;
        private System.Windows.Forms.TextBox viewModel;
        private System.Windows.Forms.TextBox viewColor;
        private System.Windows.Forms.TextBox viewCylinders;
        private System.Windows.Forms.TextBox viewDoors;
        private System.Windows.Forms.TextBox viewPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}