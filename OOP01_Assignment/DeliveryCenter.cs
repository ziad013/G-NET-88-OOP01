using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01_Assignment
{
    public struct DeliveryCenter
    {
        
        private Shipment[] _shipments;

        
        public DeliveryCenter()
        {
            _shipments = new Shipment[10];
        }

        
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < _shipments.Length)
                    return _shipments[index];

                return default;
            }

            set
            {
                if (index >= 0 && index < _shipments.Length)
                    _shipments[index] = value;
            }
        }

        
        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (Shipment shipment in _shipments)
                {
                    if (shipment.TrackingCode == trackingCode)
                        return shipment;
                }

                return default;
            }
        }

        
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (string.IsNullOrEmpty(_shipments[i].TrackingCode))
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
    }
}
