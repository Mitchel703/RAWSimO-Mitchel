﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RAWSimO.Core.IO
{
    [XmlRootAttribute("Compartment")]
    public class DTOPodCompartment
    {
        //internal string Name;

        /// <summary>
        /// The capacity of this pod.
        /// </summary>
        public double Capacity;

        ///// <summary>
        ///// The amount of capacity currently in use.
        ///// </summary>
        //internal double CapacityInUse;

        ///// <summary>
        ///// The amount of capacity that is currently reserved by a controller.
        ///// </summary>
        //internal double CapacityReserved;
    }
}
