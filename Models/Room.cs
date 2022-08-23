using System;
using System.Collections.Generic;
using System.Text;

namespace _23_08_2022Task.Models
{
    class Room
    {
        private  readonly int _id = 0;
        public int Id 
        {
            get { return _id; }
        }
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
        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (value>=0)
                {
                    _price = value;
                } 
            }
        }
        private int _personCapacity;

        public int PersonCapacity
        {
            get { return _personCapacity; }
            set 
            {
                if (value>0)
                {
                    _personCapacity = value;
                }
            }
        }
        public bool _isAvaible = true;
       



        public  Room(string name,double price,int personcapacity )
        {
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;
            _id++;
        }
        public string ShowInfo()
        {
            string info = "Room id:" + Id + " Room name:" + Name + " Room price:" + Price + " Room person capacity:" + PersonCapacity +  " Avaiability:" +_isAvaible ;
            return info;
        }
        public override string ToString()
        {
           return ShowInfo();
        }


    }
}
