using System;

using Quartz;

using F10Y.T0002;


namespace F10Y.L0033.L000
{
    [FunctionsMarker]
    public partial interface IJobOperator
    {
        public DateTimeOffset Get_FireTime_UTC(IJobExecutionContext context)
            => context.FireTimeUtc;

        public DateTime Get_FireTime_Local(IJobExecutionContext context)
        {
            var fireTime_UTC = this.Get_FireTime_UTC(context);

            var output = Instances.DateTimeOffsetOperator.Get_Local(fireTime_UTC);
            return output;
        }

        public bool Has_Description(
            IJobExecutionContext context,
            out string description_OrNull)
        {
            description_OrNull = this.Get_Description_OrNull(context);

            var output = Instances.NullOperator.Is_NotNull(description_OrNull);
            return output;
        }

        public string Get_Description(IJobExecutionContext context)
        {
            var hasDescription = this.Has_Description(
                context,
                out var description_OrNull);

            if (!hasDescription)
            {
                throw Instances.ExceptionOperator.From("No description for job.");
            }

            return description_OrNull;
        }

        public string Get_Description_OrNull(IJobExecutionContext context)
            => context.JobDetail.Description;

        public string Get_JobDataValue_String(
            IJobExecutionContext context,
            string key)
        {
            var output = context.JobDetail.JobDataMap.GetString(
                JobDataKeys.Instance.ExecutableFilePath);

            return output;
        }

        public T Get_JobDataValue<T>(
            IJobExecutionContext context,
            string key)
            where T : class
        {
            var output = context.JobDetail.JobDataMap[key] as T;
            return output;
        }
    }
}
