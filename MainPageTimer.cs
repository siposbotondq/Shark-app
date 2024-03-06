using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Timers;
using Xamarin.Forms;

namespace Shark
{
    public class MainPageTimer : INotifyPropertyChanged
    {
        Stopwatch stopWatch = new Stopwatch();
        private Timer time = new Timer();
        private bool timerRunning;

        private string _stopWatchHours;
        public string StopWatchHours
        {
            get { return _stopWatchHours; }
            set
            {
                _stopWatchHours = value;
                OnPropertyChanged("StopWatchHours");
            }
        }
        private string _stopWatchMinutes;
        public string StopWatchMinutes
        {
            get { return _stopWatchMinutes; }
            set
            {
                _stopWatchMinutes = value;
                OnPropertyChanged("StopWatchMinutes");
            }
        }
        private string _stopWatchSeconds;
        public string StopWatchSeconds
        {
            get { return _stopWatchSeconds; }
            set
            {
                _stopWatchSeconds = value;
                OnPropertyChanged("StopWatchSeconds");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainPageTimer()
        {
            stopWatch.Start();
            StopWatchHours = stopWatch.Elapsed.Hours.ToString();
            StopWatchMinutes = stopWatch.Elapsed.Minutes.ToString();
            StopWatchSeconds = stopWatch.Elapsed.Seconds.ToString();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                StopWatchHours = stopWatch.Elapsed.Hours.ToString();
                StopWatchMinutes = stopWatch.Elapsed.Minutes.ToString();
                StopWatchSeconds = stopWatch.Elapsed.Seconds.ToString();
                return true;
            });

        }
        public void ResetTimer()
        {
            stopWatch.Reset();
        }
        public void StopTimer()
        {
            stopWatch.Stop();
        }
        
        public void StartTimer()
        {
            stopWatch.Start();
        }

    }
    
}