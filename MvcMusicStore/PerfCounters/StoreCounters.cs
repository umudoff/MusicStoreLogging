using PerformanceCounterHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MvcMusicStore.PerfCounters
{
    [PerformanceCounterCategory("MVCMusicStore", System.Diagnostics.PerformanceCounterCategoryType.MultiInstance, "Perf counters for store")]
    public enum StoreCounters
    {
        [PerformanceCounter("Go to Home count", "Go to Home", PerformanceCounterType.NumberOfItems32)]
        GoToHome=0
    }
}