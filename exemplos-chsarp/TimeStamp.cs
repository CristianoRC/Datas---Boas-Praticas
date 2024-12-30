using System;

namespace exemplos_chsarp;

public static class TimeStamp
{
    public static void Run()
    {
        var unixEpochsSeconds = DateTimeOffset.UnixEpoch.ToUnixTimeSeconds();
        var unixEpoch = DateTimeOffset.FromUnixTimeSeconds(unixEpochsSeconds);
        
        var nowTicks = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        var now = DateTimeOffset.FromUnixTimeMilliseconds(nowTicks);
    }
}