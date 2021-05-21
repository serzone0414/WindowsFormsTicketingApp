using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTicketingApp
{
    class Ticket
    {
        private static string firstFlight = "";
        private static string secondFlight = " ";
        private static string firstFlightTime = "";
        private static string secondFlightTime = "";
        private static string firstFlightPrice = "0";
        private static string secondFlightPrice = "0";
        private static string origion = "";
        private static string destination = "";
        private static string title = "";
        private static string firstName = "";
        private static string lastName = "";
        private static int totalPrice;


        public static string FirstFlight { set; get; }
        public static string SecondFlight { set; get; }

        public static string FirstFlightTime { set; get; }
        public static string SecondFlightTime { set; get; }

        public static string FirstFlightPrice { set; get; }
        public static string SecondFlightPrice { set; get; }

        public static string Origion { set; get; }
        public static string Destination { set; get; }

        public static string Title { set; get; }
        public static string FirstName { set; get; }
        public static string LastName { set; get; }

        public static int Totalprice { set; get; }
    }
}
