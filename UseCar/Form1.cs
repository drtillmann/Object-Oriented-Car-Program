using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCar
{
    public partial class Form1 : Form
    {

       public static CarList carList = new CarList();

        public Form1()
        {
            InitializeComponent();
            rbtnTruck.CheckedChanged += new EventHandler(rbtnTruck_CheckedChanged);
            rbtnSedan.CheckedChanged += new EventHandler(rbtnSedan_CheckedChanged);
            rbtnSuv.CheckedChanged += new EventHandler(rbtnSuv_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnTruck_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton) {
                RadioButton rb = (RadioButton)sender;
                if(rb.Checked)
                {
                    lbl.Text = "Bed Size";
                }
            }

        }

        private void rbtnSedan_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton rb = (RadioButton)sender;
                if (rb.Checked)
                {
                    lbl.Text = "Transmission";
                }
            }
        }

        private void rbtnSuv_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton rb = (RadioButton)sender;
                if (rb.Checked)
                {
                    lbl.Text = "Drivetrain";
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MyCar car = null;

            if (rbtnTruck.Checked)
            {
                car = new Truck(txt.Text.ToString());
                
              
            }
            else if (rbtnSedan.Checked)
            {
                car = new Sedan(txt.Text.ToString());
                
            }
            else if (rbtnSuv.Checked)
            {
                car = new Suv(txt.Text.ToString());
            }
            else
            {

            }
            



            car.make = txtMake.Text.ToString();
            car.model = txtModel.Text.ToString();
            car.color = txtColor.Text.ToString();

            int cy = 0, d = 0;
            if(int.TryParse(txtCylinders.Text.ToString(), out cy)){
                car.cylinders = cy;
            }

            if(int.TryParse(txtDoors.Text.ToString(), out d)){
                car.doors = d;
            }

            double p = 0.0;
            if(double.TryParse(txtPrice.Text.ToString(), out p)){
                car.price = p;
            }

           

            carList.add(car);

            var alert = MessageBox.Show("CAR CREATED\n\n" + car.make + "\n" +
                                        car.model + "\n" +
                                        car.color + "\n" +
                                        car.cylinders.ToString() + "\n" +
                                        car.doors.ToString() + "\n" +
                                        car.price.ToString());

            Console.WriteLine(car);

            //Console.Beep();

            txtMake.Text = "";
            txtModel.Text = "";
            txtColor.Text = "";
            txtCylinders.Text = "";
            txtDoors.Text = "";
            txtPrice.Text = "";
 
        }

        private void btnViewCars_Click(object sender, EventArgs e)
        {
            ViewCars view = new ViewCars();
            view.Show();
        }

        private void txtMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
