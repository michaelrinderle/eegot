using CsvHelper.Configuration;

namespace eegot.Models.Emotive
{
    public class EmotiveSensorData
    {
        public double Timestamp { get; set; }
        public double EEGCounter { get; set; }
        public double EEGInterpolated { get; set; }
        public double EEGAF3 { get; set; }
        public double EEGT7 { get; set; }
        public double EEGPz { get; set; }
        public double EEGT8 { get; set; }
        public double EEGAF4 { get; set; }
        public double EEGRawCq { get; set; }
        public double EEGBattery { get; set; }
        public double EEGBatteryPercent { get; set; }
        public string MarkerIndex { get; set; }
        public string MarkerType { get; set; }
        public string MarkerValueInt { get; set; }
        public double EEGMarkerHardware { get; set; }
        public double CQAF3 { get; set; }
        public double CQT7 { get; set; }
        public double CQPz { get; set; }
        public double CQT8 { get; set; }
        public double CQAF4 { get; set; }
        public double CQOverall { get; set; }
        public double? EQSampleRateQuality { get; set; }
        public double? EQOVERALL { get; set; }
        public double? EQAF3 { get; set; }
        public double? EQT7 { get; set; }
        public double? EQPz { get; set; }
        public double? EQT8 { get; set; }
        public double? EQAF4 { get; set; }
        public double MOTCounterMems { get; set; }
        public double MOTInterpolatedMems { get; set; }
        public double MOTGyroX { get; set; }
        public double MOTGyroY { get; set; }
        public double MOTGyroZ { get; set; }
        public double MOTAccX { get; set; }
        public double MOTAccY { get; set; }
        public double MOTAccZ { get; set; }
        public double MOTMagX { get; set; }
        public double MOTMagY { get; set; }
        public double MOTMagZ { get; set; }
        public double? MCAction { get; set; }
        public double? MCActionPower { get; set; }
        public double? MCIsActive { get; set; }
        public string PMEngagementIsActive { get; set; }
        public string PMEngagementScaled { get; set; }
        public string PMEngagementRaw { get; set; }
        public string PMEngagementMin { get; set; }
        public string PMEngagementMax { get; set; }
        public string PMExcitementIsActive { get; set; }
        public string PMExcitementScaled { get; set; }
        public string PMExcitementRaw { get; set; }
        public string PMExcitementMin { get; set; }
        public string PMExcitementMax { get; set; }
        public string PMLongTermExcitement { get; set; }
        public string PMStressIsActive { get; set; }
        public string PMStressScaled { get; set; }
        public string PMStressRaw { get; set; }
        public string PMStressMin { get; set; }
        public string PMStressMax { get; set; }
        public string PMRelaxationIsActive { get; set; }
        public string PMRelaxationScaled { get; set; }
        public string PMRelaxationRaw { get; set; }
        public string PMRelaxationMin { get; set; }
        public string PMRelaxationMax { get; set; }
        public string PMInterestIsActive { get; set; }
        public string PMInterestScaled { get; set; }
        public string PMInterestRaw { get; set; }
        public string PMInterestMin { get; set; }
        public string PMInterestMax { get; set; }
        public string PMFocusIsActive { get; set; }
        public string PMFocusScaled { get; set; }
        public string PMFocusRaw { get; set; }
        public string PMFocusMin { get; set; }
        public string PMFocusMax { get; set; }
        public double? FEBlinkWink { get; set; }
        public double? FEHorizontalEyesDirection { get; set; }
        public double? FEUpperFaceAction { get; set; }
        public string FEUpperFaceActionPower { get; set; }
        public double? FELowerFaceAction { get; set; }
        public double? FELowerFaceActionPower { get; set; }
        public string POWAF3Theta { get; set; }
        public string POWAF3Alpha { get; set; }
        public string POWAF3BetaL { get; set; }
        public string POWAF3BetaH { get; set; }
        public string POWAF3Gamma { get; set; }
        public string POWT7Theta { get; set; }
        public string POWT7Alpha { get; set; }
        public string POWT7BetaL { get; set; }
        public string POWT7BetaH { get; set; }
        public string POWT7Gamma { get; set; }
        public string POWPzTheta { get; set; }
        public string POWPzAlpha { get; set; }
        public string POWPzBetaL { get; set; }
        public string POWPzBetaH { get; set; }
        public string POWPzGamma { get; set; }
        public string POWT8Theta { get; set; }
        public string POWT8Alpha { get; set; }
        public string POWT8BetaL { get; set; }
        public string POWT8BetaH { get; set; }
        public string POWT8Gamma { get; set; }
        public string POWAF4Theta { get; set; }
        public string POWAF4Alpha { get; set; }
        public string POWAF4BetaL { get; set; }
        public string POWAF4BetaH { get; set; }
        public string POWAF4Gamma { get; set; }
    }

