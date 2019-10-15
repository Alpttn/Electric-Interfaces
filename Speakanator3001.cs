namespace ElectricInterfaces
{
    public class Speakanator3001 : TurnTable //can play records and can hear the music
    {
        public int Volume { get; set; }

        public void VolumeUp()
        {
            Volume++;
        }
        public void VolumeDown()
        {
            Volume--;
        }
    }
}