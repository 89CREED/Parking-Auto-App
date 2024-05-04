using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare_Auto
{
    internal class Transactions
    {
        public string TransactionId { get; set; }
        public string CarId { get; set; }
        public DateTime Entry {  get; set; }
        public DateTime Exit {  get; set; }
        public decimal ParkingFee { get; set; }

        public Transactions() { }

        public Transactions(string carId, DateTime entry, DateTime exit, decimal parkingFee)
        {
            Guid uniqueId = Guid.NewGuid();
            this.TransactionId = uniqueId.ToString();
            this.CarId = carId;
            this.Entry = entry;
            this.Exit = exit;
            this.ParkingFee = parkingFee;
        }

        public override string ToString()
        {
            return $"Car ID: {CarId}\nEntry: {Entry}\nExit: {Exit}\nParking Fee: {ParkingFee}";
        }

        //get
        public string getTransactionId() => this.TransactionId ;
        public string getCarId() => this.CarId ;
        public DateTime getEntry() => this.Entry ;
        public DateTime getExit() => this.Exit ;
        public decimal getParkingFee() => this.ParkingFee ;

        //set
        public void setCarId(string carId) {  this.CarId = carId ; }
        public void setEntry(DateTime entry) {  this.Entry = entry ; }
        public void setExit(DateTime exit) {  this.Exit = exit ; }
        public void setParkingFee(decimal parkingFee) {  this.ParkingFee = parkingFee ;}
    }
}
