using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Camp
    {
        private readonly int id;
        public int Latitude { get; private set; }
        public int Longitude { get; private set; }
        public int NumberOfPoeple { get; private set; }
        public int NumberOfTents { get; private set; }
        public int NumberOfFlashLights { get; private set; }
        private int LastCampId = 0;

        public Camp(int latitude, int longitude, int numberOfPoeple, int numberOfTents, int numberOfFlashLights)
        {
            
           
            Latitude = latitude;
            Longitude = longitude;
            NumberOfPoeple = numberOfPoeple;
            NumberOfTents = numberOfTents;
            NumberOfFlashLights = numberOfFlashLights;
            id = LastCampId;
            LastCampId++;
        }

        public override string ToString()
        {
            return $"id {id}, latitude {Latitude}, longitude {Longitude}, numberOfPoeple {NumberOfPoeple}, numberOfTents {NumberOfTents}, numberOfFlashLights {NumberOfFlashLights}";
        }

        public static bool operator ==(Camp pups1, Camp pups2)
        {
            if (ReferenceEquals(pups1, null) && ReferenceEquals(pups2, null))
            {
                return true;
            }
            if (ReferenceEquals(pups1, null) || ReferenceEquals(pups2, null))
            {
                return false;
            }
            if (pups1.id == pups2.id)
                return true;
            else
            return false;
        }
        public static bool operator !=(Camp pups1, Camp pups2)
        {
            return !(pups1 == pups2);
        }

        public static bool operator >(Camp pups1, Camp pups2)
        {
            
            if (pups1 == pups2)
                return false;

            return (pups1.NumberOfPoeple > pups2.NumberOfPoeple);
        }
        public static bool operator <(Camp pups1, Camp pups2)
        {
            
            if (pups1 == pups2)
                return false;

            return (pups2.NumberOfPoeple > pups1.NumberOfPoeple );
        }

        public override bool Equals(object obj)
        {
            Camp otherPoint = obj as Camp;
            if (otherPoint == null)
                return false;
            return (otherPoint.id == this.id);
        }

        public override int GetHashCode()
        {
            return id;
        }

        public static Camp operator +(Camp pups1, Camp pups2)
        {
            return new Camp(pups1.Latitude + pups2.Latitude, pups1.Longitude + pups2.Longitude, pups1.NumberOfPoeple + pups2.NumberOfPoeple, pups1.NumberOfTents + pups2.NumberOfTents, pups1.NumberOfFlashLights + pups2.NumberOfFlashLights);

        }
        public Camp()
        {

        }
    }
}

        
    

