using System;

namespace StatePattern
{
    public class Medium : LightSwitchState
    {
        public Medium(LightSwitch lightSwitch) : base(lightSwitch)
        {
        }

        public override void Push()
        {
            Console.WriteLine("załącz przekaźnik na 50%");

            lightSwitch.State = new Off(lightSwitch);
        }
    }
}
