namespace ElectricInterfaces
{
    public interface ITurnTable
    {
        double CurrentSpeed { get; set; }
        bool IsPlaying { get; set; }
        void Play();
    
        void stop();
        
    }
}