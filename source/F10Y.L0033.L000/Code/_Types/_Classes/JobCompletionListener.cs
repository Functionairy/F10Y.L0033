using System;
using System.Threading;
using System.Threading.Tasks;

using Quartz;
using Quartz.Listener;


namespace F10Y.L0033.L000
{
    /// <summary>
    /// Converts a listener invocation to an event invocation.
    /// </summary>
    public class JobCompletionListener : JobListenerSupport
    {
        public override string Name => nameof(JobCompletionListener);

        public event EventHandler<IScheduler> Job_WasExecuted;

        public override Task JobWasExecuted(
            IJobExecutionContext context,
            JobExecutionException jobException,
            CancellationToken cancellationToken = default)
        {
            this.Job_WasExecuted?.Invoke(this, context.Scheduler);

            return base.JobWasExecuted(context, jobException, cancellationToken);
        }
    }
}
