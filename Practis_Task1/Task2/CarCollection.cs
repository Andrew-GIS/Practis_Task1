using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    class CarCollection<T> : CarInfo, ICarPark<T> where T: CarInfo
    {
        public T[] carArray { get; set; }

        public CarCollection(string carBrand, int carYear)
        {
            CarBrand = carBrand;
            CarYear = carYear;
            this.carArray = new T[0];
        }

        public int Count
        {
            get
            {
                int quantity = carArray.Length;
                return quantity;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.carArray[index];
            }
        }

        public void AddCar(T a, string carBrand, int carYear)
        {
            T[] array = new T[carArray.Length + 1];
            carArray.CopyTo(array, 0);
            carArray = array;
            carArray[carArray.Length - 1] = a;
        }

        void ICarPark<T>.DeleteAll()
        {
            this.carArray = new T[0];
        }
    }
}

interface ICarPark<T>
{
    void AddCar(T a, string carBrand, int createYear);
    int Count { get; }
    T this[int index] { get; }
    void DeleteAll();
}
