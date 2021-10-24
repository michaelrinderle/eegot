
namespace eegot.Models.Emotive
{
    public class EmotiveSensorSummary
    {
        public string Title { get; set; }
        public string StartTimestamp { get; set; }
        public string StopTimestamp { get; set; }
        public string HeadsetType { get; set; }
        public string HeadsetSerial { get; set; }
        public string HeadsetFirmware { get; set; }
        public string Channels { get; set; }
        public string SamplingRate { get; set; }
        public string Samples { get; set; }
        public string Version { get; set; }
        public string Filler { get; set; }
    }
}
