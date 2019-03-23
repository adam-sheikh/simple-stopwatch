using System;
using System.Collections;
using System.Collections.Generic;

namespace Classes
{
    public class StopWatch
    {
        private bool IsRunning { set; get; }
        private bool IsPaused { get; set; }

        private TimeSpan _duration, _pauseDuration;
        private DateTime _startTime, _pauseTime, _resumeTime;

        public void Start()
        {
            if ((IsRunning == false) && (IsPaused == false))
            {
                IsRunning = true;
                _startTime = DateTime.Now;
                Console.WriteLine("Stopwatch start time: {0}\n", _startTime);
            }
            else
            {
                Console.WriteLine("Stopwatch is already running");
            }
        }

        public void Pause()
        {
            if((IsPaused == false) && (IsRunning == true))
            {
                IsPaused = true;
                IsRunning = false;
                _pauseTime = DateTime.Now;
                Console.WriteLine("Stopwatch paused");
            }
            else
            {
                Console.WriteLine("Stop watch is not running");
            }
        }

        public void Resume()
        {
            if((IsRunning == false))
            {
                if (IsPaused == true)
                {
                    _resumeTime = DateTime.Now;
                    _pauseDuration = _pauseDuration.Add(_resumeTime - _pauseTime);
                    IsPaused = false;
                    IsRunning = true;
                    Console.WriteLine("Stopwatch resumed");
                }
                else
                {
                    Console.WriteLine("Stopwatch is not currently paused");
                }
            }
            else
            {
                Console.WriteLine("Stopwatch is running");
            }
        }

        public void Stop()
        {
            if (IsRunning == true)
            {
                _duration = DateTime.Now - _startTime;
                _duration = _duration.Subtract(_pauseDuration);
                IsRunning = false;
                IsPaused = false;
                DisplayDuration();
            }
            else
            {
                Console.WriteLine("Stopwatch is not currently running");
            }
        }

        public void DisplayDuration()
        {
            Console.WriteLine("Total time: {0}", _duration);
        }

    }
}
