namespace MassTransit.Contracts.Turnout
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Published when a job faults
    /// </summary>
    public interface JobFaulted
    {
        Guid JobId { get; }

        DateTime Timestamp { get; }

        IDictionary<string, object> Job { get; }

        ExceptionInfo Exceptions { get; }
    }
}
