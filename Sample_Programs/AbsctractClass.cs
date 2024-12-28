using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    /*   */
    public abstract class BaseClass
    {


        public int NonAbstract_ID
        {
            get;
            set;
        }
        public string NonAbstract_FirstName { get; set; }
        public string NonAbstract_LastName { get; set; }

        public string NonAbstract_GetFullName()
        {
            return this.NonAbstract_FirstName + "" + NonAbstract_LastName;
        }

        public abstract void GetMonthlySalary();
        public abstract int GetMonthlySalary1();
        /*
        public virtual int GetMonthlySalary()
        {

            throw new NotImplementedException();
        }
        */


    }

    public abstract class PaymentGateway
    {
        public abstract bool ProcessPayment(decimal amount);
        public abstract bool AuthorizePayment(decimal amount);
        public abstract bool CapturePayment();
        public abstract bool RefundPayment(decimal amount);
    }

    public class PayPalGateway : PaymentGateway
    {
        public override bool AuthorizePayment(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override bool CapturePayment()
        {
            throw new NotImplementedException();
        }

        public override bool ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override bool RefundPayment(decimal amount)
        {
            throw new NotImplementedException();
        }

        // Implement other abstract methods using PayPal API
    }

    /*   */
    public class FullTimeEmployee : BaseClass
    {

        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary1()
        {
            return this.AnnualSalary / 12;
        }
        public override void GetMonthlySalary()
        {
            
        }

    }

    /*   */
    public class ContractEmployee : BaseClass
    {

        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }
          public override int GetMonthlySalary1()
          {
              return this.TotalHours * this.HourlyPay / 12;
          }
        public override void GetMonthlySalary()
        {

        }

    }
    }

