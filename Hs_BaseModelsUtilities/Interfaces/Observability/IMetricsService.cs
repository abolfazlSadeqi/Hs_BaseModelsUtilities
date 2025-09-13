
namespace Hs_BaseModelsUtilities.Interfaces.Observability
{
    public interface IMetricsService
    {
        void TrackMetric(string name, double value);
        void TrackCounter(string name, int value = 1);
        void TrackGauge(string name, double value);
    }



}
