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

        string make = "", model = "", color = "", cylinder = "", doors = "", price = "";

        Boolean truck = false, suv = false, sedan = false;

        int cy = 0, d = 0;

        double p = 0.0;

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
                    lblOption.Text = "Bed Size";
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
                    lblOption.Text = "Transmission";
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
                    lblOption.Text = "Drivetrain";
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MyCar car = null;

            make = txtMake.Text.ToString();
            model = txtModel.Text.ToString();
            color = txtColor.Text.ToString();
            cylinder = txtCylinders.Text.ToString();
            doors = txtDoors.Text.ToString();
            price = txtPrice.Text.ToString();

            truck = rbtnTruck.Checked;
            suv = rbtnSuv.Checked;
            sedan = rbtnSedan.Checked;


            if (make.Equals("") || model.Equals("") || color.Equals("") || cylinder.Equals("") || doors.Equals("") || price.Equals("")
               /* || groupBox1.Controls.OfType<RadioButton>().Any(x => x.Checked) */)
            {
                MessageBox.Show("There is an empty field.");
            }
            else
            {

                if (rbtnTruck.Checked)
                {
                    car = new Truck(txtOption.Text.ToString());

                }
                else if (rbtnSedan.Checked)
                {
                    car = new Sedan(txtOption.Text.ToString());

                }
                else if (rbtnSuv.Checked)
                {
                    car = new Suv(txtOption.Text.ToString());
                }
                else
                {

                }


                
                car.make = make;
                car.model = model;
                car.color = color;

                if (int.TryParse(cylinder, out cy))
                {
                    car.cylinders = cy;
                }
                else
                {
                    MessageBox.Show("Cylinders must be a number");
                }

                if (int.TryParse(doors, out d))
                {
                    car.doors = d;
                }


                if (double.TryParse(price, out p))
                {
                    car.price = p;
                }


                carList.add(car);

                var alert = MessageBox.Show("CAR CREATED\n\n" + car.make + "\n" +
                                            car.model + "\n" +
                                            car.color + "\n" +
                                            car.cylinders.ToString() + "\n" +
                                            car.doors.ToString() + "\n" +
                                            car.price.ToString() + "\n"
                                          );

                txtMake.Text = "";
                txtModel.Text = "";
                txtColor.Text = "";
                txtCylinders.Text = "";
                txtDoors.Text = "";
                txtPrice.Text = "";
                txtOption.Text = "";

                rbtnSedan.Checked = false;
                rbtnSuv.Checked = false;
                rbtnTruck.Checked = false;

                lblOption.Text = "";

            }


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
