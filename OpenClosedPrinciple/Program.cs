// See https://aka.ms/new-console-template for more information
using OpenClosedPrinciple;

Console.WriteLine("Hello, World!");

Console.WriteLine("Without Allow Open Closed Principle");
InvoiceWithoutPrinciple ObjInvoiceWithoutPrinciple = new InvoiceWithoutPrinciple();
Console.WriteLine("Discount : "+ObjInvoiceWithoutPrinciple.getInvoiceDisCount(500, InvoiceWithoutPrinciple.InvoiceType.FinalInvoice));


Console.WriteLine("With Allow Open Closed Principle");
InvoiceWithPrinciple FInvoice = new FinalInvoice();
InvoiceWithPrinciple PInvoice = new ProposedInvoice();
InvoiceWithPrinciple RInvoice = new RecurringInvoice();
Console.WriteLine("Final Invoice amount : " + FInvoice.getInvoiceDiscount(10000));
Console.WriteLine("Proposed Invoice amount : " + PInvoice.getInvoiceDiscount(10000));
Console.WriteLine("Recurring Invoice amount : " + RInvoice.getInvoiceDiscount(10000));
