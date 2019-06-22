<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnFileSelect = New System.Windows.Forms.Button()
        Me.image = New System.Windows.Forms.PictureBox()
        Me.chart = New LiveCharts.WinForms.CartesianChart()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFileSelect
        '
        Me.btnFileSelect.BackColor = System.Drawing.Color.White
        Me.btnFileSelect.Location = New System.Drawing.Point(12, 12)
        Me.btnFileSelect.Name = "btnFileSelect"
        Me.btnFileSelect.Size = New System.Drawing.Size(84, 32)
        Me.btnFileSelect.TabIndex = 0
        Me.btnFileSelect.Text = "File Select..."
        Me.btnFileSelect.UseVisualStyleBackColor = False
        '
        'image
        '
        Me.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.image.Location = New System.Drawing.Point(12, 50)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(325, 371)
        Me.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.image.TabIndex = 1
        Me.image.TabStop = False
        '
        'chart
        '
        Me.chart.Location = New System.Drawing.Point(360, 12)
        Me.chart.Name = "chart"
        Me.chart.Size = New System.Drawing.Size(428, 426)
        Me.chart.TabIndex = 2
        Me.chart.Text = "CartesianChart1"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chart)
        Me.Controls.Add(Me.image)
        Me.Controls.Add(Me.btnFileSelect)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFileSelect As Button
    Friend WithEvents image As PictureBox
    Friend WithEvents chart As LiveCharts.WinForms.CartesianChart
End Class
