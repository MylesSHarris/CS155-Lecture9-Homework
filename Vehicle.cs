using System;
namespace Homework
{
    public class Vehicle
    {
        public enum Manufacturer
        {
            Toyota, Volkswagen, Ford, Honda, Tesla
        }

        private Manufacturer manufacturer;
        private int cylinders;
        private Person owner;

        public Vehicle(Manufacturer manufacturer, int cylinders, Person owner)
        {
            this.manufacturer = manufacturer;
            this.cylinders = cylinders;
            this.owner = owner;
        }

        public Manufacturer GetManufacturer() { return manufacturer; }
        public void SetManufacturer(Manufacturer manufacturer) { this.manufacturer = manufacturer; }

        public int GetCylinders() { return cylinders; }
        public void SetCylinders(int cylinders) { this.cylinders = cylinders; }

        public Person GetOwner() { return owner; }
        public void SetOwner(Person owner) { this.owner = owner; }

        public override string ToString()
        {
            return $"Vehicle[manufacturer={manufacturer} cylinders={cylinders} owner={owner}]";
        }

        public bool Equals(Vehicle other)
        {
            return base.Equals(other);
        }
    }
}
