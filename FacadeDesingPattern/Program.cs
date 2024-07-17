using FacadeDesignPattern;

public class Program
{
    public static void Main(string[] args)
    {
        // Alt sistem bileşenlerini oluştur

        DvdPlayer dvdPlayer = new DvdPlayer();

        Projector projector = new Projector();

        SoundSystem soundSystem = new SoundSystem();

        Lights lights = new Lights();

        // Facade sınıfını oluştur ve kullan
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvdPlayer, projector, soundSystem, lights);

        homeTheater.WatchMovie("Inception");
        // Output:
        // Get ready to watch a movie...
        // Dimming lights to 10%.
        // Projector is on.
        // Projector is in widescreen mode.
        // Sound system is on.
        // Setting volume to 5.
        // DVD Player is on.
        // Playing movie: Inception

        homeTheater.EndMovie();
        // Output:
        // Shutting down the movie theater...
        // Stopping the DVD.
        // DVD Player is off.
        // Sound system is off.
        // Projector is off.
        // Lights are on.
    }
}
