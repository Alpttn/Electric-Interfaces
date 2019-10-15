namespace ElectricInterfaces {
    public class Speakanator3001 : ITurnTable, ISpeaker
    {
        public double CurrentSpeed { get; set; }
        public bool IsPlaying { get; set;  }
        public int Volume { get; set; }
        bool ITurnTable.IsPlaying { get; set; }

        public void Play()
        {
            IsPlaying = true;
        }

        public void stop()
        {
            IsPlaying = false;
        }
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