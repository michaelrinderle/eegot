using eegot.Models;
using System.Collections.Generic;

namespace eegot.Interface
{
    public interface IAnalyzer
    {
        List<EEGSensorData> LoadSamples(string file);
        List<EEGSensorData> GetSamples();
    }
}
