using System;

namespace StatePattern
{
    // Concrete State A
    public class Off : LightSwitchState
    {
        public Off(LightSwitch lightSwitch) : base(lightSwitch)
        {
        }

        public override void Push()
        {
            Console.WriteLine("załącz przekaźnik");

            lightSwitch.State = new Medium(lightSwitch);
        }
    }

  

}
