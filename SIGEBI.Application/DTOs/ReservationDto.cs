using System;

namespace SIGEBI.Application.DTOs
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string UserName { get; set; }
        public DateTime ReservationDate { get; set; }
        public bool Status { get; set; }
    }
}
