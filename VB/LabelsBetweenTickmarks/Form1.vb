Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace LabelsBetweenTickmarks
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#LabelsBetweenTickmarks"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim diagram As XYDiagram = TryCast(chartControl1.Diagram, XYDiagram)
            If diagram Is Nothing Then
                Return
            End If
            diagram.AxisX.MinorCount = 1
            diagram.AxisX.Tickmarks.MinorLength = 5
            diagram.AxisX.Tickmarks.Visible = False
        End Sub
        #End Region ' #LabelsBetweenTickmarks
    End Class
End Namespace
