using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    class CarPark
    {
        public void ShowCar ()
        {
            var car = new CarCollection<CarInfo>();

            car.AddCar(new CarInfo { CarBrand = "Lada Kalina", CarYear = 1995 });
            car.AddCar(new CarInfo { CarBrand = "BMW M7", CarYear = 2010 });
            car.AddCar(new CarInfo { CarBrand = "Tayouta 15", CarYear = 2000 });
            car.AddCar(new CarInfo { CarBrand = "ВАЗ 2101", CarYear = 1975 });

            car.ToString();
        }
    }
}
