using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;
using Microsoft.VisualBasic.CompilerServices;

namespace CityInfo.API
{
    public class CityDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CityDataStore Current { get; } = new CityDataStore();

        public CityDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto {Id = 1, Name = "New Delhi", Description = "Capital City of India"},
                new CityDto {Id = 2, Name = "Washington", Description = "Capital City of USA"},
                new CityDto {Id = 3, Name = "Dhaka", Description = "Capital City of Bangladesh"},
            };
        }
    }
}
