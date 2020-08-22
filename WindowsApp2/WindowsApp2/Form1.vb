Imports OpenHardwareMonitor.Collections
Imports OpenHardwareMonitor.Hardware
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.ComponentModel

Public Class Form1
    Dim flag As Boolean
    Dim flag2 As Integer

    Dim cp As New Computer()




    Dim ram_util, serialsend, SSD_temp, SSD_tbw, gpumemused As String

    Dim cpu_pkg_temp As Integer
    Dim cpu_pkg_load, cpu_c1, cpu_c2, cpu_c3, cpu_c4, cpu_c5, cpu_c6, cpu_c7, cpu_c8, coretemp, cpu_power, gpu_power As Integer



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        flag2 = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        flag2 = 1
    End Sub

    Dim gpu_load, gpu_temp, gpu_ram, gpu_fan, gpu_clock As Integer

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        cp.GPUEnabled = True
        cp.CPUEnabled = True
        cp.RAMEnabled = True
        cp.MainboardEnabled = True
        cp.HDDEnabled = True
        cp.FanControllerEnabled = True



        flag2 = 0

        cp.Open()
       ' Button1.PerformClick()
        '  Me.Hide()
        Timer1.Start()


        ' Label11.Text = cp.GetReport()

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.Hide()
            ' NotifyIcon1.BalloonTipText = "Hi from right system tray"
            '  NotifyIcon1.ShowBalloonTip(500)
        End If
    End Sub

    Public Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If flag = True Then





            'If flag2 = 0 Then
            ' 'SerialPort1.Write("#")
            ' End If

            'If flag2 = 1 Then
            serialsend = "@" + cpu_pkg_load.ToString() + " " + (cpu_c1.ToString()) + " " + cpu_c2.ToString() + " " + cpu_c3.ToString() + " " + cpu_c4.ToString() + " " + cpu_c5.ToString() + " " + cpu_c6.ToString() + " " + cpu_c7.ToString() + " " + cpu_c8.ToString() + " " + gpu_ram.ToString() + " " + gpu_temp.ToString() + " " + gpu_fan.ToString() + " " + gpu_clock.ToString() + " " + gpu_load.ToString() + " " + cpu_power.ToString() + " " + cpu_pkg_temp.ToString() + " " + SSD_temp.ToString() + " " + SSD_tbw.ToString().Substring(0, 4) + " " + ram_util.ToString().Substring(0, 2) + " " + gpumemused
            SerialPort1.Write(serialsend)
            Label1.Text = serialsend

            Label4.Text = "gpupower" + gpu_power.ToString() + "e"


            '  SerialPort1.Write(serialsend)
            'Label11.Text = "gpu power" + gpu_power.ToString()

            'End If
            Thread.Sleep(500)
            'If flag2 = 2 Then
            'alPort1.Write("*" + cpu_pkg_load.ToString() + " " + (coretemp.ToString()) + " " + gpu_load.ToString() + " " + gpu_ram.ToString() + " " + gpu_temp.ToString() + " " + ram_util)
            ' If

        End If



        For Each hw In cp.Hardware


            ' Label11.Text = Label11.Text + hw.ToString()



            For Each sensor In hw.Sensors



                If hw.HardwareType = HardwareType.GpuNvidia Then
                    hw.Update()
                    If sensor.SensorType = SensorType.Temperature Then
                        gpu_temp = sensor.Value

                    End If

                    If sensor.SensorType = SensorType.Load Then
                        gpu_ram = sensor.Value
                    End If

                    If sensor.SensorType = SensorType.Control Then
                        gpu_fan = sensor.Value
                    End If

                End If


                If sensor.Identifier.ToString() = "/nvidiagpu/0/clock/0" Then
                    gpu_clock = sensor.Value.ToString()


                End If


                If sensor.Identifier.ToString() = "/intelcpu/0/power/0" Then
                    cpu_power = sensor.Value.ToString()


                End If


                If sensor.Identifier.ToString() = "/nvidiagpu/0/smalldata/2" Then
                    gpumemused = sensor.Value.ToString()


                End If

                If sensor.Identifier.ToString() = "/nvidiagpu/0/load/0" Then
                    gpu_load = sensor.Value.ToString()


                End If

                If sensor.Identifier.ToString() = "/intelcpu/0/temperature/8" Then
                    cpu_pkg_temp = sensor.Value.ToString()
                    Label2.Text = "cputemp:" + cpu_pkg_temp.ToString()


                End If

                If sensor.Identifier.ToString() = "/intelcpu/0/load/0" Then
                    cpu_pkg_load = sensor.Value.ToString()


                End If
                If sensor.Identifier.ToString() = "/intelcpu/0/load/1" Then
                    cpu_c1 = sensor.Value.ToString()

                End If

                If sensor.Identifier.ToString() = "/intelcpu/0/load/2" Then
                    cpu_c2 = sensor.Value.ToString()

                End If

                If sensor.Identifier.ToString() = "/intelcpu/0/load/3" Then
                    cpu_c3 = sensor.Value.ToString()

                End If

                If sensor.Identifier.ToString() = "/intelcpu/0/load/4" Then
                    cpu_c4 = sensor.Value.ToString()

                End If

                If sensor.Identifier.ToString() = "/intelcpu/0/load/5" Then
                    cpu_c5 = sensor.Value.ToString()

                End If

                If sensor.Identifier.ToString() = "/intelcpu/0/load/6" Then
                    cpu_c6 = sensor.Value.ToString()

                End If

                If sensor.Identifier.ToString() = "/intelcpu/0/load/7" Then
                    cpu_c7 = sensor.Value.ToString()

                End If

                If sensor.Identifier.ToString() = "/intelcpu/0/load/8" Then
                    cpu_c8 = sensor.Value.ToString()

                End If

                If sensor.Identifier.ToString() = "/ram/load/0" Then
                    ram_util = sensor.Value.ToString()
                End If

                If sensor.Identifier.ToString() = "/hdd/1/temperature/0" Then
                    SSD_temp = sensor.Value.ToString()
                End If

                If sensor.Identifier.ToString() = "/hdd/1/data/0" Then
                    SSD_tbw = sensor.Value.ToString()
                End If






            Next


            hw.Update()




        Next
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.Close()
        SerialPort1.PortName = "COM3"
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
        SerialPort1.Open()
        flag = True

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        flag = False
        SerialPort1.Close()
    End Sub



    'delay function
    ' Private Declare Function timeGetTime Lib "winmm.dll" () As Long
    ' Public lngStartTime As Long
    ' Public Sub delay(msdelay As Long)
    '     lngStartTime = timeGetTime()
    ' Do Until (timeGetTime() - lngStartTime) > msdelay
    ' Loop
    ' End Sub


    'End delay function</p><p>End Class
End Class
