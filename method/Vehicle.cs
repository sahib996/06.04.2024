using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._04._2024.method
{
    internal abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }
    }
    

    public virtual double AverageSpeed()
    {
        return DrivePath / DriveTime;
    }
    public virtual void GetInfo()
    {
        Console.WriteLine(  );
    }
    public override string ToString()
    {
        return
    }
}
