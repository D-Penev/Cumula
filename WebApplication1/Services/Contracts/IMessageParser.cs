﻿namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts.MovementContracts;
    using BMS.Data.Models.Messages;
    using BMS.Models.MovementsInputModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IMessageParser
    {
        void ParseArrivalMovement(ArrivalMovementInputModel arrMVTInputModel);

        void ParseDepartureMovement(DepartureMovementInputModel depMVTInputModel);

        LoadDistributionMessage ParseLDM(string messageContent);

        ContainerPalletMessage ParseCPM(string messageContent);


    }
}
