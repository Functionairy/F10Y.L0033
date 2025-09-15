using System;

using Quartz;

using F10Y.T0002;


namespace F10Y.L0033.L000
{
    [FunctionsMarker]
    public partial interface ITriggerGenerator
    {
        ITrigger Now()
        {
            var output = TriggerBuilder.Create()
                .StartNow()
                .Build();

            return output;
        }

        ITrigger OncePerDay_AtTime(DateTimeOffset startTime)
        {
            var output = TriggerBuilder.Create()
                .StartAt(startTime)
                .WithCalendarIntervalSchedule(scheduleBuilder => scheduleBuilder
                    .WithIntervalInDays(1)
                )
                .Build();

            return output;
        }

        ITrigger OncePerDay_AtTime_Local(DateTime startTime_Local)
        {
            var startTime = Instances.DateTimeOffsetOperator.Get_Utc_ForLocal(startTime_Local);

            var output = this.OncePerDay_AtTime(startTime);
            return output;
        }
    }
}
