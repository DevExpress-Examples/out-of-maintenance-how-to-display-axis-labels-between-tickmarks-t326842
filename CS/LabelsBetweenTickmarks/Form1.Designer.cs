namespace LabelsBetweenTickmarks {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint16 = new DevExpress.XtraCharts.SeriesPoint("Illinois", new object[] {
            ((object)(423.721D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint17 = new DevExpress.XtraCharts.SeriesPoint("Indiana", new object[] {
            ((object)(178.719D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint18 = new DevExpress.XtraCharts.SeriesPoint("Michigan", new object[] {
            ((object)(308.845D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint19 = new DevExpress.XtraCharts.SeriesPoint("Ohio", new object[] {
            ((object)(348.555D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint20 = new DevExpress.XtraCharts.SeriesPoint("Wisconsin", new object[] {
            ((object)(160.274D))});
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint21 = new DevExpress.XtraCharts.SeriesPoint("Illinois", new object[] {
            ((object)(476.851D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint22 = new DevExpress.XtraCharts.SeriesPoint("Indiana", new object[] {
            ((object)(195.769D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint23 = new DevExpress.XtraCharts.SeriesPoint("Michigan", new object[] {
            ((object)(335.793D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint24 = new DevExpress.XtraCharts.SeriesPoint("Ohio", new object[] {
            ((object)(374.771D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint25 = new DevExpress.XtraCharts.SeriesPoint("Wisconsin", new object[] {
            ((object)(182.373D))});
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint26 = new DevExpress.XtraCharts.SeriesPoint("Illinois", new object[] {
            ((object)(528.904D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint27 = new DevExpress.XtraCharts.SeriesPoint("Indiana", new object[] {
            ((object)(227.271D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint28 = new DevExpress.XtraCharts.SeriesPoint("Michigan", new object[] {
            ((object)(372.576D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint29 = new DevExpress.XtraCharts.SeriesPoint("Ohio", new object[] {
            ((object)(418.258D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint30 = new DevExpress.XtraCharts.SeriesPoint("Wisconsin", new object[] {
            ((object)(211.727D))});
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series4.Name = "1998";
            series4.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint16,
            seriesPoint17,
            seriesPoint18,
            seriesPoint19,
            seriesPoint20});
            series5.Name = "2004";
            series5.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint21,
            seriesPoint22,
            seriesPoint23,
            seriesPoint24,
            seriesPoint25});
            series6.Name = "2004";
            series6.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint26,
            seriesPoint27,
            seriesPoint28,
            seriesPoint29,
            seriesPoint30});
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4,
        series5,
        series6};
            this.chartControl1.Size = new System.Drawing.Size(624, 321);
            this.chartControl1.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

