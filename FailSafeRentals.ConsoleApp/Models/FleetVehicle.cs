using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FailSafeRentals.ConsoleApp.Models
{
    public class FleetVehicle
    {
        public int Id { get; set; }

        [Required, MaxLength(10)]
        public string RegistrationNumber { get; set; } = null!;

        [Required, MaxLength(100)]
        public string MakeAndModel { get; set; } = null!;
        public int MileageKm { get; set; }
        public bool NeedsService { get; set; } = false;

        // Explicit främmande nyckel (<Tabellnamn>Id) + navigeringsegenskap
        public int RentalStationId { get; set; }
        public RentalStation RentalStation { get; set; } = null!;
    }
}
