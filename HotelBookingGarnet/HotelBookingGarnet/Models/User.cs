﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace HotelBookingGarnet.Models
{
    public class User : IdentityUser
    {
        public List<Hotel> Hotels { get; set; }
        public List<Reservation> UserReservations { get; set; }
        public List<TaxiReservation> TaxiReservations { get; set; }
    }
}