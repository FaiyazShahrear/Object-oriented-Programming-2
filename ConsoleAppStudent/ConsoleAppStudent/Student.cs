using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleAppStudent
{
    struct OurAddress
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string district;

        public OurAddress(byte houseNo, byte roadNo, ushort postalCode, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.district = district;
        }

        public void PrintAddress()
        {
            Console.WriteLine("Address Info: ");
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("Postal Code: {0}", this.postalCode);
            Console.WriteLine("District: {0}", this.district);
        }
    }

    class Student
    {
        private byte id;
        private string name;
        private double cgpa;
        private string bloodGroup;
        private OurAddress address;

        public byte GetId()
        {
            return this.id;
        }

        public void SetId(byte id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetCgpa()
        {
            return this.cgpa;
        }

        public void SetCgpa(double cgpa)
        {
            this.cgpa = cgpa;
        }

        public string GetBloodGroup()
        {
            return this.bloodGroup;
        }

        public void SetBloodGroup(string bloodGroup)
        {
            this.bloodGroup = bloodGroup;
        }

        public OurAddress GetAddress()
        {
            return this.address;
        }

        public void SetAddress(OurAddress address)
        {
            this.address = address;
        }

        //public Student()
        //{
        //}

        public Student(byte id, string name, double cgpa, string bloodGroup, OurAddress address)
        {
            this.id = id;
            this.name = name;
            this.cgpa = cgpa;
            this.bloodGroup = bloodGroup;
            this.address = address;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("Student Info:");
            Console.WriteLine("Id: {0}", this.GetId());
            Console.WriteLine("Name: {0}", this.GetName());
            Console.WriteLine("CGPA: {0}", this.GetCgpa());
            Console.WriteLine("Blood Group: {0}\n", this.GetBloodGroup());
        }
    }
}































