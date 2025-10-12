using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Group 3-5
// Members:
// Shakila Africa : AFRSHA001
// Chai Europa : ERPTEA001
// Lilitha Somana : SMNBON004
// Lindani Xaba : XBXLIN006
namespace HotelManagementSystem_Group_3_5.Business
{
   public class Payment
    {
        #region Data Members

        private string paymentID;
        private string bookingID;
        private decimal amount;
        private string status;
        private string creditCardNum;
        private DateTime paymentDate;

        #endregion

        #region Properties

        public string PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }

        public string BookingID 
        { 
            get { return bookingID; } 
            set { bookingID = value; } 
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

        public Payment(string paymentID, string bookingID, decimal amount, string creditCardNum, DateTime paymentDate)
        {
            this.paymentID = paymentID;
            this.bookingID = bookingID;
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

        public bool ProcessRefund()
        {
            status = "Refunded";
            return true;
        }

        public override string ToString()
        {
            return $"{paymentDate} Payment Date - R{amount} - {status} - Ref: {paymentID}";
        }

        #endregion
    }
}
