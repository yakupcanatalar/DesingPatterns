using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class HomeTheaterFacade
    {
        private readonly DvdPlayer _dvdPlayer;
        private readonly Projector _projector;
        private readonly SoundSystem _soundSystem;
        private readonly Lights _lights;

        public HomeTheaterFacade(DvdPlayer dvdPlayer, Projector projector, SoundSystem soundSystem, Lights lights)
        {
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _soundSystem = soundSystem;
            _lights = lights;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _lights.Dim(10);
            _projector.On();
            _projector.WideScreenMode();
            _soundSystem.On();
            _soundSystem.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the movie theater...");
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
            _soundSystem.Off();
            _projector.Off();
            _lights.On();
        }
    }

}
