namespace Hs_BaseModelsUtilities.Enums.MONITORING
{
    /// <summary>
    /// Logger providers.
    /// </summary>
    public enum LoggerProvider
        {
            Serilog = 1,
            NLog = 2,
            Log4Net = 3,
            Seq = 4,
            ELK = 5,
            ApplicationInsights = 6,
            Datadog = 7
        }
    }
