<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GCCLK = New System.Windows.Forms.Label()
        Me.GMCLK = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GFAN = New System.Windows.Forms.Label()
        Me.GLOAD = New System.Windows.Forms.Label()
        Me.GTEMP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(618, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(480, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 69)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(584, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 69)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stop Serial"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GCCLK
        '
        Me.GCCLK.AutoSize = True
        Me.GCCLK.Location = New System.Drawing.Point(28, 169)
        Me.GCCLK.Name = "GCCLK"
        Me.GCCLK.Size = New System.Drawing.Size(57, 20)
        Me.GCCLK.TabIndex = 6
        Me.GCCLK.Text = "Label4"
        '
        'GMCLK
        '
        Me.GMCLK.AutoSize = True
        Me.GMCLK.Location = New System.Drawing.Point(28, 193)
        Me.GMCLK.Name = "GMCLK"
        Me.GMCLK.Size = New System.Drawing.Size(57, 20)
        Me.GMCLK.TabIndex = 7
        Me.GMCLK.Text = "Label5"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(170, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Label1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(170, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Label1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(113, 437)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 40)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "CPU Only"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(263, 439)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 37)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Summary"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GFAN
        '
        Me.GFAN.AutoSize = True
        Me.GFAN.Location = New System.Drawing.Point(28, 111)
        Me.GFAN.Name = "GFAN"
        Me.GFAN.Size = New System.Drawing.Size(57, 20)
        Me.GFAN.TabIndex = 5
        Me.GFAN.Text = "Label3"
        '
        'GLOAD
        '
        Me.GLOAD.AutoSize = True
        Me.GLOAD.Location = New System.Drawing.Point(28, 64)
        Me.GLOAD.Name = "GLOAD"
        Me.GLOAD.Size = New System.Drawing.Size(57, 20)
        Me.GLOAD.TabIndex = 4
        Me.GLOAD.Text = "Label2"
        '
        'GTEMP
        '
        Me.GTEMP.AutoSize = True
        Me.GTEMP.Location = New System.Drawing.Point(24, 30)
        Me.GTEMP.Name = "GTEMP"
        Me.GTEMP.Size = New System.Drawing.Size(57, 20)
        Me.GTEMP.TabIndex = 3
        Me.GTEMP.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 561)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 667)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 822)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 883)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 929)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(133, 972)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Label6"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 1041)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GMCLK)
        Me.Controls.Add(Me.GCCLK)
        Me.Controls.Add(Me.GFAN)
        Me.Controls.Add(Me.GLOAD)
        Me.Controls.Add(Me.GTEMP)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GCCLK As Label
    Friend WithEvents GMCLK As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GFAN As Label
    Friend WithEvents GLOAD As Label
    Friend WithEvents GTEMP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
