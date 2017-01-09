﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_App_V2
{
    public static class Settings
    {
        public static string connectionString =
            @"Data Source=ICTVM-FQQ06UJG2\SQLEXPRESS;Initial
            Catalog=TravelExperts;Integrated Security=True";

        public static string productSuppliersQuery =
            @"SELECT [ProductSupplierId], [ProductId], [SupplierId]
            FROM [Products_Suppliers] ps, [Packages_Products_Suppliers] pps
            WHERE ps.[ProductSupplierId] = pps.[ProductSupplierId]
            AND pps.[PackageId] = @PackageID";
    }
}
