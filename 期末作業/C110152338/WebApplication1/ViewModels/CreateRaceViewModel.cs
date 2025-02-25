﻿using WebApplication1.Data.Enum;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class CreateRaceViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public RacesCategory RaceCategory { get; set; }
        public string AppUserId { get; set; }
    }
}
