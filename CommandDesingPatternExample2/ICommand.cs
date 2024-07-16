using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesingPatternExample2
{
    // Command arayüzü
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver sınıfı
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is OFF");
        }
    }

    // ConcreteCommand sınıfları

    public class TurnOnLightCommand : ICommand
    {
        private Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public void Undo()
        {
            _light.TurnOff();
        }
    }

    public class TurnOffLightCommand : ICommand
    {
        private Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }

        public void Undo()
        {
            _light.TurnOn();
        }
    }

    // Invoker sınıfı
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }

        public void PressUndo()
        {
            _command.Undo();
        }
    }

    // Kullanım
    public class Program
    {
        public static void Main(string[] args)
        {
            Light livingRoomLight = new Light();
            ICommand turnOn = new TurnOnLightCommand(livingRoomLight);
            ICommand turnOff = new TurnOffLightCommand(livingRoomLight);

            RemoteControl remote = new RemoteControl();
            remote.SetCommand(turnOn);
            remote.PressButton(); // Light is ON
            remote.PressUndo();   // Light is OFF

            remote.SetCommand(turnOff);
            remote.PressButton(); // Light is OFF
            remote.PressUndo();   // Light is ON
        }
    }
}