    public class EmotiveSensorDataClassMap : ClassMap<EmotiveSensorData>
    {
        public EmotiveSensorDataClassMap()
        {
            Map(m => m.Timestamp).Name("Timestamp");
            Map(m => m.EEGCounter).Name("EEG.Counter");
            Map(m => m.EEGInterpolated).Name("EEG.Interpolated");
            Map(m => m.EEGAF3).Name("EEG.AF3");
            Map(m => m.EEGT7).Name("EEG.T7");
            Map(m => m.EEGPz).Name("EEG.Pz");
            Map(m => m.EEGT8).Name("EEG.T8");
            Map(m => m.EEGAF4).Name("EEG.AF4");
            Map(m => m.EEGRawCq).Name("EEG.RawCq");
            Map(m => m.EEGBattery).Name("EEG.Battery");
            Map(m => m.EEGBatteryPercent).Name("EEG.BatteryPercent");
            Map(m => m.MarkerIndex).Name("MarkerIndex");
            Map(m => m.MarkerType).Name("MarkerType");
            Map(m => m.MarkerValueInt).Name("MarkerValueInt");
            Map(m => m.EEGMarkerHardware).Name("EEG.MarkerHardware");
            Map(m => m.CQAF3).Name("CQ.AF3");
            Map(m => m.CQT7).Name("CQ.T7");
            Map(m => m.CQPz).Name("CQ.Pz");
            Map(m => m.CQT8).Name("CQ.T8");
            Map(m => m.CQAF4).Name("CQ.AF4");
            Map(m => m.CQOverall).Name("CQ.Overall");
            Map(m => m.EQSampleRateQuality).Name("EQ.SampleRateQuality");
            Map(m => m.EQOVERALL).Name("EQ.OVERALL");
            Map(m => m.EQAF3).Name("EQ.AF3");
            Map(m => m.EQT7).Name("EQ.T7");
            Map(m => m.EQPz).Name("EQ.Pz");
            Map(m => m.EQT8).Name("EQ.T8");
            Map(m => m.EQAF4).Name("EQ.AF4");
            Map(m => m.MOTCounterMems).Name("MOT.CounterMems");
            Map(m => m.MOTInterpolatedMems).Name("MOT.InterpolatedMems");
            Map(m => m.MOTGyroX).Name("MOT.GyroX");
            Map(m => m.MOTGyroY).Name("MOT.GyroY");
            Map(m => m.MOTGyroZ).Name("MOT.GyroZ");
            Map(m => m.MOTAccX).Name("MOT.AccX");
            Map(m => m.MOTAccY).Name("MOT.AccY");
            Map(m => m.MOTAccZ).Name("MOT.AccZ");
            Map(m => m.MOTMagX).Name("MOT.MagX");
            Map(m => m.MOTMagY).Name("MOT.MagY");
            Map(m => m.MOTMagZ).Name("MOT.MagZ");
            Map(m => m.MCAction).Name("MC.Action");
            Map(m => m.MCActionPower).Name("MC.ActionPower");
            Map(m => m.MCIsActive).Name("MC.IsActive");
            Map(m => m.PMEngagementIsActive).Name("PM.Engagement.IsActive");
            Map(m => m.PMEngagementScaled).Name("PM.Engagement.Scaled");
            Map(m => m.PMEngagementRaw).Name("PM.Engagement.Raw");
            Map(m => m.PMEngagementMin).Name("PM.Engagement.Min");
            Map(m => m.PMEngagementMax).Name("PM.Engagement.Max");
            Map(m => m.PMExcitementIsActive).Name("PM.Excitement.IsActive");
            Map(m => m.PMExcitementScaled).Name("PM.Excitement.Scaled");
            Map(m => m.PMExcitementRaw).Name("PM.Excitement.Raw");
            Map(m => m.PMExcitementMin).Name("PM.Excitement.Min");
            Map(m => m.PMExcitementMax).Name("PM.Excitement.Max");
            Map(m => m.PMLongTermExcitement).Name("PM.LongTermExcitement");
            Map(m => m.PMStressIsActive).Name("PM.Stress.IsActive");
            Map(m => m.PMStressScaled).Name("PM.Stress.Scaled");
            Map(m => m.PMStressRaw).Name("PM.Stress.Raw");
            Map(m => m.PMStressMin).Name("PM.Stress.Min");
            Map(m => m.PMStressMax).Name("PM.Stress.Max");
            Map(m => m.PMRelaxationIsActive).Name("PM.Relaxation.IsActive");
            Map(m => m.PMRelaxationScaled).Name("PM.Relaxation.Scaled");
            Map(m => m.PMRelaxationRaw).Name("PM.Relaxation.Raw");
            Map(m => m.PMRelaxationMin).Name("PM.Relaxation.Min");
            Map(m => m.PMRelaxationMax).Name("PM.Relaxation.Max");
            Map(m => m.PMInterestIsActive).Name("PM.Interest.IsActive");
            Map(m => m.PMInterestScaled).Name("PM.Interest.Scaled");
            Map(m => m.PMInterestRaw).Name("PM.Interest.Raw");
            Map(m => m.PMInterestMin).Name("PM.Interest.Min");
            Map(m => m.PMInterestMax).Name("PM.Interest.Max");
            Map(m => m.PMFocusIsActive).Name("PM.Focus.IsActive");
            Map(m => m.PMFocusScaled).Name("PM.Focus.Scaled");
            Map(m => m.PMFocusRaw).Name("PM.Focus.Raw");
            Map(m => m.PMFocusMin).Name("PM.Focus.Min");
            Map(m => m.PMFocusMax).Name("PM.Focus.Max");
            Map(m => m.FEBlinkWink).Name("FE.BlinkWink");
            Map(m => m.FEHorizontalEyesDirection).Name("FE.HorizontalEyesDirection");
            Map(m => m.FEUpperFaceAction).Name("FE.UpperFaceAction");
            Map(m => m.FEUpperFaceActionPower).Name("FE.UpperFaceActionPower");
            Map(m => m.FELowerFaceAction).Name("FE.LowerFaceAction");
            Map(m => m.FELowerFaceActionPower).Name("FE.LowerFaceActionPower");
            Map(m => m.POWAF3Theta).Name("POW.AF3.Theta");
            Map(m => m.POWAF3Alpha).Name("POW.AF3.Alpha");
            Map(m => m.POWAF3BetaL).Name("POW.AF3.BetaL");
            Map(m => m.POWAF3BetaH).Name("POW.AF3.BetaH");
            Map(m => m.POWAF3Gamma).Name("POW.AF3.Gamma");
            Map(m => m.POWT7Theta).Name("POW.T7.Theta");
            Map(m => m.POWT7Alpha).Name("POW.T7.Alpha");
            Map(m => m.POWT7BetaL).Name("POW.T7.BetaL");
            Map(m => m.POWT7BetaH).Name("POW.T7.BetaH");
            Map(m => m.POWT7Gamma).Name("POW.T7.Gamma");
            Map(m => m.POWPzTheta).Name("POW.Pz.Theta");
            Map(m => m.POWPzAlpha).Name("POW.Pz.Alpha");
            Map(m => m.POWPzBetaL).Name("POW.Pz.BetaL");
            Map(m => m.POWPzBetaH).Name("POW.Pz.BetaH");
            Map(m => m.POWPzGamma).Name("POW.Pz.Gamma");
            Map(m => m.POWT8Theta).Name("POW.T8.Theta");
            Map(m => m.POWT8Alpha).Name("POW.T8.Alpha");
            Map(m => m.POWT8BetaL).Name("POW.T8.BetaL");
            Map(m => m.POWT8BetaH).Name("POW.T8.BetaH");
            Map(m => m.POWT8Gamma).Name("POW.T8.Gamma");
            Map(m => m.POWAF4Theta).Name("POW.AF4.Theta");
            Map(m => m.POWAF4Alpha).Name("POW.AF4.Alpha");
            Map(m => m.POWAF4BetaL).Name("POW.AF4.BetaL");
            Map(m => m.POWAF4BetaH).Name("POW.AF4.BetaH");
            Map(m => m.POWAF4Gamma).Name("POW.AF4.Gamma");
        }
    }
}
