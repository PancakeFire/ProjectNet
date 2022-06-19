using System.ComponentModel.DataAnnotations.Schema;

namespace Rejestracja_Miejsc.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int SeatRow { get; set; }
        public int SeatColumn { get; set; }

        public string UserEmail { get; set; }
        public string MovieId { get; set; }

        public Reservation()
        {

        }
    }
}
