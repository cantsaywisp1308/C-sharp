using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;
using DemoSession7.Entities;
using DemoSession7.Model;


namespace DemoSession7.Model
{
    public class InvoiceModel
    {
        public static List<Invoice> FindAll()
        {
            List<Invoice> invoices = new List<Invoice>
            {
                new Invoice
                {
                    Id ="In001",
                    Total = 400,
                    Payment="Cash",
                    Status = "Done",
                    Created = DateTime.ParseExact("20/05/2021","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    Customer = CustomerModel.Find("Cus001")
                },
                new Invoice
                {
                    Id ="In002",
                    Total = 520.5,
                    Payment="Credit Card",
                    Status = "On-hold",
                    Created = DateTime.ParseExact("19/05/2021","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    Customer = CustomerModel.Find("Cus002")
                },
                new Invoice
                {
                    Id ="In003",
                    Total = 100.5,
                    Payment="Credit Card",
                    Status = "Done",
                    Created = DateTime.ParseExact("19/05/2021","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    Customer = CustomerModel.Find("Cus003")
                },
                new Invoice
                {
                    Id ="In004",
                    Total = 200.4,
                    Payment="Paypal",
                    Status = "On-hold",
                    Created = DateTime.ParseExact("18/05/2021","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    Customer = CustomerModel.Find("Cus004")
                },
                new Invoice
                {
                    Id ="In005",
                    Total = 300,
                    Payment="Paypal",
                    Status = "Done",
                    Created = DateTime.ParseExact("17/05/2021","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    Customer = CustomerModel.Find("Cus005")
                },
                new Invoice
                {
                    Id ="In001",
                    Total = 200,
                    Payment="Cash",
                    Status = "Done",
                    Created = DateTime.ParseExact("17/05/2021","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    Customer = CustomerModel.Find("Cus001")
                },
                new Invoice
                {
                    Id ="In002",
                    Total = 205.1,
                    Payment="Credit Card",
                    Status = "Done",
                    Created = DateTime.ParseExact("18/05/2021","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    Customer = CustomerModel.Find("Cus001")
                },
                new Invoice
                {
                    Id ="In003",
                    Total = 211.5,
                    Payment="Credit Card",
                    Status = "Done",
                    Created = DateTime.ParseExact("19/05/2021","dd/MM/yyyy",CultureInfo.InvariantCulture),
                    Customer = CustomerModel.Find("Cus003")
                },
            };
            return invoices;
        }

    }
}
