using System.ComponentModel.DataAnnotations;

namespace Rejestracja_Miejsc.Models
{
    public class Show
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ShowTime { get; set; }


        public Show()
        {

        }


    }
}
