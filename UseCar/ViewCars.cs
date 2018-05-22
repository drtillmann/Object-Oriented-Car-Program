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
    public partial class ViewCars : Form
    {

       
        BindingList<MyCar> bindingList;
               

        public ViewCars()
        {
            InitializeComponent();
            populateComboBox();
        }

        public void populateComboBox()
        {
            
            bindingList = new BindingList<MyCar>(Form1.carList.getList());
                 
            this.cmbBoxCars.DataSource = bindingList;
            this.cmbBoxCars.DisplayMember = "make";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyCar vehicle = null;
            String[] info = null;

            if (this.cmbBoxCars.SelectedItem is Truck)
            {
                MessageBox.Show("Truck object");
                vehicle = (Truck)this.cmbBoxCars.SelectedItem;
            }else if (this.cmbBoxCars.SelectedItem is Suv)
            {
                MessageBox.Show("SUV object");
                vehicle = (Suv)this.cmbBoxCars.SelectedItem;
            }else if (this.cmbBoxCars.SelectedItem is Sedan)
            {
                MessageBox.Show("Sedan object");
                vehicle = (Sedan)this.cmbBoxCars.SelectedItem;
            }
            else
            {
                MessageBox.Show("No object that i can use.");
            }

            // MyCar car = (MyCar)this.cmbBoxCars.SelectedItem;

            info = vehicle.print();

            viewMake.Text = vehicle.print()[0];
            viewModel.Text = info[1];
            viewColor.Text = info[2];
            viewCylinders.Text = info[3];
            viewDoors.Text = info[4];
            viewPrice.Text = info[5];
            txtOption.Text = info[6];
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyCar car = (MyCar)this.cmbBoxCars.SelectedItem;

            car.make = viewMake.Text.ToString();
            car.model = viewModel.Text.ToString();
            car.color = viewColor.Text.ToString();

            int cy = 0, d = 0;
            if(int.TryParse(viewCylinders.Text.ToString(), out cy)){
                car.cylinders = cy;
            }

            if(int.TryParse(viewDoors.Text.ToString(), out d)){
                car.doors = d;
            }

            double p = 0.0;
            if(double.TryParse(viewPrice.Text.ToString(), out p)){
                car.price = p;
            }


        }

        private void ViewCars_Load(object sender, EventArgs e)
        {

        }
    }
}
