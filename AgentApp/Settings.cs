using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApp
{
    public static class Settings
    {
        public static string ConnectionString =
            @"Server=ICTVM-FQQ06UJG2\SQLEXPRESS;Database=TravelExperts;Integrated Security=true;MultipleActiveResultsets=true";

        public static string ProductsQuery = @"SELECT 
                                    [ProductId],
                                    [prodName]
                                FROM [dbo].[Products]";

        public static string ProductByIdQuery = @"SELECT *
                                FROM Products
                                WHERE Productid = @ProductId";

        public static string PackagesQuery = @"SELECT *        
                                FROM [dbo].[Packages]";
    }
}
