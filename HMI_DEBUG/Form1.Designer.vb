<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Btn_Start = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SendBox = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.RevBox = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Combo1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CCT = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Brightness = New System.Windows.Forms.Label()
        Me.Label_LUX = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Label_CCT = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox0 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.TB_VEXT = New System.Windows.Forms.TextBox()
        Me.TB_VBAT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.IOMode = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Btn_VBAT = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Btn_VEXT = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(454, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(339, 644)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'SerialPort1
        '
        '
        'Btn_Start
        '
        Me.Btn_Start.Location = New System.Drawing.Point(348, 147)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(69, 57)
        Me.Btn_Start.TabIndex = 1
        Me.Btn_Start.Text = "DEBUG SET"
        Me.Btn_Start.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 451.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(796, 650)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 644)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SendBox)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.RevBox)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.Combo1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 158)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "General"
        '
        'SendBox
        '
        Me.SendBox.Location = New System.Drawing.Point(118, 71)
        Me.SendBox.Name = "SendBox"
        Me.SendBox.Size = New System.Drawing.Size(100, 23)
        Me.SendBox.TabIndex = 53
        Me.SendBox.Visible = False
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button11.Location = New System.Drawing.Point(233, 64)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(86, 35)
        Me.Button11.TabIndex = 52
        Me.Button11.Text = "send"
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'RevBox
        '
        Me.RevBox.Location = New System.Drawing.Point(11, 71)
        Me.RevBox.Name = "RevBox"
        Me.RevBox.Size = New System.Drawing.Size(69, 23)
        Me.RevBox.TabIndex = 51
        Me.RevBox.Visible = False
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("微软雅黑", 10.5!)
        Me.Button10.Location = New System.Drawing.Point(86, 87)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(113, 47)
        Me.Button10.TabIndex = 50
        Me.Button10.Text = "Get Status"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Combo1
        '
        Me.Combo1.FormattingEnabled = True
        Me.Combo1.Location = New System.Drawing.Point(98, 22)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(120, 25)
        Me.Combo1.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Serial port:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(266, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 32)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "OPEN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(233, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 47)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Clear text"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CCT)
        Me.GroupBox2.Controls.Add(Me.Btn_Start)
        Me.GroupBox2.Controls.Add(Me.TrackBar1)
        Me.GroupBox2.Controls.Add(Me.Brightness)
        Me.GroupBox2.Controls.Add(Me.Label_LUX)
        Me.GroupBox2.Controls.Add(Me.TrackBar2)
        Me.GroupBox2.Controls.Add(Me.Label_CCT)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox0)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.TrackBar3)
        Me.GroupBox2.Controls.Add(Me.TrackBar4)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 240)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Light Control"
        '
        'CCT
        '
        Me.CCT.AutoSize = True
        Me.CCT.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CCT.Location = New System.Drawing.Point(27, 34)
        Me.CCT.Name = "CCT"
        Me.CCT.Size = New System.Drawing.Size(31, 17)
        Me.CCT.TabIndex = 7
        Me.CCT.Text = "CCT"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(133, 36)
        Me.TrackBar1.Maximum = 2
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(141, 45)
        Me.TrackBar1.TabIndex = 23
        '
        'Brightness
        '
        Me.Brightness.AutoSize = True
        Me.Brightness.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Brightness.Location = New System.Drawing.Point(16, 83)
        Me.Brightness.Name = "Brightness"
        Me.Brightness.Size = New System.Drawing.Size(69, 17)
        Me.Brightness.TabIndex = 24
        Me.Brightness.Text = "Brightness"
        '
        'Label_LUX
        '
        Me.Label_LUX.AutoSize = True
        Me.Label_LUX.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_LUX.Location = New System.Drawing.Point(281, 80)
        Me.Label_LUX.Name = "Label_LUX"
        Me.Label_LUX.Size = New System.Drawing.Size(19, 21)
        Me.Label_LUX.TabIndex = 38
        Me.Label_LUX.Text = "0"
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(133, 83)
        Me.TrackBar2.Maximum = 39
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(141, 45)
        Me.TrackBar2.TabIndex = 26
        '
        'Label_CCT
        '
        Me.Label_CCT.AutoSize = True
        Me.Label_CCT.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_CCT.Location = New System.Drawing.Point(283, 33)
        Me.Label_CCT.Name = "Label_CCT"
        Me.Label_CCT.Size = New System.Drawing.Size(46, 21)
        Me.Label_CCT.TabIndex = 37
        Me.Label_CCT.Text = "2000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "PWM CH0 (White)"
        '
        'TextBox0
        '
        Me.TextBox0.Location = New System.Drawing.Point(286, 138)
        Me.TextBox0.Name = "TextBox0"
        Me.TextBox0.Size = New System.Drawing.Size(44, 23)
        Me.TextBox0.TabIndex = 28
        Me.TextBox0.Text = "0"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Button3.Location = New System.Drawing.Point(349, 45)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 45)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "SET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(134, 141)
        Me.TrackBar3.Maximum = 10000
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(140, 45)
        Me.TrackBar3.TabIndex = 29
        '
        'TrackBar4
        '
        Me.TrackBar4.Location = New System.Drawing.Point(134, 192)
        Me.TrackBar4.Maximum = 10000
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Size = New System.Drawing.Size(140, 45)
        Me.TrackBar4.TabIndex = 34
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(286, 189)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(44, 23)
        Me.TextBox1.TabIndex = 33
        Me.TextBox1.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "PWM CH1 (Amber)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button17)
        Me.GroupBox1.Controls.Add(Me.Button16)
        Me.GroupBox1.Controls.Add(Me.TB_VEXT)
        Me.GroupBox1.Controls.Add(Me.TB_VBAT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button15)
        Me.GroupBox1.Controls.Add(Me.Button14)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.IOMode)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Btn_VBAT)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Btn_VEXT)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 428)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 213)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(266, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 17)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "V"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(265, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "V"
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(165, 30)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(53, 26)
        Me.Button17.TabIndex = 61
        Me.Button17.Text = "DIS"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(110, 30)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(49, 26)
        Me.Button16.TabIndex = 60
        Me.Button16.Text = "EN"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'TB_VEXT
        '
        Me.TB_VEXT.Location = New System.Drawing.Point(233, 175)
        Me.TB_VEXT.Name = "TB_VEXT"
        Me.TB_VEXT.Size = New System.Drawing.Size(31, 23)
        Me.TB_VEXT.TabIndex = 59
        Me.TB_VEXT.Text = "1.5"
        '
        'TB_VBAT
        '
        Me.TB_VBAT.Location = New System.Drawing.Point(233, 141)
        Me.TB_VBAT.Name = "TB_VBAT"
        Me.TB_VBAT.Size = New System.Drawing.Size(31, 23)
        Me.TB_VBAT.TabIndex = 58
        Me.TB_VBAT.Text = "2.5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "IR Self Filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "IO Table"
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(349, 30)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(66, 26)
        Me.Button15.TabIndex = 56
        Me.Button15.Text = "Output"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(285, 68)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(130, 26)
        Me.Button14.TabIndex = 55
        Me.Button14.Text = "SetOutputMode"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(286, 30)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(63, 26)
        Me.Button13.TabIndex = 54
        Me.Button13.Text = "Input"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'IOMode
        '
        Me.IOMode.Location = New System.Drawing.Point(233, 70)
        Me.IOMode.Name = "IOMode"
        Me.IOMode.Size = New System.Drawing.Size(44, 23)
        Me.IOMode.TabIndex = 53
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(283, 104)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 28)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "Dimming/step (ms)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(233, 106)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(44, 23)
        Me.TextBox6.TabIndex = 52
        Me.TextBox6.Text = "100"
        '
        'Btn_VBAT
        '
        Me.Btn_VBAT.Location = New System.Drawing.Point(283, 138)
        Me.Btn_VBAT.Name = "Btn_VBAT"
        Me.Btn_VBAT.Size = New System.Drawing.Size(132, 30)
        Me.Btn_VBAT.TabIndex = 49
        Me.Btn_VBAT.Text = "Set Vbat_M TH"
        Me.Btn_VBAT.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(79, 70)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(139, 28)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "LogLevel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(29, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(44, 23)
        Me.TextBox2.TabIndex = 40
        Me.TextBox2.Text = "0"
        '
        'Btn_VEXT
        '
        Me.Btn_VEXT.Location = New System.Drawing.Point(283, 172)
        Me.Btn_VEXT.Name = "Btn_VEXT"
        Me.Btn_VEXT.Size = New System.Drawing.Size(132, 30)
        Me.Btn_VEXT.TabIndex = 48
        Me.Btn_VEXT.Text = "Set Vext_M TH"
        Me.Btn_VEXT.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(29, 175)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(44, 23)
        Me.TextBox5.TabIndex = 47
        Me.TextBox5.Text = "1000"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(79, 104)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 28)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "Long press time (ms)"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(79, 172)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(139, 28)
        Me.Button8.TabIndex = 46
        Me.Button8.Text = "Light convert time (ms)"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(29, 107)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(44, 23)
        Me.TextBox3.TabIndex = 43
        Me.TextBox3.Text = "800"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(29, 141)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(44, 23)
        Me.TextBox4.TabIndex = 45
        Me.TextBox4.Text = "30"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(79, 138)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(139, 28)
        Me.Button7.TabIndex = 44
        Me.Button7.Text = "Light auto off (s)"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(796, 650)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Light debug tool for STM32F103 v0.2  by George"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Btn_Start As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CCT As System.Windows.Forms.Label
    Friend WithEvents Combo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents Brightness As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label_LUX As System.Windows.Forms.Label
    Friend WithEvents Label_CCT As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TrackBar4 As System.Windows.Forms.TrackBar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Btn_VEXT As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_VBAT As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents RevBox As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents SendBox As System.Windows.Forms.TextBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents IOMode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents TB_VEXT As System.Windows.Forms.TextBox
    Friend WithEvents TB_VBAT As System.Windows.Forms.TextBox
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
