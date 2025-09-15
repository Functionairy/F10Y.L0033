using System;


namespace F10Y.L0033.L000
{
    public class JobOperator : IJobOperator
    {
        #region Infrastructure

        public static IJobOperator Instance { get; } = new JobOperator();


        private JobOperator()
        {
        }

        #endregion
    }
}
