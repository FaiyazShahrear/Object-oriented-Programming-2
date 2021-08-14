using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle truck = new Vehicle();
            truck.SetEngineNo(4212);
            truck.SetColor("White");
            truck.SetVehicleType("heavy");
            truck.SetregistrationDate(new OurDate(22,8, 2018));
            truck.ShowInfo();

            Vehicle car = new Vehicle(423, "Red", "light", new OurDate(12,3,2019));
            car.ShowInfo();

            Vehicle v1 = new Vehicle();
            v1.EngineNo = 90;
            ushort w = v1.EngineNo;
            //Console.WriteLine(v1.EngineNo);
        }
    }
}
