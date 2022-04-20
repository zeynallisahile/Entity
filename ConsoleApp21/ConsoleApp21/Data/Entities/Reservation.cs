using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21.Data.Entities
{
    class Reservation
    {
        public int Id { get; set; }
        public int StadionId { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }

    }
}
