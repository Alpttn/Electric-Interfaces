using System.Collections.Generic;

namespace ElectricInterfaces {
    public class Radio : IRadio, ISpeaker
    {
        public double CurrentFrequency { get; set; }
        public List<double> FavoriteStations { get; set; }
        public bool IsRadioOn { get; set; }
        public int Volume { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

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
         public void TurnRadioOff()
        {
            IsRadioOn = true;
        }
         public void VolumeDown()
        {
            Volume--;
        }

        public void VolumeUp()
        {
            Volume++;
        }
    }

}
