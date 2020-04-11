using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace TempClock
{
    delegate void SendTime(string t);
    public partial class Form1 : Form
    {
        SendTime sT;
        DateTime dT;
        HMS hms;
        private void CountSeconds()
        {
            sT = new SendTime(SendSeconds);

            while (true)
            {
                dT = DateTime.Now;

                hms = new HMS(dT);

                SendSeconds($"{hms.H}:{hms.M}:{hms.S}");

                Thread.Sleep(1000);
            }
        }
        public void SendSeconds(string text)
        {
            if (label1.InvokeRequired)
                Invoke(sT, new object[] { text });
            else
                label1.Text = text;
        }
    }
}
