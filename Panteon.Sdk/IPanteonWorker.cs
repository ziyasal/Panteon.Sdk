﻿using System;
using Panteon.Sdk.Models;

namespace Panteon.Sdk
{
    public interface IPanteonWorker
    {
        string Name { get; }
        bool Init(bool autoRun);
        bool Stop();
        bool Start(DateTimeOffset lastKnownEvent = default(DateTimeOffset));
        void Pause(TimeSpan duration);
        bool Update(ScheduleInfo scheduleInfo);

        PanteonTaskInfo Inspect();
        void Progress(ProgressMessage message);
    }
}