using System.Diagnostics;


public class CinemaHall
{
    private List<Seat> seats;

    public CinemaHall(int rows, int seatsPerRow)
    {
        seats = new List<Seat>();
        for (int row = 1; row <= rows; row++)
        {
            for (int number = 1; number <= seatsPerRow; number++)
            {
                seats.Add(new Seat(row, number));
            }
        }
    }
    public bool ReserveSeat(int row, int number)
    {
        Seat selectedSeat = seats.FirstOrDefault(s => s.Row == row && s.Number == number);
        if (selectedSeat != null && selectedSeat.IsAvailable)
        {
            selectedSeat.IsAvailable = false;
            Console.WriteLine($"Koltuk {row}-{number} başarıyla rezerve edildi.");
            return true;
        }
        else
        {
            Console.WriteLine($"Koltuk {row}-{number} rezerve edilemedi. Lütfen başka bir koltuk seçin.");
            return false;
        }
    }
   
        
        default:
    
            case 1:
                 Console.WriteLine("\nKullanılabilir Koltuklar:");
                 CinemaHall.DisplayAvailableSeats();
                 break;
            case 2:
                Console.Write("\nRezerve etmek istediğiniz koltuğun satırını giriniz:");       
                int selectedRow;
                if (!int.TryParse(Console.ReadLine(), out selectedRow) || selectedRow < 1 || selectedRow > 8 )
                {
                    Console.WriteLine("Geçersiz satır numarası. Lütfen tekrar deneyiniz.");
                    break;
                }

                Console.Write("Rezerve etmek istediğiniz koltuğun numrasını girin:");
                int selectedNumber;
                if (!int.TryParse(Console.ReadLine(), out selectedNumber) || selectedNumber < 1 || selectedNumber > 20)
                {
                    Console.WriteLine("Geçersiz koltuk numarası.Lütfen tekrar deneyin.");
                    break;
                }
                CinemaHall.ReserveSeat(selectedRow, selectedNumber);
                    break;
            
            case 3:
                    Console.WriteLine("Programdan çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
        
}

   
