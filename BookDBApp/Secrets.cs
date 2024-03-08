using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDBApp
{
    public class Secrets
    {
        public static readonly string ConnectionString = "server=(localdb)\\MSSQLLocalDB;" +
            "database=BookDB;integrated security=True;TrustServerCertificate=True";
    }
}
