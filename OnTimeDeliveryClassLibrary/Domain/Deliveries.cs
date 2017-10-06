using System;

namespace OnTimeDelivery
{
    public class Deliveries
    {
        public DateTime DepartureTime { get; set; }
        public Guid TrackingNumber { get; set; }
        public double TravelTime { get; set; }
        public int TravelDistance { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string VehicleType { get; set; }
    }
}
