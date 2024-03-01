using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DAQCounter
{
    internal class CounterIn
    {
        private static NationalInstruments.DAQmx.Task CiTask = new NationalInstruments.DAQmx.Task();
        private static CounterSingleChannelReader CiReader = new CounterSingleChannelReader(CiTask.Stream);

        public string Device { get; set; }
        public string Channel { get; set; }
        public string Terminal { get; set; }

        public double GetFrequency()
        {
            try
            {
                CiTask.CIChannels.CreateFrequencyChannel(Channel, string.Empty, 1, 100000,
                    CIFrequencyStartingEdge.Rising,
                    CIFrequencyMeasurementMethod.LowFrequencyOneCounter, 1, 4,
                    CIFrequencyUnits.Hertz);
            }
            catch (DaqException ex)
            {
                if (ex.Error != -200489) throw new DaqException(ex.Message);
            }

            try
            {
                CiTask.CIChannels.All.FrequencyTerminal = Terminal;
                return CiReader.ReadSingleSampleDouble();
            }
            catch (DaqException ex)
            {
                throw new DaqException(ex.Message);
            }
        }
    }
}
