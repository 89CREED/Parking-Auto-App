using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare_Auto
{
    internal class Car
    {
        public string CarId { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string OwnerId { get; set; }

        public Car() { }

        public Car(string licensePlate, string make, string model, string color, string ownerId)
        {
            Guid uniqueId = Guid.NewGuid();
            this.CarId = uniqueId.ToString();
            this.LicensePlate = licensePlate;
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.OwnerId = ownerId;
        }

        public override string ToString()
        {
            return $"Car ID: {CarId}\nLicense Plate: {LicensePlate}\nMake: {Make}\nModel: {Model}\nColor: {Color}";
        }

        //get
        public string getId() => this.CarId ;
        public string getLicensePlate() => this.LicensePlate ;
        public string getMake() => this.Make ;
        public string getModel() => this.Model ;
        public string getColor() => this.Color ;

        //set
        public void setLicensePlate(string licensePlate) {  this.LicensePlate = licensePlate ;}
        public void setMake(string make) {  this.Make = make ; }
        public void setModel(string model) {  this.Model = model ; }
        public void setColor(string color) {  this.Color = color ; }
    }
}
