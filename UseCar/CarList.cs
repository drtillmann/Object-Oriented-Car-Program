using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCar
{
    public class CarList
    {
        private List<MyCar> carList;

        public CarList()
        {
            this.carList = new List<MyCar>();
        }

        public void add(MyCar car)
        {
            carList.Add(car);
            
        }

        public List<MyCar> getList()
        {
            return carList;
        }

    }
}
