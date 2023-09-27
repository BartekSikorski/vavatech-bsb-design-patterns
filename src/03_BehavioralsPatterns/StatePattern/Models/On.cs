using System;

namespace StatePattern
{
    // Concrete State B
    public class On : LightSwitchState
    {
        public On(LightSwitch lightSwitch) : base(lightSwitch)
        {
        }

        public override void Push()
        {
            Console.WriteLine("wyłącz przekaźnik");

            lightSwitch.State = new Medium(lightSwitch);
        }
    }
}
