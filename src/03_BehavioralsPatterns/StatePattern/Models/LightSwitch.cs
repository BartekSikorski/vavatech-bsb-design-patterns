using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Channels;

namespace StatePattern
{

    // Context
    public class LightSwitch
    {
        private LightSwitchState state;
        public LightSwitchState State { 
            get
            {
                return state;
            }

            set
            {
                Console.WriteLine($"{state} -> {value}");

                state = value;
            }
        }

        public LightSwitch()
        {
            State = new Off(this);
        }

        public void Push() => State.Push();
    }


    public class Lamp
    {
        private Dictionary<string, Action> states = new Dictionary<string, Action>();

        public void Trigger(string state)
        {

        }

        public Lamp()
        {
            states.Add("ON", () => Console.WriteLine("->on"));
            states.Add("OFF", () => Console.WriteLine("->off"));
        }

    }
  

}
