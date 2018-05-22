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

       
        private BindingList<MyCar> bindingList;
        private string truck = "Truck object", sedan = "Sedan object", suv = "SUV object", invalidObject = "No object that i can use.", 
                                dropDownMember = "make" ;
        private MyCar vehicle = null;


        public ViewCars()
        {
            InitializeComponent();
            populateComboBox();
        }

        public void populateComboBox()
        {
            
            bindingList = new BindingList<MyCar>(Form1.carList.getList());
                 
            this.cmbBoxCars.DataSource = bindingList;
            this.cmbBoxCars.DisplayMember = dropDownMember;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String[] info = null;

            if (this.cmbBoxCars.SelectedItem is Truck)
            {
                MessageBox.Show(truck);
                vehicle = (Truck)this.cmbBoxCars.SelectedItem;
            }else if (this.cmbBoxCars.SelectedItem is Suv)
            {
                MessageBox.Show(suv);
                vehicle = (Suv)this.cmbBoxCars.SelectedItem;
            }else if (this.cmbBoxCars.SelectedItem is Sedan)
            {
                MessageBox.Show(sedan);
                vehicle = (Sedan)this.cmbBoxCars.SelectedItem;
            }
            else
            {
                MessageBox.Show(invalidObject);
            }

            info = vehicle.print();

            viewMake.Text = vehicle.print()[0];
            viewModel.Text = info[1];
            viewColor.Text = info[2];
            viewCylinders.Text = info[3];
            viewDoors.Text = info[4];
            viewPrice.Text = info[5];
            viewOption.Text = info[6];
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MyCar car = (MyCar)this.cmbBoxCars.SelectedItem;

            if (this.cmbBoxCars.SelectedItem is Truck)
            {
                vehicle = (Truck)this.cmbBoxCars.SelectedItem;
                //vehicle.bedSize = "";
            }
            else if (this.cmbBoxCars.SelectedItem is Suv)
            {
                vehicle = (Suv)this.cmbBoxCars.SelectedItem;
            }
            else if (this.cmbBoxCars.SelectedItem is Sedan)
            {
                vehicle = (Sedan)this.cmbBoxCars.SelectedItem;
            }
            else
            {
                //MessageBox.Show(invalidObject);
            }

            vehicle.make = viewMake.Text.ToString();
            vehicle.model = viewModel.Text.ToString();
            vehicle.color = viewColor.Text.ToString();

            int cy = 0, d = 0;
            if(int.TryParse(viewCylinders.Text.ToString(), out cy)){
                vehicle.cylinders = cy;
            }

            if(int.TryParse(viewDoors.Text.ToString(), out d)){
                vehicle.doors = d;
            }

            double p = 0.0;
            if(double.TryParse(viewPrice.Text.ToString(), out p)){
                vehicle.price = p;
            }

            //vehicle.option = viewOption.Text.ToString();


        }

        private void ViewCars_Load(object sender, EventArgs e)
        {

        }
    }
}
