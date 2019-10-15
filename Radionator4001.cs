using System.Collections.Generic;

namespace ElectricInterfaces
{
    public class Radionator4001 : Speakanator3001 //could play it and have a radio, this is also a turntable
    {
        public double CurrentFrequency { get; set; }
        public List<double> FavoriteStations { get; set; } = new List<double>();
        //you could also do this in a constructor
        public bool IsRadioOn { get; set; }


        public void AddFavorite(double station)
        {
            FavoriteStations.Add(station);
        }
        public void RemoveFavorite(double station)
        {
            FavoriteStations.Remove(station);
        }

        public void TurnRadioOn()
        {
            IsRadioOn = false;
        }

    }
}