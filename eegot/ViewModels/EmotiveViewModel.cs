using eegot.enums;
using eegot.Interface;
using eegot.Models;
using eegot.Models.Emotive;
using ScottPlot;
using System;
using System.Collections.ObjectModel;

namespace eegot.ViewModels
{
    public class EmotiveViewModel : BaseViewModel, IDisposable, IObserver
    {
        public IAnalyzer Parser { get; set; }

        private ObservableCollection<Algorithm> _AlgorithmTypes = new ObservableCollection<Algorithm>()
        {
           new Algorithm()
           {
               Title = "Raw Data",
               Type = enums.AlgorithmType.RAW_DATA
           },
           new Algorithm()
           {
               Title = "Approximate",
               Type = enums.AlgorithmType.APPROXIMATE
           }
        };
        public ObservableCollection<Algorithm> AlgorithmTypes
        {
            get => _AlgorithmTypes;
        }

        private Algorithm _Algorithm;
        public Algorithm Algorithm
        {
            get 
            {
                if(_Algorithm == null)
                {
                    _Algorithm = _AlgorithmTypes[0];
                }
                return _Algorithm;
            }
            set
            {
                _Algorithm = value;
                OnPropertyChanged(nameof(_Algorithm));
                this.PlotAlgorithm(_Algorithm.Type);
            }
        }

        private WpfPlot _DataPlot { get; set; }
        public WpfPlot DataPlot
        {
            get => _DataPlot;
            set
            {
                _DataPlot = value;
                OnPropertyChanged(nameof(DataPlot));
            }
        }

        public EmotiveViewModel()
        {
            MainWindowViewModel.ImportSubject.RegisterObserver(this);
            Parser = new EmotiveAnalyzer();
        }



        private void PlotAlgorithm(AlgorithmType type)
        {
            var eeg = Parser.GetSamples();
            if (eeg == null) return;

            switch (type)
            {
                case AlgorithmType.RAW_DATA:
                    {
                        PlotRawData();
                        break;
                    }
            }
        }


        public void PlotRawData()
        {
            var eeg = Parser.GetSamples();
            if (eeg == null) return;

            double[] a3 = new double[eeg.Count];
            double[] a4 = new double[eeg.Count];
            double[] pz = new double[eeg.Count];
            double[] t7 = new double[eeg.Count];
            double[] t8 = new double[eeg.Count];

            for (int i = 0; i < eeg.Count; i++)
            {
                a3[i] = eeg[i].AF3;
                a4[i] = eeg[i].AF4;
                pz[i] = eeg[i].Pz;
                t7[i] = eeg[i].T7;
                t8[i] = eeg[i].T8;
            }

            DataPlot = new WpfPlot();

            DataPlot.Plot.AddSignal(a3, 1, label:"a3");
            DataPlot.Plot.AddSignal(a4, 1, label:"a4");
            DataPlot.Plot.AddSignal(pz, 1, label:"pz");
            DataPlot.Plot.AddSignal(t7, 1, label: "t7");
            DataPlot.Plot.AddSignal(t8, 1, label: "t8");

            DataPlot.Plot.Legend();

            DataPlot.Plot.XAxis2.Label("EEG Raw Data");
            DataPlot.Plot.XAxis.Label("Timestamp");
            DataPlot.Plot.YAxis.Label("Raw Signal");

            DataPlot.Refresh();
        }

        public void PlotActionPotentials()
        {

        }

        public void passString(string path)
        {
            var eeg = Parser.LoadSamples(path);
            PlotAlgorithm(Algorithm.Type);
        }     

        public void Dispose()
        {
            MainWindowViewModel.ImportSubject.RemoveObserver(this);
        }
    }
}
