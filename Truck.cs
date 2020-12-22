using System;
namespace Homework
{
    public class Truck: Vehicle
    {
        private double loadCapacity;
        private int towingCapacity;

        public Truck(Manufacturer manufacturer, int cylinders, Person owner, double loadCapacity, int towingCapacity)
            : base(manufacturer, cylinders, owner)
        {
            this.loadCapacity = loadCapacity;
            this.towingCapacity = towingCapacity;
        }

        public double GetLoadCapacity() { return loadCapacity; }
        public void SetLoadCapacity(double loadCapacity) { this.loadCapacity = loadCapacity; }

        public int GetTowingCapacity() { return towingCapacity; }
        public void GetTowingCapacity(int towingCapacity) { this.towingCapacity = towingCapacity; }

        public override string ToString()
        {
            return $"Truck[manufacturer={GetManufacturer()} cylinders={GetCylinders()} owner={GetOwner()} loadCapacity={loadCapacity} towingCapacity={towingCapacity}]";
        }
    }
}
