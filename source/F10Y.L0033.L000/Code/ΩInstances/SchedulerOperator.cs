using System;


namespace F10Y.L0033.L000
{
    public class SchedulerOperator : ISchedulerOperator
    {
        #region Infrastructure

        public static ISchedulerOperator Instance { get; } = new SchedulerOperator();


        private SchedulerOperator()
        {
        }

        #endregion
    }
}
