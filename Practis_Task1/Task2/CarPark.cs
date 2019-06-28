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

            car.AddCar(new CarInfo { сarBrand = "Lada Kalina", сarYear = 1995 });
            car.AddCar(new CarInfo { сarBrand = "BMW M7", сarYear = 2010 });
            car.AddCar(new CarInfo { сarBrand = "Tayouta 15", сarYear = 2000 });
            car.AddCar(new CarInfo { сarBrand = "ВАЗ 2101", сarYear = 1975 });

            Console.WriteLine(car.ToString()); 
        }
    }
}
