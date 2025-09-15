using System;
using System.Threading.Tasks;

using Quartz;
using Quartz.Impl;

using F10Y.T0002;


namespace F10Y.L0033.L000
{
    [FunctionsMarker]
    public partial interface ISchedulerOperator
    {
        public async Task<IScheduler> Start_Scheduler(Func<IScheduler, Task> configureSchedulerAction)
        {
            // Grab the Scheduler instance from the Factory
            var factory = new StdSchedulerFactory();

            var scheduler = await factory.GetScheduler();

            await configureSchedulerAction(scheduler);

            await scheduler.Start();

            return scheduler;
        }

        public async Task Run_Job(IJobDetail job)
        {
            var trigger = Instances.Triggers.Now;

            var listener = new JobCompletionListener();

            static async void Listener_Job_WasExecuted(object sender, IScheduler scheduler)
            {
                await scheduler.Shutdown();
            }

            listener.Job_WasExecuted += Listener_Job_WasExecuted;

            var scheduler = await this.Start_Scheduler(async scheduler =>
            {
                scheduler.ListenerManager.AddJobListener(listener);

                var scheduledTime = await scheduler.ScheduleJob(
                    job,
                    trigger);

                Instances.ConsoleOperator.Write_Line($"Next Scheduled Time: {scheduledTime.UtcDateTime} (UTC), {scheduledTime.LocalDateTime} (Local)");
            });

            while (!scheduler.IsShutdown)
            {
                // Infinite loop.
            }
        }
    }
}
