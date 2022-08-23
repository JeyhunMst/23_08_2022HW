using _23_08_2022Task.Models;
using _23_08_2022Task.Utilies.Exceptions;
using System;

namespace _23_08_2022Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter new room name:");
            string roomName = Console.ReadLine();
            Console.Write("Enter new room price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter new room person capacity:");
            int capacity = Convert.ToInt32(Console.ReadLine());
            Room RoomNo1 = new Room(roomName,price,capacity);
            Console.WriteLine(RoomNo1.ToString());
            Console.Write("Enter new hotel name:");
            string hotelName = Console.ReadLine();
            Console.Write("Enter count of rooms:");
            int countRoom = Convert.ToInt32(Console.ReadLine());
            Hotel HiltonHotel = new Hotel(hotelName,countRoom);
            HiltonHotel.AddRoom(RoomNo1);
            HiltonHotel.Reserve(1);    //burada room is reserved yeni evvelce true oldugu ucun false a cevirir ve otagi reserve etmis olur
            HiltonHotel.Reserve(1);    //burada exception verir sonda mesaji yazir

        }
    }
}
