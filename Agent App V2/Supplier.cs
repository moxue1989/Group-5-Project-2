﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_App_V2
{
    public class Supplier
    {
        public static List<Supplier> AllSuppliers = TravelExpertsDB.GetSuppliers();
        public int SupplierId { get; set; }
        public string SupName { get; set; }
    }
}
