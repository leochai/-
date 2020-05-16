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
        Me.cmbCom = New System.Windows.Forms.ComboBox()
        Me.btnComEnable = New System.Windows.Forms.Button()
        Me.btnComDisable = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRts = New System.Windows.Forms.Button()
        Me.txtRts后沿 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRts前沿 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbParity = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBaud = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnStartup = New System.Windows.Forms.Button()
        Me.btnPolling = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.txtRecv = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tmrRecv = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkIsSysTime = New System.Windows.Forms.CheckBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMinute = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnTimeModify = New System.Windows.Forms.Button()
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtIntegralAdd = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtIntegralPart = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnIntegral = New System.Windows.Forms.Button()
        Me.txtIntegralHour = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmbDisCurrent = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbDisVolt = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbDisWei = New System.Windows.Forms.ComboBox()
        Me.chkDis = New System.Windows.Forms.CheckBox()
        Me.txtDisYear = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDisMonth = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDisDay = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDisWeek = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDisHour = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDisMinute = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDisAdd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnDistribute = New System.Windows.Forms.Button()
        Me.txtDisSecond = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtReAdd = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtReSecond = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtReMinute = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnLHTimeModify = New System.Windows.Forms.Button()
        Me.txtReHour = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCom
        '
        Me.cmbCom.FormattingEnabled = True
        Me.cmbCom.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8"})
        Me.cmbCom.Location = New System.Drawing.Point(80, 29)
        Me.cmbCom.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCom.Name = "cmbCom"
        Me.cmbCom.Size = New System.Drawing.Size(72, 41)
        Me.cmbCom.TabIndex = 0
        '
        'btnComEnable
        '
        Me.btnComEnable.Location = New System.Drawing.Point(480, 26)
        Me.btnComEnable.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComEnable.Name = "btnComEnable"
        Me.btnComEnable.Size = New System.Drawing.Size(108, 25)
        Me.btnComEnable.TabIndex = 1
        Me.btnComEnable.Text = "打开串口"
        Me.btnComEnable.UseVisualStyleBackColor = True
        '
        'btnComDisable
        '
        Me.btnComDisable.Location = New System.Drawing.Point(596, 26)
        Me.btnComDisable.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComDisable.Name = "btnComDisable"
        Me.btnComDisable.Size = New System.Drawing.Size(108, 25)
        Me.btnComDisable.TabIndex = 1
        Me.btnComDisable.Text = "关闭串口"
        Me.btnComDisable.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRts)
        Me.GroupBox1.Controls.Add(Me.txtRts后沿)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtRts前沿)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbParity)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBaud)
        Me.GroupBox1.Controls.Add(Me.cmbCom)
        Me.GroupBox1.Controls.Add(Me.btnComDisable)
        Me.GroupBox1.Controls.Add(Me.btnComEnable)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(721, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "串口设置"
        '
        'btnRts
        '
        Me.btnRts.Location = New System.Drawing.Point(480, 65)
        Me.btnRts.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRts.Name = "btnRts"
        Me.btnRts.Size = New System.Drawing.Size(108, 25)
        Me.btnRts.TabIndex = 11
        Me.btnRts.Text = "设定前后沿"
        Me.btnRts.UseVisualStyleBackColor = True
        '
        'txtRts后沿
        '
        Me.txtRts后沿.Location = New System.Drawing.Point(374, 66)
        Me.txtRts后沿.Name = "txtRts后沿"
        Me.txtRts后沿.Size = New System.Drawing.Size(72, 44)
        Me.txtRts后沿.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(323, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 33)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "后沿"
        '
        'txtRts前沿
        '
        Me.txtRts前沿.Location = New System.Drawing.Point(228, 66)
        Me.txtRts前沿.Name = "txtRts前沿"
        Me.txtRts前沿.Size = New System.Drawing.Size(84, 44)
        Me.txtRts前沿.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 33)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "前沿"
        '
        'cmbParity
        '
        Me.cmbParity.FormattingEnabled = True
        Me.cmbParity.Items.AddRange(New Object() {"奇校验", "偶校验"})
        Me.cmbParity.Location = New System.Drawing.Point(374, 26)
        Me.cmbParity.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbParity.Name = "cmbParity"
        Me.cmbParity.Size = New System.Drawing.Size(72, 41)
        Me.cmbParity.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 33)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "校验"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "波特率"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "串口号"
        '
        'txtBaud
        '
        Me.txtBaud.Location = New System.Drawing.Point(228, 25)
        Me.txtBaud.Name = "txtBaud"
        Me.txtBaud.Size = New System.Drawing.Size(84, 44)
        Me.txtBaud.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRecord)
        Me.GroupBox2.Controls.Add(Me.btnStartup)
        Me.GroupBox2.Controls.Add(Me.btnPolling)
        Me.GroupBox2.Controls.Add(Me.txtAdd)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(720, 64)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "轮询、启动、招记录信息"
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(593, 28)
        Me.btnRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(108, 25)
        Me.btnRecord.TabIndex = 7
        Me.btnRecord.Text = "招记录信息"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnStartup
        '
        Me.btnStartup.Location = New System.Drawing.Point(477, 28)
        Me.btnStartup.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStartup.Name = "btnStartup"
        Me.btnStartup.Size = New System.Drawing.Size(108, 25)
        Me.btnStartup.TabIndex = 7
        Me.btnStartup.Text = "启动"
        Me.btnStartup.UseVisualStyleBackColor = True
        '
        'btnPolling
        '
        Me.btnPolling.Location = New System.Drawing.Point(361, 28)
        Me.btnPolling.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPolling.Name = "btnPolling"
        Me.btnPolling.Size = New System.Drawing.Size(108, 25)
        Me.btnPolling.TabIndex = 7
        Me.btnPolling.Text = "轮询"
        Me.btnPolling.UseVisualStyleBackColor = True
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(74, 26)
        Me.txtAdd.MaxLength = 2
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(72, 44)
        Me.txtAdd.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "地  址"
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(760, 54)
        Me.txtSend.Multiline = True
        Me.txtSend.Name = "txtSend"
        Me.txtSend.ReadOnly = True
        Me.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSend.Size = New System.Drawing.Size(296, 232)
        Me.txtSend.TabIndex = 4
        '
        'txtRecv
        '
        Me.txtRecv.Location = New System.Drawing.Point(760, 313)
        Me.txtRecv.Multiline = True
        Me.txtRecv.Name = "txtRecv"
        Me.txtRecv.ReadOnly = True
        Me.txtRecv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecv.Size = New System.Drawing.Size(296, 232)
        Me.txtRecv.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(757, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(335, 33)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "发送窗口（点我清空）"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(757, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(335, 33)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "接收窗口（点我清空）"
        '
        'tmrRecv
        '
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkIsSysTime)
        Me.GroupBox4.Controls.Add(Me.txtSecond)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtMinute)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.btnTimeModify)
        Me.GroupBox4.Controls.Add(Me.txtHour)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 190)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(720, 64)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "对时"
        '
        'chkIsSysTime
        '
        Me.chkIsSysTime.AutoSize = True
        Me.chkIsSysTime.Location = New System.Drawing.Point(27, 33)
        Me.chkIsSysTime.Name = "chkIsSysTime"
        Me.chkIsSysTime.Size = New System.Drawing.Size(175, 37)
        Me.chkIsSysTime.TabIndex = 12
        Me.chkIsSysTime.Text = "系统时间"
        Me.chkIsSysTime.UseVisualStyleBackColor = True
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(404, 28)
        Me.txtSecond.MaxLength = 2
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(72, 44)
        Me.txtSecond.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(377, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 33)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "秒"
        '
        'txtMinute
        '
        Me.txtMinute.Location = New System.Drawing.Point(284, 28)
        Me.txtMinute.MaxLength = 2
        Me.txtMinute.Name = "txtMinute"
        Me.txtMinute.Size = New System.Drawing.Size(72, 44)
        Me.txtMinute.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(257, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 33)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "分"
        '
        'btnTimeModify
        '
        Me.btnTimeModify.Location = New System.Drawing.Point(593, 28)
        Me.btnTimeModify.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTimeModify.Name = "btnTimeModify"
        Me.btnTimeModify.Size = New System.Drawing.Size(108, 25)
        Me.btnTimeModify.TabIndex = 7
        Me.btnTimeModify.Text = "发送命令"
        Me.btnTimeModify.UseVisualStyleBackColor = True
        '
        'txtHour
        '
        Me.txtHour.Location = New System.Drawing.Point(166, 28)
        Me.txtHour.MaxLength = 2
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(72, 44)
        Me.txtHour.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(139, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 33)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "时"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtIntegralAdd)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtIntegralPart)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.btnIntegral)
        Me.GroupBox5.Controls.Add(Me.txtIntegralHour)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 260)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(720, 64)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "整点"
        '
        'txtIntegralAdd
        '
        Me.txtIntegralAdd.Location = New System.Drawing.Point(78, 28)
        Me.txtIntegralAdd.MaxLength = 2
        Me.txtIntegralAdd.Name = "txtIntegralAdd"
        Me.txtIntegralAdd.Size = New System.Drawing.Size(72, 44)
        Me.txtIntegralAdd.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 33)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "地  址"
        '
        'txtIntegralPart
        '
        Me.txtIntegralPart.Location = New System.Drawing.Point(334, 28)
        Me.txtIntegralPart.MaxLength = 1
        Me.txtIntegralPart.Name = "txtIntegralPart"
        Me.txtIntegralPart.Size = New System.Drawing.Size(72, 44)
        Me.txtIntegralPart.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(290, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 33)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "分区"
        '
        'btnIntegral
        '
        Me.btnIntegral.Location = New System.Drawing.Point(593, 28)
        Me.btnIntegral.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIntegral.Name = "btnIntegral"
        Me.btnIntegral.Size = New System.Drawing.Size(108, 25)
        Me.btnIntegral.TabIndex = 7
        Me.btnIntegral.Text = "发送命令"
        Me.btnIntegral.UseVisualStyleBackColor = True
        '
        'txtIntegralHour
        '
        Me.txtIntegralHour.Location = New System.Drawing.Point(199, 28)
        Me.txtIntegralHour.MaxLength = 2
        Me.txtIntegralHour.Name = "txtIntegralHour"
        Me.txtIntegralHour.Size = New System.Drawing.Size(72, 44)
        Me.txtIntegralHour.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(172, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 33)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "时"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmbDisCurrent)
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.txtMin)
        Me.GroupBox6.Controls.Add(Me.txtMax)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.lblPos)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.cmbDisVolt)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.cmbDisWei)
        Me.GroupBox6.Controls.Add(Me.chkDis)
        Me.GroupBox6.Controls.Add(Me.txtDisYear)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.txtDisMonth)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.txtDisDay)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txtDisWeek)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.txtDisHour)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txtDisMinute)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.txtDisAdd)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.btnDistribute)
        Me.GroupBox6.Controls.Add(Me.txtDisSecond)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 330)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(720, 145)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "下发"
        '
        'cmbDisCurrent
        '
        Me.cmbDisCurrent.FormattingEnabled = True
        Me.cmbDisCurrent.Items.AddRange(New Object() {"10mA", "20mA", "30mA", "无电流"})
        Me.cmbDisCurrent.Location = New System.Drawing.Point(356, 78)
        Me.cmbDisCurrent.Name = "cmbDisCurrent"
        Me.cmbDisCurrent.Size = New System.Drawing.Size(58, 41)
        Me.cmbDisCurrent.TabIndex = 31
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(279, 82)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(143, 33)
        Me.Label31.TabIndex = 30
        Me.Label31.Text = "电流规格"
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(594, 76)
        Me.txtMin.MaxLength = 2
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(72, 44)
        Me.txtMin.TabIndex = 29
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(472, 76)
        Me.txtMax.MaxLength = 2
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(72, 44)
        Me.txtMax.TabIndex = 29
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(549, 81)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 33)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "下限"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(428, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 33)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "上限"
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Location = New System.Drawing.Point(19, 122)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(239, 33)
        Me.lblPos.TabIndex = 27
        Me.lblPos.Text = "点此输入对位表"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(151, 82)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(143, 33)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "电压规格"
        '
        'cmbDisVolt
        '
        Me.cmbDisVolt.FormattingEnabled = True
        Me.cmbDisVolt.Items.AddRange(New Object() {"21V", "25V", "28V", "16V", "5.5V", "保留", "保留", "无电压"})
        Me.cmbDisVolt.Location = New System.Drawing.Point(223, 78)
        Me.cmbDisVolt.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDisVolt.Name = "cmbDisVolt"
        Me.cmbDisVolt.Size = New System.Drawing.Size(55, 41)
        Me.cmbDisVolt.TabIndex = 25
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(19, 83)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(143, 33)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "器件位数"
        '
        'cmbDisWei
        '
        Me.cmbDisWei.FormattingEnabled = True
        Me.cmbDisWei.Items.AddRange(New Object() {"一位", "二位", "四位", "独立"})
        Me.cmbDisWei.Location = New System.Drawing.Point(95, 77)
        Me.cmbDisWei.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDisWei.Name = "cmbDisWei"
        Me.cmbDisWei.Size = New System.Drawing.Size(55, 41)
        Me.cmbDisWei.TabIndex = 23
        '
        'chkDis
        '
        Me.chkDis.AutoSize = True
        Me.chkDis.Location = New System.Drawing.Point(571, 31)
        Me.chkDis.Name = "chkDis"
        Me.chkDis.Size = New System.Drawing.Size(207, 37)
        Me.chkDis.TabIndex = 22
        Me.chkDis.Text = "用系统时间"
        Me.chkDis.UseVisualStyleBackColor = True
        '
        'txtDisYear
        '
        Me.txtDisYear.Location = New System.Drawing.Point(528, 28)
        Me.txtDisYear.MaxLength = 2
        Me.txtDisYear.Name = "txtDisYear"
        Me.txtDisYear.Size = New System.Drawing.Size(22, 44)
        Me.txtDisYear.TabIndex = 21
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(501, 34)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 33)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "年"
        '
        'txtDisMonth
        '
        Me.txtDisMonth.Location = New System.Drawing.Point(473, 28)
        Me.txtDisMonth.MaxLength = 2
        Me.txtDisMonth.Name = "txtDisMonth"
        Me.txtDisMonth.Size = New System.Drawing.Size(22, 44)
        Me.txtDisMonth.TabIndex = 19
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(446, 34)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 33)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "月"
        '
        'txtDisDay
        '
        Me.txtDisDay.Location = New System.Drawing.Point(418, 28)
        Me.txtDisDay.MaxLength = 2
        Me.txtDisDay.Name = "txtDisDay"
        Me.txtDisDay.Size = New System.Drawing.Size(22, 44)
        Me.txtDisDay.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(391, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 33)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "日"
        '
        'txtDisWeek
        '
        Me.txtDisWeek.Location = New System.Drawing.Point(363, 28)
        Me.txtDisWeek.MaxLength = 2
        Me.txtDisWeek.Name = "txtDisWeek"
        Me.txtDisWeek.Size = New System.Drawing.Size(22, 44)
        Me.txtDisWeek.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(336, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 33)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "周"
        '
        'txtDisHour
        '
        Me.txtDisHour.Location = New System.Drawing.Point(308, 28)
        Me.txtDisHour.MaxLength = 2
        Me.txtDisHour.Name = "txtDisHour"
        Me.txtDisHour.Size = New System.Drawing.Size(22, 44)
        Me.txtDisHour.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(281, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 33)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "时"
        '
        'txtDisMinute
        '
        Me.txtDisMinute.Location = New System.Drawing.Point(253, 28)
        Me.txtDisMinute.MaxLength = 2
        Me.txtDisMinute.Name = "txtDisMinute"
        Me.txtDisMinute.Size = New System.Drawing.Size(22, 44)
        Me.txtDisMinute.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(226, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 33)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "分"
        '
        'txtDisAdd
        '
        Me.txtDisAdd.Location = New System.Drawing.Point(78, 28)
        Me.txtDisAdd.MaxLength = 2
        Me.txtDisAdd.Name = "txtDisAdd"
        Me.txtDisAdd.Size = New System.Drawing.Size(72, 44)
        Me.txtDisAdd.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 33)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "地  址"
        '
        'btnDistribute
        '
        Me.btnDistribute.Location = New System.Drawing.Point(593, 113)
        Me.btnDistribute.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDistribute.Name = "btnDistribute"
        Me.btnDistribute.Size = New System.Drawing.Size(108, 25)
        Me.btnDistribute.TabIndex = 7
        Me.btnDistribute.Text = "发送命令"
        Me.btnDistribute.UseVisualStyleBackColor = True
        '
        'txtDisSecond
        '
        Me.txtDisSecond.Location = New System.Drawing.Point(199, 28)
        Me.txtDisSecond.MaxLength = 2
        Me.txtDisSecond.Name = "txtDisSecond"
        Me.txtDisSecond.Size = New System.Drawing.Size(22, 44)
        Me.txtDisSecond.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(172, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 33)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "秒"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtReAdd)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.txtReSecond)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.txtReMinute)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.btnLHTimeModify)
        Me.GroupBox3.Controls.Add(Me.txtReHour)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 481)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(720, 64)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "老化时间更新"
        '
        'txtReAdd
        '
        Me.txtReAdd.Location = New System.Drawing.Point(78, 29)
        Me.txtReAdd.MaxLength = 2
        Me.txtReAdd.Name = "txtReAdd"
        Me.txtReAdd.Size = New System.Drawing.Size(72, 44)
        Me.txtReAdd.TabIndex = 13
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(20, 35)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(111, 33)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "地  址"
        '
        'txtReSecond
        '
        Me.txtReSecond.Location = New System.Drawing.Point(434, 29)
        Me.txtReSecond.MaxLength = 2
        Me.txtReSecond.Name = "txtReSecond"
        Me.txtReSecond.Size = New System.Drawing.Size(72, 44)
        Me.txtReSecond.TabIndex = 11
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(407, 35)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 33)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "秒"
        '
        'txtReMinute
        '
        Me.txtReMinute.Location = New System.Drawing.Point(314, 29)
        Me.txtReMinute.MaxLength = 2
        Me.txtReMinute.Name = "txtReMinute"
        Me.txtReMinute.Size = New System.Drawing.Size(72, 44)
        Me.txtReMinute.TabIndex = 9
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(287, 35)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 33)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "分"
        '
        'btnLHTimeModify
        '
        Me.btnLHTimeModify.Location = New System.Drawing.Point(593, 28)
        Me.btnLHTimeModify.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLHTimeModify.Name = "btnLHTimeModify"
        Me.btnLHTimeModify.Size = New System.Drawing.Size(108, 25)
        Me.btnLHTimeModify.TabIndex = 7
        Me.btnLHTimeModify.Text = "发送命令"
        Me.btnLHTimeModify.UseVisualStyleBackColor = True
        '
        'txtReHour
        '
        Me.txtReHour.Location = New System.Drawing.Point(196, 29)
        Me.txtReHour.MaxLength = 3
        Me.txtReHour.Name = "txtReHour"
        Me.txtReHour.Size = New System.Drawing.Size(72, 44)
        Me.txtReHour.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(169, 35)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(47, 33)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "时"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 554)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRecv)
        Me.Controls.Add(Me.txtSend)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "通信规约测试"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCom As System.Windows.Forms.ComboBox
    Friend WithEvents btnComEnable As System.Windows.Forms.Button
    Friend WithEvents btnComDisable As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBaud As System.Windows.Forms.TextBox
    Friend WithEvents cmbParity As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents btnPolling As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRts前沿 As System.Windows.Forms.TextBox
    Friend WithEvents txtRts后沿 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnRts As System.Windows.Forms.Button
    Friend WithEvents txtRecv As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tmrRecv As System.Windows.Forms.Timer
    Friend WithEvents btnStartup As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTimeModify As System.Windows.Forms.Button
    Friend WithEvents txtHour As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMinute As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkIsSysTime As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIntegralAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtIntegralPart As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnIntegral As System.Windows.Forms.Button
    Friend WithEvents txtIntegralHour As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDisAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnDistribute As System.Windows.Forms.Button
    Friend WithEvents txtDisSecond As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDisMinute As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtDisYear As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtDisMonth As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtDisDay As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtDisWeek As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDisHour As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkDis As System.Windows.Forms.CheckBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmbDisWei As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbDisVolt As System.Windows.Forms.ComboBox
    Friend WithEvents lblPos As System.Windows.Forms.Label
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReSecond As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtReMinute As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btnLHTimeModify As System.Windows.Forms.Button
    Friend WithEvents txtReHour As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtReAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As Label
    Friend WithEvents cmbDisCurrent As ComboBox
End Class
