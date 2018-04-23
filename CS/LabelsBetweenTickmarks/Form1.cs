using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace LabelsBetweenTickmarks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #LabelsBetweenTickmarks
        private void Form1_Load(object sender, EventArgs e) {
            XYDiagram diagram = chartControl1.Diagram as XYDiagram;
            if (diagram == null) return;
            diagram.AxisX.MinorCount = 1;
            diagram.AxisX.Tickmarks.MinorLength = 5;
            diagram.AxisX.Tickmarks.Visible = false;
        }
        #endregion #LabelsBetweenTickmarks
    }
}
