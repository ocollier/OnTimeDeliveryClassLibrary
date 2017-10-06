using System.Collections.Generic;
using OnTimeDelivery;

namespace OnTimeDeliveryClassLibrary
{
    public static class Helpers
    {
        public static List<Vehicles> GetVehicles()
        {
            List<Vehicles> vehicleTypes = new List<Vehicles>();
            vehicleTypes.Add(new Truck());
            vehicleTypes.Add(new Car());
            vehicleTypes.Add(new Bike());

            return vehicleTypes;
        }        
    }
}
