﻿namespace WebApplication1.Data
{
    using System.Reflection;
    using BMS.Data;
    using BMS.Data.LoadingInstructions;
    using BMS.Data.Models;
    using BMS.Data.Models.BaggageHolds.AircraftBaggageCompartments;
    using BMS.Data.Models.BaggageHolds.AircraftBaggageHolds;
    using BMS.Data.Models.Cabins;
    using BMS.Data.Models.Cabins.AircraftCabinZones;
    using BMS.Data.Models.Flights;
    using BMS.Data.Models.Messages;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<InboundFlight> InboundFlights { get; set; }

        public DbSet<OutboundFlight> OutboundFlights { get; set; }

        public DbSet<ArrivalMovement> ArrivalMovements { get; set; }

        public DbSet<DepartureMovement> DepartureMovements { get; set; }

        public DbSet<Aircraft> Aircraft { get; set; }

        public DbSet<ContainerPalletMessage> ContainerPalletMessages { get; set; }

        public DbSet<LoadDistributionMessage> LoadDistributionMessages { get; set; }

        public DbSet<FuelForm> FuelForms { get; set; }

        public DbSet<WeightForm> WeightForms { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Container> Containers { get; set; }

        public DbSet<ContainerInfo> ContainerInfos { get; set; }

        public DbSet<Suitcase> Suitcases { get; set; }

        public DbSet<ContainerLoadingInstruction> ContainerLoadingInstructions { get; set; }

        public DbSet<BulkLoadingInstruction> BulkLoadingInstructions { get; set; }

        public DbSet<AircraftBaggageHold> AircraftBaggageHolds { get; set; }

        public DbSet<CompartmentOne> CompartmentOnes { get; set; }

        public DbSet<CompartmentTwo> CompartmentTwos { get; set; }

        public DbSet<CompartmentThree> CompartmentThrees { get; set; }

        public DbSet<CompartmentFour> CompartmentFours { get; set; }

        public DbSet<CompartmentFive> CompartmentFives { get; set; }

        public DbSet<AircraftCabin> AircraftCabins { get; set; }

        public DbSet<ZoneAlpha> ZoneAlphas { get; set; }

        public DbSet<ZoneBravo> ZoneBravos { get; set; }

        public DbSet<ZoneCharlie> ZoneCharlies { get; set; }

        public DbSet<ZoneDelta> ZoneDeltas { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Entity<Message>().ToTable("Messages");
            builder.Entity<Compartment>().ToTable("Compartments");
            builder.Entity<AircraftCabinZone>().ToTable("Zones");
            builder.Entity<Flight>().ToTable("Flights");
            builder.Entity<LoadingInstruction>().ToTable("LoadingInstructions");
           
            base.OnModelCreating(builder);
        }
    }
}
