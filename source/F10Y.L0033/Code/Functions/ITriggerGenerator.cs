using System;

using Quartz;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0033
{
    [FunctionsMarker]
    public partial interface ITriggerGenerator :
        L000.ITriggerGenerator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L000.ITriggerGenerator _L000 => L000.TriggerGenerator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        ITrigger OncePerDay_AtTime_Local(TimeOnly startTime_Local)
        {
            var startTime_Local_DateTime = Instances.TimeOnlyOperator.Get_NextDateTimeOffset_Local(startTime_Local);

            var output = this.OncePerDay_AtTime(startTime_Local_DateTime);
            return output;
        }
    }
}
