﻿namespace BMS.Services
{
    using BMS.Data.Models;

    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;

    public class AircraftCabinBaggageHoldService : IAircraftCabinBaggageHoldService
    {
        private readonly ApplicationDbContext _dbContext;
      

        public AircraftCabinBaggageHoldService(ApplicationDbContext dbContext)
        {
          
            _dbContext = dbContext;
        }

        public void AddCabinAndBaggageHoldToAircraft(Aircraft aircraft)
        {
            string aicraftType = aircraft.Type.ToString();
 
        }
    }
}
