using CsvHelper;
using CsvHelper.Configuration;
using eegot.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace eegot.Models.Emotive
{
    public class EmotiveAnalyzer : IAnalyzer
    {
        private EmotiveSensorSummary Summary { get; set; }
        
        private List<EmotiveSensorData> RawData { get; set; }

        public List<EEGSensorData> LoadSamples(string file)
        {
            try
            {
                using (var reader = new StreamReader(file))
                {
                    var summaryTokens = reader.ReadLine().Split(",");
                    Summary = new EmotiveSensorSummary()
                    {
                        Title = summaryTokens[0].Split(":")[1],
                        StartTimestamp = summaryTokens[1].Split(":")[1],
                        StopTimestamp = summaryTokens[2].Split(":")[1],
                        HeadsetType = summaryTokens[3].Split(":")[1],
                        HeadsetSerial = summaryTokens[4].Split(":")[1],
                        HeadsetFirmware = summaryTokens[5].Split(":")[1],
                        Channels = summaryTokens[6].Split(":")[1],
                        SamplingRate = summaryTokens[7].Split(":")[1],
                        Samples = summaryTokens[8].Split(":")[1],
                        Version = summaryTokens[9].Split(":")[1],
                        // Filler = summaryTokens[10].Split(":")[1],
                    };

                    var backupFile = file + ".bak";
                    File.WriteAllText(backupFile, reader.ReadToEnd());

                    using (var reader2 = new StreamReader(backupFile))
                    {
                        using (var csv = new CsvReader(reader2, CultureInfo.InvariantCulture))
                        {
                            csv.Context.RegisterClassMap<EmotiveSensorDataClassMap>();
                            RawData = csv.GetRecords<EmotiveSensorData>().ToList();
                        }
                    }

                    File.Delete(backupFile);

                    return RawData.Select(x => new EEGSensorData
                    {
                        Timestamp = x.Timestamp,
                        AF3 = (double)x.EEGAF3,
                        AF4 = (double)x.EEGAF4,
                        Pz = (double)x.EEGPz,
                        T7 = (double)x.EEGT7,
                        T8 = (double)x.EEGT8
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public List<EEGSensorData> GetSamples()
        {
            return RawData.Select(x => new EEGSensorData
            {
                Timestamp = x.Timestamp,
                AF3 = (double)x.EEGAF3,
                AF4 = (double)x.EEGAF4,
                Pz = (double)x.EEGPz,
                T7 = (double)x.EEGT7,
                T8 = (double)x.EEGT8
            }).ToList();
        }
    }
}
