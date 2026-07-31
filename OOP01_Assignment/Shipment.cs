using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01_Assignment
{
    public struct Shipment
    {
        
        private string _trackingCode;
        private string _description;
        private double _weight;
        private decimal _deliveryFee;

        
        public string TrackingCode
        {
            get { return _trackingCode; }
        }

        
        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _description = value;
            }
        }

        
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                    _weight = value;
            }
        }

        
        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value > 0)
                    _deliveryFee = value;
            }
        }

        
        public DeliveryAddress Destination { get; set; }

        
        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5);
            }
        }

        
        public Shipment(string trackingCode)
            : this(
                  trackingCode,
                  "Unknown",
                  1,
                  50,
                  new DeliveryAddress("Unknown", "Unknown", 0))
        {
        }

        public Shipment(string trackingCode,
                        string description,
                        double weight,
                        decimal deliveryFee,
                        DeliveryAddress destination)
        {
            
            _trackingCode = "Unknown";
            _description = "Unknown";
            _weight = 1;
            _deliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);

           
            if (!string.IsNullOrWhiteSpace(trackingCode))
                _trackingCode = trackingCode;

            if (!string.IsNullOrWhiteSpace(description))
                _description = description;

            if (weight > 0)
                _weight = weight;

            if (deliveryFee > 0)
                _deliveryFee = deliveryFee;

            Destination = destination;
        }

        
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        
        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}