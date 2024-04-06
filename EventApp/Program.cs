using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp = new Lamp();
            lamp.TurnedOn += ReactionOnTurnOn;
            lamp.TurnOn();
            
        }
        public static void ReactionOnTurnOn(object sender, EventArgs e)
        {
            InfoEventArgs info = e as InfoEventArgs;
            Console.WriteLine(info.Color);

        }
    }
    class InfoEventArgs : EventArgs
    {
        public string Color
        {
            set;
            get;
        }

    }

    class Lamp
    {
        public event EventHandler TurnedOn;

        public void TurnOn()
        {
            if (TurnedOn != null)
            {
                TurnedOn(this, new InfoEventArgs() { Color = "Red"});
            }
        }
    }
}
