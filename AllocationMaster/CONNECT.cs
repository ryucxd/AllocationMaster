using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocationMaster
{
    class CONNECT
    {
        public static int login_ID;
        public static string login_full_name;
        public static int reallocation_cancelled;
        public static string reallocation_staff_name;

        public const string ConnectionString = "user id=sa;" +

            "password=Dodid1;Network Address=192.168.0.150\\sqlexpress;" +

            "Trusted_Connection=no;" +

            "database=order_database;" +

            "connection timeout=30";

        public const string ConnectionStringUser = "user id=sa;" +

                               "password=Dodid1;Network Address=192.168.0.150\\sqlexpress;" +

                               "Trusted_Connection=no;" +

                               "database=user_info; " +

                               "connection timeout=30";
    }
}
