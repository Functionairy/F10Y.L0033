using System;

using F10Y.T0003;


namespace F10Y.L0033.L000
{
    [ValuesMarker]
    public partial interface IJobDataKeys
    {
        /// <summary>
        /// <para><value>EmailList</value></para>
        /// </summary>
        public string EmailList => "EmailList";

        /// <summary>
        /// <para><value>ExecutableFilePath</value></para>
        /// </summary>
        public string ExecutableFilePath => "ExecutableFilePath";
    }
}
