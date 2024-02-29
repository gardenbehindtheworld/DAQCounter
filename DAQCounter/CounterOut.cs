using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQCounter
{
    internal class CounterOut
    {
        private static NationalInstruments.DAQmx.Task coTask = new NationalInstruments.DAQmx.Task();

        public bool Enabled { get; private set; }

        public CounterOut()
        {
            this.Enabled = false;
        }

        public void Start()
        {
            try
            {
                coTask.Timing.ConfigureImplicit(SampleQuantityMode.ContinuousSamples);
                coTask.Start();
            }
            catch (DaqException ex)
            {
                coTask.Stop();
                throw new DaqException(ex.Message);
            }

            this.Enabled = true;
        }

        public void Stop()
        {
            try
            {
                coTask.Stop();
            }
            catch (DaqException ex)
            {
                throw new DaqException(ex.Message);
            }

            this.Enabled = false;
        }

        public void DisposeTask()
        {
            coTask?.Dispose();
        }
    }
}
