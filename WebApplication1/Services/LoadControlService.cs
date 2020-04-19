﻿namespace BMS.Services
{
    using BMS.Data.Models;
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;

    public class LoadControlService : ILoadControlService
    {
        private readonly IFlightService _flightsService;
        private readonly IAircraftService _aircraftService;
        private readonly ApplicationDbContext _dbContext;

        public LoadControlService(ApplicationDbContext dbContext,IFlightService flightService, IAircraftService aircraftService)
        {
            _flightsService = flightService;
            _aircraftService = aircraftService;
            _dbContext = dbContext;
        }

        public List<Container> AddContainersToInboundFlight(InboundFlight inbound, int amountOfInboundContainersToCreate)
        {
            var listOfContainers = new List<Container>();

            for (int i = 0; i < amountOfInboundContainersToCreate; i++)
            {
                var container = new Container
                {
                    InboundFlight = inbound,
                    InboundFlightId = inbound.FlightId,
                };

                listOfContainers.Add(container);
                _dbContext.Containers.Add(container);
                _dbContext.SaveChanges();
            }

            return listOfContainers;
        }

        public List<Container> AddContainersToOutboundFlight(OutboundFlight outbound, int amountOfOutboundContainersToCreate)
        {
            var listOfContainers = new List<Container>();

            for (int i = 0; i < amountOfOutboundContainersToCreate; i++)
            {

                var container = new Container
                {
                    OutboundFlight = outbound,
                    OutboundFlightId = outbound.FlightId
                };
                listOfContainers.Add(container);
                this.dbContext.Containers.Add(container);
                this.dbContext.SaveChanges();
            }

            return listOfContainers;
        }

        public void CalculatePAXWeightByGender()
        {
            throw new NotImplementedException();
        }

        public List<ContainerInfo> CreateContainerInfo(string[] splitMessage, List<Container> containers)
        {
            throw new NotImplementedException();
        }

        public string GetCorrectLoadingInstruction(string aircraftType)
        {
            string correctLoadingInstructionName = string.Empty;

            if (aircraftType == "B763" || aircraftType == "B788")
            {
                aircraftType = aircraftType.Remove(0, 1);
                correctLoadingInstructionName = $"_{aircraftType}ContainerLoadingPartial";
            } 
            else
            {
                correctLoadingInstructionName = "DefaultLoadingInstruction";
            }

            return correctLoadingInstructionName;
        }

        public void GetPassengersByZoneDistribution()
        {
            throw new NotImplementedException();
        }
    }
}
