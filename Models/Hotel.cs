using _23_08_2022Task.Utilies.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _23_08_2022Task.Models
{
    class Hotel
    {
        private int _count;
        private string _name;
        public string Name 
        {
            get 
            {
                return _name;
            }
            set 
            {
                if (value.Length>0)
                {
                    _name = value;
                }
            }
        }
        private Room[] _rooms;
        public Hotel(string name, int length)
        {
            Name = name;
            _rooms = new Room[length];
        }
       
        public Room this[int index] 
        {
            get 
            {
                if (index<_rooms.Length)
                {
                    return _rooms[index];
                }
                throw new NotFoundException("Room is not found");
                
            }
            set 
            {
                if (index < _rooms.Length)
                {
                    _rooms[index]=value;
                    return;
                }
                throw new Exception();

            }
        }
        public void AddRoom(Room room) 
        {
            if (_count < _rooms.Length)
            {
                _rooms[_count] = room;
                _count++;
            }
            else 
            {
                Console.WriteLine("There is not any place for additional room");
            }
          
        }
        public void Reserve(int? roomId) 
        {
            foreach (Room room in _rooms)
            {
                if (room.Id == roomId)
                {
                    if (room._isAvaible)
                    {
                        room._isAvaible = false;
                        Console.WriteLine("Room is reserved");
                        return;
                    }
                    throw new NotAvailableException("Room was reserved by other customers.Please try to find new room!");
                }
            }
            throw new NotFoundException("There is not any room with this id");
            

        }
        
        




    }
}
