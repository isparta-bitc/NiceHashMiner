﻿using System;

namespace NHMCore.Notifications
{
    public enum NotificationsGroup
    {
        Misc,
        Market,
        Profit,
        MonitoringNvidiaElevate,
        [Obsolete("Unused group, ethlargement removed", true)]
        EthlargementElevate,
        [Obsolete("Unused group, ethlargement removed", true)]
        EthlargementNotEnabled,
        ConnectionLost,
        NoEnabledDevice,
        DemoMining,
        NoSma,
        [Obsolete]
        NoDeviceSelectedBenchmark,
        [Obsolete]
        NothingToBenchmark,
        FailedBenchmarks,
        NoSupportedDevices,
        MissingMiners,
        MissingMinerBins,
        [Obsolete]
        FailedVideoController,
        [Obsolete]
        WmiEnabled,
        [Obsolete]
        Net45,
        [Obsolete]
        BitOS64,
        NhmUpdate,
        NhmUpdateFailed,
        NhmWasUpdated,
        PluginUpdate,
        NvidiaDCH,
        WindowsDefenderException,
        ComputeModeAMD,
        LargePages,
        VirtualMemory,
        OpenClFallback,
        NoAvailableAlgorithms,
        LogArchiveUpload,
        MissingGPUs,
        NVMLInitFail,
        NVMLLoadFail,
        WrongChecksumBinary,
        WrongChecksumDll,
        MinerRestart,
        NullChecksum,
        GamingStarted,
        GamingFinished,
        AdminRunRequired,
        MotherboardNotCompatible,
        DriverVersionProblem,
        OptimizationWithProfilesDisabled,
        OptimizationProfilesElevate
    }
}
