﻿namespace BMS.Services.Contracts
{
    using BMS.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IPAXService
    {
        Task CreatePassenger(PAXInputModel inputModel);



    }
}
