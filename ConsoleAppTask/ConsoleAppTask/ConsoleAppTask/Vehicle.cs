using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask
{
    struct OurDate
    {
        private byte day;
        private byte month;
        private ushort year;

        public OurDate(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void ShowDate()
        {
            Console.WriteLine("Registration Date: {0}-{1}-{2}", this.day, this.month, this.year);
        }
    }

    class Vehicle
    {
        private ushort engineNo;
        private string color;
        private string vehicleType;
        private OurDate registrationDate;

        public ushort EngineNo
        {
            get { return this.engineNo; }
            set { this.engineNo = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        
        public string VehicleType
        {
            get { return this.vehicleType; }
            set { this.vehicleType = value; }
        }
        
        public OurDate RegistrationDate
        {
            get { return this.registrationDate; }
            set { this.registrationDate = value; }
        }

        //public ushort GetEngineNo()
        //{
        //    return this.engineNo;
        //}

        //public void SetEngineNo(ushort engineNo)
        //{
        //    this.engineNo = engineNo;
        //}

        //public string GetColor()
        //{
        //    return this.color;
        //}

        //public void SetColor(string color)
        //{
        //    this.color = color;
        //}
        
        //public string GetVehicleType()
        //{
        //    return this.vehicleType;
        //}

        //public void SetVehicleType(string vehicleType)
        //{
        //    this.vehicleType = vehicleType;
        //}

        //public OurDate GetRegistrationDate()
        //{
        //    return this.registrationDate;
        //}

        //public void SetregistrationDate(OurDate registrationDate)
        //{
        //    this.registrationDate = registrationDate;
        //}

        public Vehicle()
        {
        }

        public Vehicle(ushort engineNo, string color, string vehicleType, OurDate registrationDate)
        {
            this.EngineNo = engineNo;//this.SetEngineNo(engineNo);//this.engineNo = engineNo;
            this.Color = color;//this.SetColor(color);//this.color = color;
            this.VehicleType = vehicleType; //this.SetVehicleType(vehicleType);//this.vehicleType = vehicleType;
            this.RegistrationDate = registrationDate;
                //this.SetregistrationDate(registrationDate);//this.registrationDate = registrationDate;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Engine No: {0}", this.EngineNo);//this.GetEngineNo());
            Console.WriteLine("Color: {0}", this.Color);//this.GetColor());
            Console.WriteLine("Vehicle Type {0}", this.VehicleType);//this.GetVehicleType());
            this.RegistrationDate.ShowDate();//this.GetRegistrationDate().ShowDate();//this.registrationDate.ShowDate();
            Console.WriteLine();
        }
    }
}
