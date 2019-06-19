Imports LiveCharts
Imports LiveCharts.Wpf
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices.Marshal

Public Class FormMain

    Private m_nHistgram(256) As Integer

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        InitGraph()

    End Sub

    Private Sub BtnFileSelect_Click(sender As Object, e As EventArgs) Handles btnFileSelect.Click
        Dim openFileDlg As ComOpenFileDialog = New ComOpenFileDialog()
        openFileDlg.Filter = "JPG|*.jpg|PNG|*.png"
        openFileDlg.Title = "Open the file"
        If (openFileDlg.ShowDialog() = True) Then
            image.Image = Nothing
            Dim Bitmap = New Bitmap(openFileDlg.FileName)

            image.Image = Bitmap

            DrawHistgram(Bitmap)
        End If
    End Sub

    Public Sub InitGraph()
        Dim lineSeriesChart = New LineSeries With
        {
            .Values = New ChartValues(Of Integer),
            .Title = "Histgram"
        }

        For nIdx As Integer = 0 To 256
            lineSeriesChart.Values.Add(0)
        Next nIdx
        chart.Series.Clear()
        chart.Series.Add(lineSeriesChart)

        Return
    End Sub

    Public Sub DrawHistgram(_bitmap As Bitmap)
        InitHistgram()

        CalHistgram(_bitmap)

        Dim lineSeriesChart = New LineSeries() With
        {
            .Values = New ChartValues(Of Integer),
            .Title = "Histgram"
        }

        For nIdx As Integer = 0 To 256
            lineSeriesChart.Values.Add(m_nHistgram(nIdx))
        Next nIdx
        chart.Series.Clear()
        chart.Series.Add(lineSeriesChart)

        Return
    End Sub

    Public Sub CalHistgram(_bitmap As Bitmap)
        Dim nWidthSize As Integer = _bitmap.Width
        Dim nHeightSize As Integer = _bitmap.Height

        Dim bitmapData As BitmapData = _bitmap.LockBits(New Rectangle(0, 0, nWidthSize, nHeightSize), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb)

        Dim nIdxWidth As Integer
        Dim nIdxHeight As Integer

        For nIdxHeight = 0 To nHeightSize - 1 Step 1
            For nIdxWidth = 0 To nWidthSize - 1 Step 1

                Dim pAdr As IntPtr = bitmapData.Scan0
                Dim nPos As Integer = nIdxHeight * bitmapData.Stride + nIdxWidth * 4
                Dim nPixelB As Integer = ReadByte(pAdr, nPos + ComInfo.Pixel.B)
                Dim nPixelG As Integer = ReadByte(pAdr, nPos + ComInfo.Pixel.G)
                Dim nPixelR As Integer = ReadByte(pAdr, nPos + ComInfo.Pixel.R)

                Dim nGrayScale As Integer = (nPixelB + nPixelG + nPixelR) / 3

                m_nHistgram(nGrayScale) += 1
            Next
        Next
        _bitmap.UnlockBits(bitmapData)
    End Sub

    Public Sub InitHistgram()
        For nIdx As Integer = 0 To 256
            m_nHistgram(nIdx) = 0
        Next nIdx
    End Sub
End Class