using System;


namespace F10Y.L0033.L000
{
    public class JobDataKeys : IJobDataKeys
    {
        #region Infrastructure

        public static IJobDataKeys Instance { get; } = new JobDataKeys();


        private JobDataKeys()
        {
        }

        #endregion
    }
}
