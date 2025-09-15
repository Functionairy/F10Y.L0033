using System;


namespace F10Y.L0033.L000
{
    public static class Instances
    {
        public static L0020.ICommandLineOperator CommandLineOperator => L0020.CommandLineOperator.Instance;
        public static L0000.IConsoleOperator ConsoleOperator => L0000.ConsoleOperator.Instance;
        public static L0001.L000.IDateTimeOffsetOperator DateTimeOffsetOperator => L0001.L000.DateTimeOffsetOperator.Instance;
        public static L0001.L000.IDateTimeOperator DateTimeOperator => L0001.L000.DateTimeOperator.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0000.IExceptionOperator ExceptionOperator => L0000.ExceptionOperator.Instance;
        public static IJobDataKeys JobDataKeys => L000.JobDataKeys.Instance;
        public static IJobOperator JobOperator => L000.JobOperator.Instance;
        public static L0000.INullOperator NullOperator => L0000.NullOperator.Instance;
        public static L0000.ITimeSpanOperator TimeSpanOperator => L0000.TimeSpanOperator.Instance;
        public static ITriggerGenerator TriggerGenerator => L000.TriggerGenerator.Instance;
        public static ITriggers Triggers => L000.Triggers.Instance;
    }
}