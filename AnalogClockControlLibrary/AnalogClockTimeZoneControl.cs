using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClockControlLibrary
{
    public partial class AnalogClockTimeZoneControl : UserControl
    {
        public AnalogClockTimeZoneControl()
        {
            InitializeComponent();
            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            int localId = timeZones.IndexOf(TimeZoneInfo.Local);
            comboBox1.Items.AddRange(timeZones.ToArray<TimeZoneInfo>());
            comboBox1.SelectedIndex = localId;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            analogClockControl1.timeZone = (TimeZoneInfo)comboBox1.SelectedItem;
        }
    }
}
