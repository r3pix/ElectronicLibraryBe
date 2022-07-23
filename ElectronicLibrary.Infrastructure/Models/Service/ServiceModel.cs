﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicBookingSystem.Infrastructure.Models.Service
{
    public class ServiceModel
    {
        /// <summary>
        /// Name of the service
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the service
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Cost of the Service
        /// </summary>
        public float Cost { get; set; }
    }
}
