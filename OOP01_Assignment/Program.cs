using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP01_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // Add a private string password = "secret"; field to a Book class. Try to print it from Main
            // (outside the class). What happens, and why?

            //Book book = new Book();
            //Console.WriteLine(book.password);
            //Can’t Access Because password from Type Private [Access through class only]
            #endregion
            #region Question02
            // Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
            //Why ?

            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);
            //Can Access Because copiesInStock from Type internal [Access through class or same project]
            #endregion
            #region Question03
            //Add a public string Title; field to Book. Set it and print it from Main.

            //Book book = new Book();
            //book.Title = "BlaBla";
            //Console.WriteLine(book.Title);

            //Can Access Because Title from Type public [Access from anywhere]

            #endregion
            #region Question04
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            //assign it Genre.Science, and print it.

            //Book book = new Book();
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);
            #endregion
            #region Question05
            // Using the Genre enum above, print the underlying int value of
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.


            //int NumFiction = (int)Genre.Fiction;
            //int NumNonFiction = (int)Genre.NonFiction;
            //int NumScience = (int)Genre.Science;
            //Console.WriteLine(NumFiction);
            //Console.WriteLine(NumNonFiction);
            //Console.WriteLine(NumScience);
            #endregion
            #region Question06
            //Given int genreNumber = 1;, cast it into a Genre value and print the result.

            //int genreNumber = 1;
            //Genre result = (Genre)1;
            //Console.WriteLine(result);
            #endregion
            #region Question07
            // Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.

            //Genre genre = Genre.Fiction;
            //string str = genre.ToString();
            //Console.WriteLine(str);
            #endregion
            #region Question08
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
            //print the result.

            //string genreText = "Science";
            //Genre result = Enum.Parse<Genre>(genreText);
            //Console.WriteLine(result);
            #endregion
            #region Question09
            //Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to
            //attempt the conversion.Print "Unknown genre" if it fails.

            //string genreText = "Mystery";
            //Genre result;

            //bool isparsed = Enum.TryParse<Genre>(genreText, out result);

            //if (isparsed)
            //{
            //    Console.WriteLine("Done");
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre");
            //}
            #endregion



            #region Question10
            // What happens when a DeliveryAddress variable is copied into another variable and the copy is modified???

            //Don’t change in original Because it create New Object (Because Struct is Value Type)

            // What happens when a Customer variable is copied into another variable and one variable modifies the object??

            //Change Affect in Two Variables Because Same Object (Because Class is Reference Type)

            #endregion
            #region Question11
            // a) Identify at least three problems with this design from an encapsulation perspective.

            //All fields are public, allowing direct access and modification.
            //There is no validation for values.
            // The struct can’t protect its internal state, which breaks encapsulation.


            //b) How can private fields and public properties improve this design??

            //Private hide the internal data from direct access.
            //Public properties provide controlled access.
            //Properties can validate input values.
            //makes the code easier to maintain. 
            #endregion
            #region Question12

            //DeliveryAddress deliveryAdd01 = new DeliveryAddress("Cairo", "Elsadat", 15);

            //DeliveryAddress deliveryAdd02 = deliveryAdd01;

            //deliveryAdd02.City = "Oman";
            //deliveryAdd02.Street = "ElOboor";
            //deliveryAdd02.BuildingNumber = 25;

            //Console.WriteLine(deliveryAdd01.GetFullAddress());
            //Console.WriteLine(deliveryAdd02.GetFullAddress());


            //DeliveryCenter center = new DeliveryCenter();

            
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter Shipment {i + 1} Data");

            //    Console.Write("Tracking Code: ");
            //    string trackingCode = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string description = Console.ReadLine();

            //    Console.Write("Weight: ");
            //    double weight = double.Parse(Console.ReadLine());

            //    Console.Write("Delivery Fee: ");
            //    decimal fee = decimal.Parse(Console.ReadLine());

            //    Console.Write("City: ");
            //    string city = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string street = Console.ReadLine();

            //    Console.Write("Building Number: ");
            //    int building = int.Parse(Console.ReadLine());

            //    DeliveryAddress address = new DeliveryAddress(city, street, building);

            //    Shipment shipment = new Shipment(
            //        trackingCode,
            //        description,
            //        weight,
            //        fee,
            //        address);

            //    if (center.AddShipment(shipment))
            //        Console.WriteLine("Shipment added successfully.\n");
            //    else
            //        Console.WriteLine("Delivery Center is full.\n");
            //}

            //Console.WriteLine();
            //Console.WriteLine("--- All Shipments ---");
            //Console.WriteLine();

           
            //for (int i = 0; i < 3; i++)
            //{
            //    center[i].PrintShipment();
            //    Console.WriteLine();
            //}

            
            //Console.Write("Enter a tracking code to search: ");
            //string code = Console.ReadLine();

            //Shipment found = center[code];

            //Console.WriteLine();

            //if (!string.IsNullOrEmpty(found.TrackingCode))
            //{
            //    Console.WriteLine($"Shipment found: {found.TrackingCode} - {found.Description}");
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found.");
            //}

           
            //Console.WriteLine();
            //Console.WriteLine("--- Struct Copy Test ---");

            //DeliveryAddress original = center[0].Destination;

            //DeliveryAddress copied = original;

            //copied.Street = "Makram Ebeid Street";
            //copied.BuildingNumber = 20;

            //Console.WriteLine($"Original Address: {original.GetFullAddress()}");
            //Console.WriteLine($"Copied Address: {copied.GetFullAddress()}");
            #endregion

        }
    }
}
