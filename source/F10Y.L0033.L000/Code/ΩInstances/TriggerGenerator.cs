using System;


namespace F10Y.L0033.L000
{
    public class TriggerGenerator : ITriggerGenerator
    {
        #region Infrastructure

        public static ITriggerGenerator Instance { get; } = new TriggerGenerator();


        private TriggerGenerator()
        {
        }

        #endregion
    }
}
