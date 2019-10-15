namespace ElectricInterfaces
{
    public interface ISpeaker 
    {
         int Volume { get; set; }

         void VolumeUp()
        {
            Volume++;
        }
         void VolumeDown()
        {
            Volume--;
        }
    }
}