using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Rejestracja_Miejsc.Pages
{
    public class ReservationssModel : PageModel
    {
        public List<ReservationssInfo> listReservationss = new List<ReservationssInfo>();
        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-Rejestracja_Miejsc-37932007-A962-4AB0-9E6E-D09093320793;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "select Show.ShowTime, Show.Title, Reservation.SeatRow, Reservation.SeatColumn from Reservation inner join Show on cast(MovieId as int) = Show.Id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ReservationssInfo res = new ReservationssInfo();
                                res.ShowTime = reader.GetDateTime(0);
                                res.Title = reader.GetString(1);
                                res.SeatRow = reader.GetInt32(2);
                                res.SeatColumn = reader.GetInt32(3);


                                listReservationss.Add(res);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class ReservationssInfo
    {
        public DateTime ShowTime;
        public string Title;
        public Int32 SeatRow;
        public Int32 SeatColumn;
    }



}
