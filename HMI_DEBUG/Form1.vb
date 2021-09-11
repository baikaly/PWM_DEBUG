Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Text.RegularExpressions


Imports System
Imports System.Management
Imports System.Drawing
Imports System.Data
Imports System.Diagnostics
Imports System.ComponentModel


Public Class Form1
    Dim Test_Flag As Boolean
    Dim PortList() As String
    Dim ShowWarning As Boolean = True
    Dim CmdEnable As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        If SerialPort1.IsOpen = False Then
            MessageBox.Show("串口没有打开", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If ShowWarning Then
            Dim aa = MessageBox.Show("PWM setting is only for the light debugging during development, please reboot the MCU after the debugging is done to avoid any light status confusing. This warning is shown only once.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ShowWarning = False
        End If

        SerialPort1.WriteLine("PWM0=" & TextBox0.Text)
        Sleep(10)
        SerialPort1.WriteLine("PWM1=" & TextBox1.Text)

    End Sub

    Public Shared Sub Sleep(ByVal Interval)
        Dim __time As DateTime = DateTime.Now
        Dim __Span As Int64 = Interval * 10000 '因为时间是以100纳秒为单位。
        While (DateTime.Now.Ticks - __time.Ticks < __Span)
            Application.DoEvents()
        End While
    End Sub

    Private Function setSerialPort1(Port As String, rate As Integer) As Boolean
        Try
            With SerialPort1()
                If .IsOpen = True Then .Close()
                .PortName = Port
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Parity = IO.Ports.Parity.None
                .BaudRate = rate
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "错误产生于函数setSerialPort1")
            Return False
        End Try

    End Function


    Public Sub PrintRichText(msg As String, color As Color, Optional isExtraSpace As Integer = 0, Optional isNewLine As Boolean = True, Optional isLogRecord As Boolean = True, Optional TimeStamp As Boolean = False)
        Dim SysTime As String = DateTime.Now.ToString() + "    "
        Debug.Print("msg=" + msg)
        Try
            RichTextBox1.SelectionStart = RichTextBox1.Text.Length '设置插入符位置为文本框末
            RichTextBox1.SelectionColor = color '设置文本颜色 
            If Not IsNothing(msg) Then
                If msg.Length > 0 Then
                    If TimeStamp Then
                        If True Then
                            If msg.StartsWith(vbCrLf) Then
                                msg = msg.Replace(msg, vbCrLf + SysTime + msg.Substring(2))
                            Else
                                msg = msg.Replace(msg, SysTime + msg)
                            End If
                        End If
                    End If

                    If isNewLine = True Then
                        If Not isExtraSpace = 0 Then
                            RichTextBox1.AppendText("            " + msg + vbCrLf)
                            If isLogRecord Then WriteLog("            " + msg)
                        Else
                            RichTextBox1.AppendText(msg + vbCrLf)
                            If isLogRecord Then WriteLog(msg)
                        End If
                    Else
                        If Not isExtraSpace = 0 Then
                            RichTextBox1.AppendText("            " + msg)
                            If isLogRecord Then WriteLog("            " + msg, 3)
                        Else
                            RichTextBox1.AppendText(msg)
                            If isLogRecord Then WriteLog(msg, 3)
                        End If
                    End If
                    RichTextBox1.ScrollToCaret()                    '滚动条滚到到最新插入行
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "错误产生于过程PrintRichText")
        End Try
    End Sub

    Function WriteLog(t As String, Optional c As Integer = 0, Optional cr As Boolean = False) As Boolean
        Dim DataPath = Application.StartupPath & "\SerialLog.log"
        Dim StrWriter As StreamWriter, TryCnt As Integer = 0
        'Dim StrWriter As New StreamWriter(DataPath, True)
        While TryCnt < 50
            Try
                StrWriter = New StreamWriter(DataPath, True)
                Try
                    Select Case c
                        Case 1
                            StrWriter.WriteLine(RichTextBox1.Text)
                            StrWriter.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++")
                            StrWriter.WriteLine(vbCrLf & vbCrLf)
                        Case 2
                            StrWriter.WriteLine(RichTextBox1.Text)
                        Case 3
                            StrWriter.Write(t)
                        Case Else
                            StrWriter.WriteLine(t)
                            If cr = True Then StrWriter.WriteLine(vbCrLf)
                    End Select
                    StrWriter.Flush()
                    StrWriter.Close()
                    StrWriter.Dispose()
                    Return True
                Catch ex As Exception
                    StrWriter.Flush()
                    StrWriter.Close()
                    StrWriter.Dispose()
                    MessageBox.Show(ex.Message, "写入Log时出错,错误产生于函数WriteLog")
                    Return False
                End Try

            Catch ex0 As Exception
                TryCnt = TryCnt + 1
            End Try
        End While
        PrintRichText("注意，写入Log失败，Log已被其他程序打开", Color.Red, , , False)
        Return False
    End Function



    Private Sub CheckPort(Optional RefreshAll As Boolean = False)
        Debug.Print("Checkport is called")
        Dim i As Integer
        Dim Ports() As String = SerialPort.GetPortNames

        If IsNothing(PortList) Or RefreshAll Then                'check serial ports on mainform load
            PortList = Ports
            Combo1.BeginUpdate()
            Combo1.Items.Clear()
            If Ports.Length > 0 Then
                For i = 0 To Ports.Length - 1
                    Combo1.Items.Add(Ports(i))
                Next
            End If
            Combo1.EndUpdate()
            If Combo1.Items.Count > 0 Then
                Combo1.SelectedIndex = Combo1.Items.Count - 1
            Else
                Combo1.Text = ""
            End If
        Else                                    'check serial ports on USB device change or specified call
            If Ports.Count >= PortList.Count Then
                If Ports.Count > 0 Then
                    For i = 0 To UBound(Ports)
                        If Not PortList.Contains(Ports(i)) Then
                            PrintRichText(vbCrLf & "发现新的串口：" & Ports(i), Color.Black)
                            Combo1.Items.Add(Ports(i))
                            If Combo1.Text = "" Then Combo1.Text = Ports(i)
                        End If
                    Next
                    PortList = Ports
                End If
            End If

            If Ports.Count < PortList.Count Then
                If PortList.Count > 0 Then
                    For i = 0 To UBound(PortList)
                        If Not Ports.Contains(PortList(i)) Then
                            If Combo1.Text = PortList(i) Then
                                Combo1.BackColor = Color.White      '若被移除的为当前的串口则关闭它
                                SerialPort1.Close()
                                Combo1.SelectedIndex = 0
                            End If
                            Combo1.Items.Remove(PortList(i))
                            PrintRichText(vbCrLf & "串口设备已移除：" & PortList(i), Color.Black)
                        End If
                    Next
                    PortList = Ports
                End If
            End If
            If Ports.Count = 0 Then Combo1.Text = ""
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckPort()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "OPEN" Then
            Call setSerialPort1(Combo1.Text, 115200)
            SerialPort1.Open()
            Button1.BackColor = Color.GreenYellow
            Button1.Text = "CLOSE"
        ElseIf Button1.Text = "CLOSE" Then
            SerialPort1.Close()
            Button1.BackColor = DefaultBackColor
            Button1.Text = "OPEN"
        End If

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Select Case TrackBar1.Value
            Case 0
                Label_CCT.Text = 2000
            Case 1
                Label_CCT.Text = 3500
            Case 2
                Label_CCT.Text = 5700
        End Select
        'Label_CCT.Text = TrackBar1.Value * 100 + 2000
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        If TrackBar2.Value < 1 Then
            Label_LUX.Text = 0
        Else
            Label_LUX.Text = TrackBar2.Value * 20 + 20
        End If


    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        TextBox0.Text = TrackBar3.Value / 10000
    End Sub

    Private Sub TextBox0_TextChanged(sender As Object, e As EventArgs) Handles TextBox0.TextChanged
        If IsNumeric(TextBox0.Text) Then
            Dim va As Integer = CDbl(TextBox0.Text) * 10000
            If va >= 0 And va <= 10000 Then
                TrackBar3.Value = va
            End If
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            Dim va As Integer = CDbl(TextBox1.Text) * 10000
            If va >= 0 And va <= 10000 Then
                TrackBar4.Value = va
            End If
        End If
    End Sub

    Delegate Sub RxReadMethodDelegate(ByVal txt As String)
    Private Sub Serialport_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim s As String = ""
        Dim RxRead As New RxReadMethodDelegate(AddressOf RxReadMethod)
        Me.BeginInvoke(RxRead, s)
    End Sub
    Dim RevTxt As String = ""
    Private Sub RxReadMethod(ByVal str As String)
        Dim rev As String
        If SerialPort1.IsOpen Then
            If SerialPort1.BytesToRead > 0 Then
                rev = SerialPort1.ReadExisting
                RevBox.Text = RevBox.Text + rev
                PrintRichText(rev, Color.Green, 0, False, False, False)
                rev = ""
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SerialPort1.IsOpen = False Then
            MessageBox.Show("串口没有打开", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        SerialPort1.WriteLine("CCT=" & Label_CCT.Text)
        Sleep(10)
        SerialPort1.WriteLine("LUX=" & Label_LUX.Text)
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        TextBox1.Text = TrackBar4.Value / 10000
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Btn_VEXT.Click
        If SerialPort1.IsOpen Then
            If IsNumeric(TB_VEXT.Text) Then
                Dim vext_adc As String = CInt(TB_VEXT.Text * 1023 / 3).ToString
                SerialPort1.WriteLine("SetAdapterThreshold " & vext_adc)
            End If
        Else
            MsgBox("please open serial port at first")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If IsNumeric(TextBox2.Text) Then SerialPort1.WriteLine("SetLogLevel " + TextBox2.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            RevBox.Clear()
            CmdEnable = False
            SerialPort1.WriteLine("STATUS")
            Sleep(100)
            Dim rev = RevBox.Text
            If rev.Contains("PIR_Status") Then
                Dim arr = rev.Replace(" ", "").Replace("=", ",").Split(",")
                Dim LUX = arr(2)
                Dim CCT = arr(4)
                Dim PWM_White = arr(6)
                Dim PWM_Amber = arr(8)
                Dim ReversePWM_White = arr(10)
                Label_LUX.Text = LUX
                Label_CCT.Text = CCT
                If LUX = 0 Then
                    TrackBar2.Value = 0
                Else
                    TrackBar2.Value = CInt((LUX - 20) / 20)
                End If
                'TrackBar1.Value = CInt((CCT - 2000) / 100)
                If CCT = 2000 Then TrackBar1.Value = 0 Else If CCT = 3500 Then TrackBar1.Value = 1 Else If CCT = 5700 Then TrackBar1.Value = 2
                TextBox0.Text = CStr(Format(PWM_White / 65535, "0.0000"))
                TextBox1.Text = CStr(Format(PWM_Amber / 65535, "0.0000"))

                CmdEnable = True
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If IsNumeric(TextBox3.Text) Then SerialPort1.WriteLine("SetPressLong " + TextBox3.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If IsNumeric(TextBox4.Text) Then SerialPort1.WriteLine("SetPirDelay " + TextBox4.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If IsNumeric(TextBox5.Text) Then SerialPort1.WriteLine("LightConvertTime " + TextBox5.Text)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        SerialPort1.WriteLine("GetReverseState")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Btn_VBAT.Click
        If IsNumeric(TB_VBAT.Text) Then
            Dim vbat_adc As String = CInt(TB_VBAT.Text * 1023 / 3).ToString
            SerialPort1.WriteLine("SetBattaryThreshold " & vbat_adc)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNumeric(TextBox6.Text) Then SerialPort1.WriteLine("SetDimmingDelay " + TextBox6.Text)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SerialPort1.WriteLine(SendBox.Text)
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        RevBox.Clear()
        SerialPort1.WriteLine("GetInputMode")
        Sleep(100)
        Dim rev = RevBox.Text
        If rev.Contains("GetInputMode=") Then
            Dim arr = Trim(rev.Replace(vbCrLf, "")).Split("=")
            IOMode.Text = arr(UBound(arr))
        End If

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If IsNumeric(IOMode.Text) Then
            SerialPort1.WriteLine("SetOutputTable " + IOMode.Text)
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        SerialPort1.WriteLine("GetOutputTable")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        SerialPort1.WriteLine("EnableSelfIRFilter 1")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        SerialPort1.WriteLine("EnableSelfIRFilter 0")
    End Sub
End Class
