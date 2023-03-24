using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Member variables
        int sel = 0;
        double _payment = 0;

        // Instantiations of classes 
        Product product1 = new Product();
        Order order1 = new Order();
        Customer customer1 = new Customer();

        // Welcoming messasge
        Console.WriteLine("\nWelcome to your favorite online store!");
        do
        {
            // Show Menu
            sel = product1.DisplayMenu();
            
            // Program Buying Options
            if (0 < sel && sel < 8)
            {
                order1.SetOrderList(product1.ProductPrice(sel));
                _payment = order1.TotalOrderCost();
            }

            // Proceed to checkout
            else if (sel == 8)
            {
                // Get customer's information
                customer1.SetCustomerName();

                // Labels
                order1.PackingLabel();
                order1.ShippingLabel(customer1.GetCustomerData());

                // Indicate final transaction cost
                Console.WriteLine($"Thank you for visiting you favorite online store!\nThe Total payment is: ${String.Format("{0:0.00}", _payment + customer1.GetShippingCost())}\n");
            }
            
            // Cancel online buying
            else if (sel == 9)
            { Console.WriteLine("\nThank you for visiting us today!\n"); }
            else
            { Console.WriteLine("\nYour selection is invalid. Try again."); }

        } while (sel != 8 && sel != 9);
    }
}