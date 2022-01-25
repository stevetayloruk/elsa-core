using System;
using Elsa.Scheduling.Contracts;

namespace Elsa.Scheduling.Schedules;

public record RecurringSchedule(DateTime StartAt, TimeSpan Interval) : ISchedule;