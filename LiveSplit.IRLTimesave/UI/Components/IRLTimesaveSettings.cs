using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class IRLTimesaveSettings : UserControl
    {
        public bool UseStartTimerValue { get; set; }
        public LayoutMode Mode { get; set; }
        public IRLTimesaveSettings()
        {
            InitializeComponent();
            UseStartTimerValue = true;
        }

        private void IRLTimesaveSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
