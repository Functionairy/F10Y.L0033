using System;

using Quartz;

using F10Y.T0003;


namespace F10Y.L0033.L000
{
    [ValuesMarker]
    public partial interface ITriggers
    {
        ITrigger Now => Instances.TriggerGenerator.Now();
    }
}
