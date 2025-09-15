using System;


namespace F10Y.L0033.L000
{
    public class Triggers : ITriggers
    {
        #region Infrastructure

        public static ITriggers Instance { get; } = new Triggers();


        private Triggers()
        {
        }

        #endregion
    }
}
