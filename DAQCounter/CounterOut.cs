using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQCounter
{
    internal class CounterOut
    {
        public bool Enabled { get; private set; }

        public CounterOut()
        {
            this.Enabled = false;
        }

        public void Start()
        {
            this.Enabled = true;
        }

        public void Stop()
        {
            this.Enabled = false;
        }
    }
}
