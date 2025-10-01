using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem_Group_3_5.Business
{
   public class Payment
    {
        #region Data Members

        public string paymentID;
        public decimal amount;
        public string status;
        public string creditCardNum;
        public DateTime paymentDate;

        #endregion

        #region Properties

        public string PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string CreditCardNumber
        {
            get { return creditCardNum; }
            set { creditCardNum = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        #endregion

        #region Constructors

        public Payment()
        {
            paymentDate = DateTime.Now;
            status = "Pending";
        }

        public Payment(string paymentID, decimal amount, string creditCardNum, DateTime paymentDate)
        {
            this.paymentID = paymentID;
            this.amount = amount;
            this.creditCardNum = creditCardNum;
            paymentDate = DateTime.Now;
            status = "Pending";
            PaymentDate = paymentDate;
        }

        #endregion

        #region Methods

        public bool ValidatePaymentDetails()
        {
            if (string.IsNullOrEmpty(creditCardNum) || creditCardNum.Length != 16)
                { 
                    return false; 
                }

            else 
                { 
                    return true;
                }
        }

        public void ProcessPayment()
        {
            bool isValid = ValidatePaymentDetails();

            if (isValid)
            {
                status = "Successful";
            }
            else
            {
                status = "Failed";
            }
        }

        #endregion
    }
}
