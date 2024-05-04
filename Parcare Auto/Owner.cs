using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare_Auto
{
    internal class Owner
    {
        public string OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IDNP { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }

        public Owner() { }

        public Owner(string firstName, string lastName, string idnp, string phone, string email)
        {
            Guid uniqueId = Guid.NewGuid();
            this.OwnerId = uniqueId.ToString();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IDNP = idnp;
            this.Phone = phone;
            this.Email = email;
        }

        public override string ToString()
        {
            return $"OwnerId: {OwnerId}\nFirst Name: {FirstName}\nLast Name: {LastName}\nIDNP: {IDNP}\nPhone: {Phone}\nEmail: {Email}";
        }

        //get
        public string getId() => this.OwnerId;
        public string getFirstName() => this.FirstName;
        public string getLastName() => this.LastName;
        public string getIDNP() => this.IDNP;
        public string getPhone() => this.Phone;
        public string getEmail() => this.Email;

        //set
        public void setFirstName(string firstName) { this.FirstName = firstName; }
        public void setLastName(string lastName) { this.LastName = lastName; }
        public void setIDNP(string idnp) { this.IDNP = idnp; }
        public void setPhone(string phone) {  this.Phone = phone; }
        public void setEmail(string email) {  this.Email = email; }


        
    }
}
