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
        private static NationalInstruments.DAQmx.Task CoTask = new NationalInstruments.DAQmx.Task();

        public string Device { get; set; }
        public string Channel { get; set; }
        public string Terminal { get; set; }
        public double Frequency { get; set; }
        public int DutyCycle { get; set; }
        
        public bool Enabled { get; private set; }

        public CounterOut()
        {
            Enabled = false;
        }

        public void Start()
        {
            try
            {
                CoTask.COChannels.CreatePulseChannelFrequency(Channel, string.Empty,
                    COPulseFrequencyUnits.Hertz, COPulseIdleState.High, 0, Frequency,
                    (double)DutyCycle / 100);
            }
            catch (DaqException ex)
            {
                if (ex.Error != -200489) throw new DaqException(ex.Message);
            }

            try
            {
                CoTask.COChannels.All.PulseTerminal = Terminal;
                CoTask.COChannels.All.PulseDutyCycle = (double)DutyCycle / 100;
                CoTask.COChannels.All.PulseFrequency = Frequency;
                CoTask.Timing.ConfigureImplicit(SampleQuantityMode.ContinuousSamples);
                CoTask.Start();
            }
            catch (DaqException ex)
            {
                CoTask.Stop();
                throw new DaqException(ex.Message);
            }

            Enabled = true;
        }

        public void Stop()
        {
            try
            {
                CoTask.Stop();
            }
            catch (DaqException ex)
            {
                throw new DaqException(ex.Message);
            }

            Enabled = false;
        }

        public void Restart()
        {
            if (Enabled)
            {
                Stop();
                Start();
            }
            else Stop();
        }

        public void DisposeTask()
        {
            CoTask?.Dispose();
        }
    }
}
