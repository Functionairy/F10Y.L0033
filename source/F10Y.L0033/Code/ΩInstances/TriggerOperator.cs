using System;


namespace F10Y.L0033
{
    public class TriggerOperator : ITriggerOperator
    {
        #region Infrastructure

        public static ITriggerOperator Instance { get; } = new TriggerOperator();


        private TriggerOperator()
        {
        }

        #endregion
    }
}
