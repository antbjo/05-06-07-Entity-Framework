using System;
using System.Collections.Generic;
using System.Text;

namespace FailSafeRentals.ConsoleApp.Models
{
    public class RentalStation
    {
        public int Id { get; set; }
        public string StationCode { get; set; } = null!;
        public string City { get; set; } = null!;
        public string StreetAddress { get; set; } = null!;

        // Navigeringsegenskap: En station har många fordon
        public List<FleetVehicle> Vehicles { get; set; } = [];
    }
}
