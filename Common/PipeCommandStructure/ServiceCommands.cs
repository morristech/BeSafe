namespace Common.PipeCommandStructure
{
    public enum ServiceCommands
    {
        Stop = 0,
        Start = 1,

        StopProcessWatcher = 40,
        StartProcessWatcher = 41,

        StopModuleWatcher = 50,
        StartModuleWatcher = 51,

        StopYaraEngine = 60,
        StartYaraEngine = 61,

        StopSecureVolume = 70,
        StartSecureVolume = 71,

        StopStaticEngine = 80,
        StartStaticEngine = 81,

        StopDynamicEngine = 90,
        StartDynamicEngine = 91,

        StopVTEngine = 100,
        StartVTEngine = 101,
    }
}