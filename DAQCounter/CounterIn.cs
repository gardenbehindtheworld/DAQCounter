using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQCounter
{
    internal class CounterIn
    {
        private static NationalInstruments.DAQmx.Task ciTask = new NationalInstruments.DAQmx.Task();
        private static CounterSingleChannelReader ciReader = new CounterSingleChannelReader(ciTask.Stream);

        public string Device { get; set; }
        public string Channel { get; set; }
        public string Terminal { get; set; }
    }
}
