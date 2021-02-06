using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class User
    {
        private string name;
        private string password;
        private string address;
        private int mobileNumber;
        private List<Vehicle> myVehicles; // one to many association between Users and Vehicles

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }


        public User(string sname, string pw, string add, int mobile) {
            name = sname;
            password = pw;
            address = add;
            mobileNumber = mobile;
            myVehicles = new List<Vehicle>();
        }
        public void ChangePassword() {
            Console.Write("Enter your new password: ");
            string newPw = Console.ReadLine();
            password = newPw;
        }

        public void ChangeAddress() {
            Console.Write("Enter your new address: ");
            string newAdd = Console.ReadLine();
            address = newAdd;
        }

        public void ChangeMobileNumber() {
            Console.Write("Enter your new Phone Number: ");
            string newMobile = Console.ReadLine();
            mobileNumber = Convert.ToInt32(newMobile);
        }

        public virtual void ApplyPass(int userID) {
            // not implementing since apply use case not assigned to anyone
            Console.WriteLine("Not implemented... Try again next time!");
        }

        public void RegisterVehicle(Vehicle v) {
            if (!myVehicles.Contains(v))
            {
                myVehicles.Add(v);
                v.UserVehicle = this;
            }
            else {
                Console.WriteLine("Vehicle already registered!");
            }
        }

    }
}
