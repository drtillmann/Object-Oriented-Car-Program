using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCar

{

    public class MyCar
    {

        public MyCar(String ma = "", String mo = "", String c = "", int cy = 0, int d = 0, double p = 0.0)
        {
            this.make = ma;
            this.model = mo;
            this.color = c;
            this.cylinders = cy;
            this.doors = d;
            this.price = p;
        }


        public String make
        {
            get;
            set;
        }

        public String model
        {
            get;
            set;
        }

        public String color
        {
            get;
            set;
        }

        public int cylinders
        {
            get;
            set;
        }

        public int doors
        {
            get;
            set;
        }

        public double price
        {
            get;
            set;
        }

        public virtual String[] print() { return new String[7]; }
    }
}