using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQCounter
{
    internal class CounterOut
    {
        private static NationalInstruments.DAQmx.Task coTask = new NationalInstruments.DAQmx.Task();

        public bool Enabled { get; private set; }

        public CounterOut()
        {
            this.Enabled = false;
            coTask.Timing.ConfigureImplicit(SampleQuantityMode.ContinuousSamples);
        }

        public void Start()
        {
            this.Enabled = true;
        }

        public void Stop()
        {
            this.Enabled = false;
        }

        public void DisposeTask()
        {
            coTask?.Dispose();
        }
    }
}
