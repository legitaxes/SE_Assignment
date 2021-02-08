using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class Payment
    {
        // properties
        private DateTime purchaseDate;
        private int price;
        private string paymentMode;
        private string purchaseType;

        private SeasonPass seasonPass; // 1 to many association SeasonPass
        // getter setter method for properties
        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string PaymentMode
        {
            get { return paymentMode; }
            set { paymentMode = value; }
        }

        public string PurchaseType
        {
            get { return purchaseType; }
            set { purchaseType = value; }
        }

        public SeasonPass SeasonPass {
            set {
                if (seasonPass != value) {
                    seasonPass = value;
                    value.AddPayment(this);
                }
            }
        }
        public Payment(DateTime pd, int p, string pm, string pt, SeasonPass sp) {
            purchaseDate = pd;
            price = p;
            paymentMode = pm; //credit, visa
            purchaseType = pt; // type of trasaction - SeasonPass - Car, SeasonPass - Motorbike, SeasonPass - Lorry

            sp.AddPayment(this);
        }
        public Payment(DateTime pd, int p, string pm, string pt) //used for recording the transaction of payment for non season pass payments
        {
            purchaseDate = pd;
            price = p;
            paymentMode = pm; //credit, visa
            purchaseType = pt; // type of trasaction - Sheltered Lot/ Unsheltered Lot
        }
    }
}
