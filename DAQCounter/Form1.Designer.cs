namespace DAQCounter
{
    partial class frm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboDevices = new System.Windows.Forms.ComboBox();
            this.cboCounterIn = new System.Windows.Forms.ComboBox();
            this.cboCounterOut = new System.Windows.Forms.ComboBox();
            this.updDutyCycle = new System.Windows.Forms.NumericUpDown();
            this.updDesiredFrequency = new System.Windows.Forms.NumericUpDown();
            this.updInputTerminal = new System.Windows.Forms.NumericUpDown();
            this.updOutputTerminal = new System.Windows.Forms.NumericUpDown();
            this.lblMeasuredFrequencyNum = new System.Windows.Forms.Label();
            this.lblDevices = new System.Windows.Forms.Label();
            this.lblCounterIn = new System.Windows.Forms.Label();
            this.lblCounterOut = new System.Windows.Forms.Label();
            this.lblDesiredFrequency = new System.Windows.Forms.Label();
            this.lblDutyCycle = new System.Windows.Forms.Label();
            this.lblInputTerminal = new System.Windows.Forms.Label();
            this.lblOutputTerminal = new System.Windows.Forms.Label();
            this.lblMeasuredFrequency = new System.Windows.Forms.Label();
            this.lblDesiredFrequencyUnit = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMeasuredFrequencyUnit = new System.Windows.Forms.Label();
            this.btnOutputFrequency = new System.Windows.Forms.Button();
            this.btnMeasureFrequency = new System.Windows.Forms.Button();
            this.lblOutputStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updDutyCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDesiredFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updInputTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updOutputTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDevices
            // 
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(150, 29);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(104, 21);
            this.cboDevices.TabIndex = 0;
            // 
            // cboCounterIn
            // 
            this.cboCounterIn.FormattingEnabled = true;
            this.cboCounterIn.Location = new System.Drawing.Point(150, 61);
            this.cboCounterIn.Name = "cboCounterIn";
            this.cboCounterIn.Size = new System.Drawing.Size(104, 21);
            this.cboCounterIn.TabIndex = 1;
            // 
            // cboCounterOut
            // 
            this.cboCounterOut.FormattingEnabled = true;
            this.cboCounterOut.Location = new System.Drawing.Point(150, 93);
            this.cboCounterOut.Name = "cboCounterOut";
            this.cboCounterOut.Size = new System.Drawing.Size(104, 21);
            this.cboCounterOut.TabIndex = 2;
            // 
            // updDutyCycle
            // 
            this.updDutyCycle.Location = new System.Drawing.Point(150, 157);
            this.updDutyCycle.Name = "updDutyCycle";
            this.updDutyCycle.Size = new System.Drawing.Size(104, 20);
            this.updDutyCycle.TabIndex = 3;
            // 
            // updDesiredFrequency
            // 
            this.updDesiredFrequency.Location = new System.Drawing.Point(150, 125);
            this.updDesiredFrequency.Name = "updDesiredFrequency";
            this.updDesiredFrequency.Size = new System.Drawing.Size(104, 20);
            this.updDesiredFrequency.TabIndex = 4;
            // 
            // updInputTerminal
            // 
            this.updInputTerminal.Location = new System.Drawing.Point(150, 189);
            this.updInputTerminal.Name = "updInputTerminal";
            this.updInputTerminal.Size = new System.Drawing.Size(104, 20);
            this.updInputTerminal.TabIndex = 5;
            // 
            // updOutputTerminal
            // 
            this.updOutputTerminal.Location = new System.Drawing.Point(150, 221);
            this.updOutputTerminal.Name = "updOutputTerminal";
            this.updOutputTerminal.Size = new System.Drawing.Size(104, 20);
            this.updOutputTerminal.TabIndex = 6;
            // 
            // lblMeasuredFrequencyNum
            // 
            this.lblMeasuredFrequencyNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeasuredFrequencyNum.Location = new System.Drawing.Point(150, 253);
            this.lblMeasuredFrequencyNum.Name = "lblMeasuredFrequencyNum";
            this.lblMeasuredFrequencyNum.Size = new System.Drawing.Size(104, 20);
            this.lblMeasuredFrequencyNum.TabIndex = 7;
            // 
            // lblDevices
            // 
            this.lblDevices.Location = new System.Drawing.Point(12, 32);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(132, 23);
            this.lblDevices.TabIndex = 8;
            this.lblDevices.Text = "Devices";
            this.lblDevices.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCounterIn
            // 
            this.lblCounterIn.Location = new System.Drawing.Point(12, 64);
            this.lblCounterIn.Name = "lblCounterIn";
            this.lblCounterIn.Size = new System.Drawing.Size(132, 23);
            this.lblCounterIn.TabIndex = 9;
            this.lblCounterIn.Text = "Counter In";
            this.lblCounterIn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCounterOut
            // 
            this.lblCounterOut.Location = new System.Drawing.Point(12, 96);
            this.lblCounterOut.Name = "lblCounterOut";
            this.lblCounterOut.Size = new System.Drawing.Size(132, 23);
            this.lblCounterOut.TabIndex = 10;
            this.lblCounterOut.Text = "Counter Out";
            this.lblCounterOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDesiredFrequency
            // 
            this.lblDesiredFrequency.Location = new System.Drawing.Point(12, 127);
            this.lblDesiredFrequency.Name = "lblDesiredFrequency";
            this.lblDesiredFrequency.Size = new System.Drawing.Size(132, 23);
            this.lblDesiredFrequency.TabIndex = 11;
            this.lblDesiredFrequency.Text = "Frequency";
            this.lblDesiredFrequency.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDutyCycle
            // 
            this.lblDutyCycle.Location = new System.Drawing.Point(12, 159);
            this.lblDutyCycle.Name = "lblDutyCycle";
            this.lblDutyCycle.Size = new System.Drawing.Size(132, 23);
            this.lblDutyCycle.TabIndex = 12;
            this.lblDutyCycle.Text = "Duty Cycle";
            this.lblDutyCycle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInputTerminal
            // 
            this.lblInputTerminal.Location = new System.Drawing.Point(12, 191);
            this.lblInputTerminal.Name = "lblInputTerminal";
            this.lblInputTerminal.Size = new System.Drawing.Size(132, 23);
            this.lblInputTerminal.TabIndex = 13;
            this.lblInputTerminal.Text = "Input Terminal (PFI)";
            this.lblInputTerminal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOutputTerminal
            // 
            this.lblOutputTerminal.Location = new System.Drawing.Point(12, 223);
            this.lblOutputTerminal.Name = "lblOutputTerminal";
            this.lblOutputTerminal.Size = new System.Drawing.Size(132, 23);
            this.lblOutputTerminal.TabIndex = 14;
            this.lblOutputTerminal.Text = "Output Terminal (PFI)";
            this.lblOutputTerminal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeasuredFrequency
            // 
            this.lblMeasuredFrequency.Location = new System.Drawing.Point(12, 254);
            this.lblMeasuredFrequency.Name = "lblMeasuredFrequency";
            this.lblMeasuredFrequency.Size = new System.Drawing.Size(132, 23);
            this.lblMeasuredFrequency.TabIndex = 15;
            this.lblMeasuredFrequency.Text = "Measured Frequency";
            this.lblMeasuredFrequency.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDesiredFrequencyUnit
            // 
            this.lblDesiredFrequencyUnit.AutoSize = true;
            this.lblDesiredFrequencyUnit.Location = new System.Drawing.Point(260, 127);
            this.lblDesiredFrequencyUnit.Name = "lblDesiredFrequencyUnit";
            this.lblDesiredFrequencyUnit.Size = new System.Drawing.Size(20, 13);
            this.lblDesiredFrequencyUnit.TabIndex = 16;
            this.lblDesiredFrequencyUnit.Text = "Hz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "%";
            // 
            // lblMeasuredFrequencyUnit
            // 
            this.lblMeasuredFrequencyUnit.AutoSize = true;
            this.lblMeasuredFrequencyUnit.Location = new System.Drawing.Point(260, 254);
            this.lblMeasuredFrequencyUnit.Name = "lblMeasuredFrequencyUnit";
            this.lblMeasuredFrequencyUnit.Size = new System.Drawing.Size(20, 13);
            this.lblMeasuredFrequencyUnit.TabIndex = 18;
            this.lblMeasuredFrequencyUnit.Text = "Hz";
            // 
            // btnOutputFrequency
            // 
            this.btnOutputFrequency.Location = new System.Drawing.Point(28, 297);
            this.btnOutputFrequency.Name = "btnOutputFrequency";
            this.btnOutputFrequency.Size = new System.Drawing.Size(116, 23);
            this.btnOutputFrequency.TabIndex = 19;
            this.btnOutputFrequency.Text = "Output Frequency";
            this.btnOutputFrequency.UseVisualStyleBackColor = true;
            this.btnOutputFrequency.Click += new System.EventHandler(this.btnOutputFrequency_Click);
            // 
            // btnMeasureFrequency
            // 
            this.btnMeasureFrequency.Location = new System.Drawing.Point(28, 326);
            this.btnMeasureFrequency.Name = "btnMeasureFrequency";
            this.btnMeasureFrequency.Size = new System.Drawing.Size(116, 23);
            this.btnMeasureFrequency.TabIndex = 20;
            this.btnMeasureFrequency.Text = "Measure Frequency";
            this.btnMeasureFrequency.UseVisualStyleBackColor = true;
            // 
            // lblOutputStatus
            // 
            this.lblOutputStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblOutputStatus.Location = new System.Drawing.Point(150, 298);
            this.lblOutputStatus.Name = "lblOutputStatus";
            this.lblOutputStatus.Size = new System.Drawing.Size(104, 20);
            this.lblOutputStatus.TabIndex = 21;
            this.lblOutputStatus.Text = "Stopped";
            this.lblOutputStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 380);
            this.Controls.Add(this.lblOutputStatus);
            this.Controls.Add(this.btnMeasureFrequency);
            this.Controls.Add(this.btnOutputFrequency);
            this.Controls.Add(this.lblMeasuredFrequencyUnit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDesiredFrequencyUnit);
            this.Controls.Add(this.lblMeasuredFrequency);
            this.Controls.Add(this.lblOutputTerminal);
            this.Controls.Add(this.lblInputTerminal);
            this.Controls.Add(this.lblDutyCycle);
            this.Controls.Add(this.lblDesiredFrequency);
            this.Controls.Add(this.lblCounterOut);
            this.Controls.Add(this.lblCounterIn);
            this.Controls.Add(this.lblDevices);
            this.Controls.Add(this.lblMeasuredFrequencyNum);
            this.Controls.Add(this.updOutputTerminal);
            this.Controls.Add(this.updInputTerminal);
            this.Controls.Add(this.updDesiredFrequency);
            this.Controls.Add(this.updDutyCycle);
            this.Controls.Add(this.cboCounterOut);
            this.Controls.Add(this.cboCounterIn);
            this.Controls.Add(this.cboDevices);
            this.Name = "frm1";
            this.Text = "Pulse Counter";
            this.Load += new System.EventHandler(this.Frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updDutyCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDesiredFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updInputTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updOutputTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDevices;
        private System.Windows.Forms.ComboBox cboCounterIn;
        private System.Windows.Forms.ComboBox cboCounterOut;
        private System.Windows.Forms.NumericUpDown updDutyCycle;
        private System.Windows.Forms.NumericUpDown updDesiredFrequency;
        private System.Windows.Forms.NumericUpDown updInputTerminal;
        private System.Windows.Forms.NumericUpDown updOutputTerminal;
        private System.Windows.Forms.Label lblMeasuredFrequencyNum;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.Label lblCounterIn;
        private System.Windows.Forms.Label lblCounterOut;
        private System.Windows.Forms.Label lblDesiredFrequency;
        private System.Windows.Forms.Label lblDutyCycle;
        private System.Windows.Forms.Label lblInputTerminal;
        private System.Windows.Forms.Label lblOutputTerminal;
        private System.Windows.Forms.Label lblMeasuredFrequency;
        private System.Windows.Forms.Label lblDesiredFrequencyUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMeasuredFrequencyUnit;
        private System.Windows.Forms.Button btnOutputFrequency;
        private System.Windows.Forms.Button btnMeasureFrequency;
        private System.Windows.Forms.Label lblOutputStatus;
    }
}

