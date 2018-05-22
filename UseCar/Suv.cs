using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCar
{
    class Suv : MyCar
    {
        public Suv( String d = "")
        {
            drivetrain = d;
        }

        public String drivetrain
        {
            get;
            set;
        }

        public override String[] print()
        {
            String[] info = new String[7];
            info[0] = make;
            info[1] = model;
            info[2] = color;
            info[3] = cylinders.ToString();
            info[4] = doors.ToString();
            info[5] = price.ToString();
            info[6] = drivetrain;

            return info;

        }
    }
}
