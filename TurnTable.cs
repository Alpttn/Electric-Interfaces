namespace ElectricInterfaces
{
    public class TurnTable //bass class can play records
    {
        public double CurrentSpeed { get; set; }
        public bool IsPlaying { get; set; }
        public void Play()
        {
            IsPlaying = true;
        }

        public void stop() 
        {
            IsPlaying = false;
        }
    }
}