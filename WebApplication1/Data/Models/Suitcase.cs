﻿namespace BMS.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using BMS.GlobalData.ErrorMessages;
    using BMS.GlobalData.PAXConstants;

    public class Suitcase
    {

        public Suitcase()
        {
            this.SuitcaseId = Guid.NewGuid().ToString();
        }

        [Key]
        public string SuitcaseId { get; set; }

        [Range(PAXSuitcaseWeightConstants.SuitcaseMinWeight, PAXSuitcaseWeightConstants.SuitcaseMaxWeight, ErrorMessage = InvalidErrorMessages.PAXSuitcaseWeightIsInvalid)]
        public int Weight { get; set; }

        
        [Required]
        public int PaxId { get; set; }

        [Required]
        public virtual Passenger Passenger { get; set; }
    }
}
