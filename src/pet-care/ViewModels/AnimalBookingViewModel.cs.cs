// File: /ViewModels/AnimalBookingViewModel.cs
using PetShopProj.Models;

namespace PetShopProj.ViewModels
{
    public class AnimalBookingViewModel
    {
        public Animal Animal { get; set; }
        public Call Booking { get; set; }
        public AddCommentViewModel Comment { get; set; }
    }
}

