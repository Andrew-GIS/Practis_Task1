using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class GameProcess
    {
        public static object locker = new object();

        public static bool isCrash = false;

        private readonly Field field;

        private readonly RoadBorder border;

        private readonly MyCar myCar;

        private readonly OtherCar otherCar;

        private readonly Score score;

        private readonly Random random = new Random();

        public GameProcess()
        {
            this.field = new Field();
            this.border = new RoadBorder();
            this.myCar = new MyCar();
            this.otherCar = new OtherCar();
            this.score = new Score();
            Console.CursorVisible = false;
        }

        public void StartGame()
        {
            myCar.DoRightCarPosition();
            var border = new Thread(new ThreadStart(this.BourderDrowing));
            var other = new Thread(new ThreadStart(this.OtherCarDrowing));
            var other2 = new Thread(new ThreadStart(this.OtherCarDrowing));
            var score = new Thread(new ThreadStart(this.ScoreCounting));
            var main = new Thread(new ThreadStart(this.MainCarDrowing));
            if (isCrash == false)
            {
                border.Start();
                other.Start();
                //other2.Start();
                score.Start();
                main.Start();
            }
            else if (isCrash == true)
            {
                border.Abort();
                other.Abort();
                //other2.Abort();
                score.Abort();
                main.Abort();
            }
        }

        public void BourderDrowing()
        {
            this.border.Move();
        }

        public void MainCarDrowing()
        {
            this.myCar.RunMainCar();
        }

        public void OtherCarDrowing()
        {
            this.otherCar.MoveOtherCar(this.field.FieldHight);
        }

        public void ScoreCounting()
        {
            this.score.CountScore();
        }
    }
}