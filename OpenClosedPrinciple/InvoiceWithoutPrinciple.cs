using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class InvoiceWithoutPrinciple
    {
        public enum InvoiceType
        {
            FinalInvoice,
            ProposedInvoice
        }


        public double getInvoiceDisCount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if(invoiceType == InvoiceType.FinalInvoice)
            {
                 finalAmount = amount - 100;  
            }else if(invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }

    }



    public class InvoiceWithPrinciple
    {
        public virtual double getInvoiceDiscount(double amount)
        {
            return amount - 10;    
        }
    }

    public class FinalInvoice : InvoiceWithPrinciple
    {
        public override double getInvoiceDiscount(double amount)
        {
            return base.getInvoiceDiscount(amount) -50;
        }
    }

    public class ProposedInvoice : InvoiceWithPrinciple
    {
        public override double getInvoiceDiscount(double amount)
        {
            return base.getInvoiceDiscount(amount) - 40;
        }
    }

    public class RecurringInvoice : InvoiceWithPrinciple
    {
        public override double getInvoiceDiscount(double amount)
        {
            return base.getInvoiceDiscount(amount) - 30;
        }
    }
}
