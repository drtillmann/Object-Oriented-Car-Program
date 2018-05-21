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

            MyCar car = (MyCar)this.cmbBoxCars.SelectedItem;

            viewMake.Text = car.make;
            viewModel.Text = car.model;
            viewColor.Text = car.color;
            viewCylinders.Text = car.cylinders.ToString();
            viewDoors.Text = car.doors.ToString();
            viewPrice.Text = car.price.ToString();

            
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
        

    }
}
