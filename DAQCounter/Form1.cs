using NationalInstruments.DAQmx;
using NationalInstruments.Restricted;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQCounter
{
    public partial class frm1 : Form
    {
        private CounterOut co = new CounterOut();

        // Channel/device arrays
        private string[] devices;
        private string[] counterInChannels;
        private string[] counterOutChannels;
        private string[] pfiTerminals;

        public frm1()
        {
            InitializeComponent();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            // Get device and channel arrays
            devices = DaqSystem.Local.Devices;
            counterInChannels = DaqSystem.Local.GetPhysicalChannels(
                PhysicalChannelTypes.CI, PhysicalChannelAccess.External);
            counterOutChannels = DaqSystem.Local.GetPhysicalChannels(
                PhysicalChannelTypes.CO, PhysicalChannelAccess.External);

            // Get PFI terminals
            List<string> pfiTerminalList = new List<string>();
            foreach (string terminal in DaqSystem.Local.GetTerminals(TerminalTypes.Basic))
                if (terminal.ToLower().Contains("pfi")) pfiTerminalList.Add(terminal);
            pfiTerminals = pfiTerminalList.ToArray();

            // Devices combo box settings
            cboDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDevices.Items.AddRange(devices);
            if (cboDevices.Items.Count > 0) cboDevices.SelectedIndex = 0;

            // Counter In combo box settings
            cboCounterIn.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCounterIn.Items.AddRange(counterInChannels);
            if (cboCounterIn.Items.Count > 0) cboCounterIn.SelectedIndex = 0;

            // Counter Out combo box settings
            cboCounterOut.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCounterOut.Items.AddRange(counterOutChannels);
            if (cboCounterOut.Items.Count > 0) cboCounterOut.SelectedIndex = 0;

            // Frequency updown settings
            updDesiredFrequency.Minimum = 1;
            updDesiredFrequency.Maximum = 100000;
            updDesiredFrequency.Value = 1000;

            // Duty Cycle updown settings
            updDutyCycle.Minimum = 1;
            updDutyCycle.Maximum = 99;
            updDutyCycle.Value = 50;

            // Input Terminal updown settings
            updInputTerminal.Minimum = 0;
            updInputTerminal.Maximum = pfiTerminals.Length < 1 ? 0 : pfiTerminals.Length - 1;
            updInputTerminal.Value = 0;

            // Output Terminal updown settings
            updOutputTerminal.Minimum = 0;
            updOutputTerminal.Maximum = pfiTerminals.Length < 1 ? 0 : pfiTerminals.Length - 1;
            updOutputTerminal.Value = updOutputTerminal.Maximum < 1 ? 0 : 1;

            if (cboDevices.Items.Count < 1)
            {
                SetUserInputPermissions(false);
                MessageBox.Show("There are no available devices.");
            }
        }

        private void btnOutputFrequency_Click(object sender, EventArgs e)
        {
            switch (co.Enabled)
            {
                case true:
                    co.Stop();
                    SetOutputStatus(false);
                    break;
                case false:
                    co.Start();
                    SetOutputStatus(true);
                    break;
            }
        }

        private void SetOutputStatus(bool startStop)
        {
            switch (startStop)
            {
                case true:
                    lblOutputStatus.Text = "Running";
                    lblOutputStatus.BackColor = Color.FromArgb(128, 255, 128);
                    break;
                case false:
                    lblOutputStatus.Text = "Stopped";
                    lblOutputStatus.BackColor = Color.FromArgb(255, 128, 128);
                    break;
            }
        }

        private void SetUserInputPermissions(bool enableDisable)
        {
            cboDevices.Enabled = enableDisable;
            cboCounterIn.Enabled = enableDisable;
            cboCounterOut.Enabled = enableDisable;
            updDesiredFrequency.Enabled = enableDisable;
            updDutyCycle.Enabled = enableDisable;
            updInputTerminal.Enabled = enableDisable;
            updOutputTerminal.Enabled = enableDisable;
            btnOutputFrequency.Enabled = enableDisable;
            btnMeasureFrequency.Enabled = enableDisable;
        }
    }
}
