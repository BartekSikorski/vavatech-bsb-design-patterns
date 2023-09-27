namespace StatePattern
{
    // Abstract State
    public abstract class LightSwitchState
    {
        protected LightSwitch lightSwitch;

        protected LightSwitchState(LightSwitch lightSwitch)
        {
            this.lightSwitch = lightSwitch;
        }

        // Handle
        public abstract void Push();
    }

  

}
