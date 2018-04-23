Namespace LabelsBetweenTickmarks
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
            Dim series4 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("Illinois", New Object() { (DirectCast(423.721R, Object))})
            Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint("Indiana", New Object() { (DirectCast(178.719R, Object))})
            Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint("Michigan", New Object() { (DirectCast(308.845R, Object))})
            Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint("Ohio", New Object() { (DirectCast(348.555R, Object))})
            Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint("Wisconsin", New Object() { (DirectCast(160.274R, Object))})
            Dim series5 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint("Illinois", New Object() { (DirectCast(476.851R, Object))})
            Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint("Indiana", New Object() { (DirectCast(195.769R, Object))})
            Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint("Michigan", New Object() { (DirectCast(335.793R, Object))})
            Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint("Ohio", New Object() { (DirectCast(374.771R, Object))})
            Dim seriesPoint25 As New DevExpress.XtraCharts.SeriesPoint("Wisconsin", New Object() { (DirectCast(182.373R, Object))})
            Dim series6 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint26 As New DevExpress.XtraCharts.SeriesPoint("Illinois", New Object() { (DirectCast(528.904R, Object))})
            Dim seriesPoint27 As New DevExpress.XtraCharts.SeriesPoint("Indiana", New Object() { (DirectCast(227.271R, Object))})
            Dim seriesPoint28 As New DevExpress.XtraCharts.SeriesPoint("Michigan", New Object() { (DirectCast(372.576R, Object))})
            Dim seriesPoint29 As New DevExpress.XtraCharts.SeriesPoint("Ohio", New Object() { (DirectCast(418.258R, Object))})
            Dim seriesPoint30 As New DevExpress.XtraCharts.SeriesPoint("Wisconsin", New Object() { (DirectCast(211.727R, Object))})
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram2
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series4.Name = "1998"
            series4.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20})
            series5.Name = "2004"
            series5.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24, seriesPoint25})
            series6.Name = "2004"
            series6.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30})
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series4, series5, series6}
            Me.chartControl1.Size = New System.Drawing.Size(624, 321)
            Me.chartControl1.TabIndex = 0
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 321)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

