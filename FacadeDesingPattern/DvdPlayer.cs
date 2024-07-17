using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class DvdPlayer
    {
        public void On() => Console.WriteLine("DVD Player is on.");
        public void Off() => Console.WriteLine("DVD Player is off.");
        public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
        public void Stop() => Console.WriteLine("Stopping the DVD.");
    }

    public class Projector
    {
        public void On() => Console.WriteLine("Projector is on.");
        public void Off() => Console.WriteLine("Projector is off.");
        public void WideScreenMode() => Console.WriteLine("Projector is in widescreen mode.");
    }

    public class SoundSystem
    {
        public void On() => Console.WriteLine("Sound system is on.");
        public void Off() => Console.WriteLine("Sound system is off.");
        public void SetVolume(int level) => Console.WriteLine($"Setting volume to {level}.");
    }

    public class Lights
    {
        public void Dim(int level) => Console.WriteLine($"Dimming lights to {level}%.");
        public void On() => Console.WriteLine("Lights are on.");
    }

}
