Imports System.io.Ports

Public Class Form1
    Private WithEvents RS485 As LHSerialPort
    Public prm As prmDistribute
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prm = New prmDistribute

        BufferReset(_readbuffer)
        GroupBox2.Enabled = False
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
        GroupBox6.Enabled = False
        GroupBox3.Enabled = False

        '串口界面初始化
        cmbCom.SelectedIndex = 2
        txtBaud.Text = "1200"
        cmbParity.SelectedIndex = 1
        txtRts前沿.Text = _rts前沿
        txtRts后沿.Text = _rts后沿

        '轮询、启动、招记录信息界面初始化
        txtAdd.Text = "A5"

        '对时界面初始化
        txtHour.Text = Now.Hour
        txtMinute.Text = Now.Minute
        txtSecond.Text = Now.Second

        '整点界面初始化
        txtIntegralAdd.Text = "A5"
        txtIntegralHour.Text = Now.Hour
        txtIntegralPart.Text = 0

        '参数下发界面初始化
        txtDisAdd.Text = "A5"
        txtDisSecond.Text = Now.Second
        txtDisMinute.Text = Now.Minute
        txtDisHour.Text = Now.Hour
        txtDisWeek.Text = Now.DayOfWeek
        txtDisDay.Text = Now.Day
        txtDisMonth.Text = Now.Month
        txtDisYear.Text = Now.Year - 2000
        cmbDisVolt.SelectedIndex = 0
        cmbDisWei.SelectedIndex = 0
        cmbDisCurrent.SelectedIndex = 0
        txtMax.Text = "90"
        txtMin.Text = "70"

        '招记录界面初始化
        txtReAdd.Text = "A5"
        txtReHour.Text = "999"
        txtReMinute.Text = "59"
        txtReSecond.Text = "59"
    End Sub

    Private Sub BufferReset(ByVal mbuffer() As Byte)
        For i = 0 To mbuffer.Length - 1
            mbuffer(i) = 0
        Next
    End Sub
    Private Sub btnComEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComEnable.Click
        Dim strCom As String = cmbCom.SelectedItem
        Dim baud As Integer = txtBaud.Text
        Dim mparity As Parity
        If cmbParity.SelectedIndex = 0 Then
            mparity = Parity.Odd
        Else
            mparity = Parity.Even
        End If
        RS485 = New LHSerialPort(strCom, baud, mparity, 8, 1)
        Try
            RS485.Open()
        Catch ex As Exception
            MsgBox("串口打开失败，请检查设置！")
            Exit Sub
        End Try
        RS485.RtsEnable = True
        GroupBox2.Enabled = True
        GroupBox4.Enabled = True
        GroupBox5.Enabled = True
        GroupBox6.Enabled = True
        GroupBox3.Enabled = True
    End Sub

    Private Sub btnComDisable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComDisable.Click
        If RS485.IsOpen Then RS485.Close()
        GroupBox2.Enabled = False
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
        GroupBox6.Enabled = False
        GroupBox3.Enabled = False
    End Sub

    Private Sub txtSend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSend.TextChanged
        txtSend.SelectionStart = txtSend.TextLength
        txtSend.ScrollToCaret()
    End Sub
    Private Sub txtRecv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecv.TextChanged
        txtSend.SelectionStart = txtSend.TextLength
        txtSend.ScrollToCaret()
    End Sub
    Private Sub showbyte(ByVal txt As TextBox, ByVal cmd() As Byte, ByVal len As Byte)
        For i = 1 To len
            txt.Text += cmd(i - 1).ToString("X2") & " "
        Next
        txt.Text += vbNewLine
    End Sub

    Private Sub btnPolling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPolling.Click
        Dim address As Byte = str2byte(txtAdd.Text)
        DownloadCmd.Polling(RS485, address)
        showbyte(txtSend, RS485.outputbuffer, RS485.outputlength)
        tmrRecv.Interval = 300 + 210
        tmrRecv.Enabled = True
    End Sub

    Private Sub btnRts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRts.Click
        _rts后沿 = txtRts后沿.Text
        _rts前沿 = txtRts前沿.Text
    End Sub

    Private Sub tmrRecv_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRecv.Tick
        tmrRecv.Enabled = False
        RS485.ReadUp(_readbuffer)
        If _readbuffer(1) <> 0 Then
            showbyte(txtRecv, _readbuffer, _readbuffer(1) + 5)
        End If
        BufferReset(_readbuffer)
    End Sub

    Private Sub chkIsSysTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsSysTime.CheckedChanged
        If chkIsSysTime.Checked Then
            txtHour.Enabled = False
            txtMinute.Enabled = False
            txtSecond.Enabled = False
        Else
            txtHour.Enabled = True
            txtMinute.Enabled = True
            txtSecond.Enabled = True
        End If
    End Sub

    Private Sub btnTimeModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeModify.Click
        Dim hour As Byte, minute As Byte, second As Byte
        If chkIsSysTime.Checked Then
            hour = DownloadCmd.Num2BCD(Now.Hour)
            minute = DownloadCmd.Num2BCD(Now.Minute)
            second = DownloadCmd.Num2BCD(Now.Second)
        Else
            hour = DownloadCmd.Num2BCD(txtHour.Text)
            minute = DownloadCmd.Num2BCD(txtMinute.Text)
            second = DownloadCmd.Num2BCD(txtSecond.Text)
        End If

        DownloadCmd.TimeModify(RS485, &H3F, second, minute, hour)
        showbyte(txtSend, RS485.outputbuffer, RS485.outputlength)
        tmrRecv.Interval = 300 + 80
        tmrRecv.Enabled = True
    End Sub

    Private Sub lblPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPos.Click
        frmPos.Show()
    End Sub

    Private Sub btnStartup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartup.Click
        Dim address As Byte = str2byte(txtAdd.Text)
        DownloadCmd.Startup(RS485, address)
        showbyte(txtSend, RS485.outputbuffer, RS485.outputlength)
        tmrRecv.Interval = 300 + 120
        tmrRecv.Enabled = True
    End Sub

    Private Function str2byte(ByVal str As String)
        Dim result As Byte
        Dim input() As Char = str.ToCharArray
        Select Case input(1)
            Case "0" : result = &H0
            Case "1" : result = &H1
            Case "2" : result = &H2
            Case "3" : result = &H3
            Case "4" : result = &H4
            Case "5" : result = &H5
            Case "6" : result = &H6
            Case "7" : result = &H7
            Case "8" : result = &H8
            Case "9" : result = &H9
            Case "A" : result = &HA
            Case "B" : result = &HB
            Case "C" : result = &HC
            Case "D" : result = &HD
            Case "E" : result = &HE
            Case "F" : result = &HF
        End Select
        Select Case input(0)
            Case "0" : result += (&H0 << 4)
            Case "1" : result += (&H1 << 4)
            Case "2" : result += (&H2 << 4)
            Case "3" : result += (&H3 << 4)
            Case "4" : result += (&H4 << 4)
            Case "5" : result += (&H5 << 4)
            Case "6" : result += (&H6 << 4)
            Case "7" : result += (&H7 << 4)
            Case "8" : result += (&H8 << 4)
            Case "9" : result += (&H9 << 4)
            Case "A" : result += (&HA << 4)
            Case "B" : result += (&HB << 4)
            Case "C" : result += (&HC << 4)
            Case "D" : result += (&HD << 4)
            Case "E" : result += (&HE << 4)
            Case "F" : result += (&HF << 4)
        End Select
        Return result
    End Function

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        Dim address As Byte = str2byte(txtAdd.Text)
        DownloadCmd.Record(RS485, address)
        showbyte(txtSend, RS485.outputbuffer, RS485.outputlength)
        tmrRecv.Interval = 300 + 220
        tmrRecv.Enabled = True
    End Sub

    Private Sub btnIntegral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntegral.Click
        Dim address As Byte = str2byte(txtIntegralAdd.Text)
        Dim part As Byte = txtIntegralPart.Text
        dim hour As Byte = txtIntegralHour.Text
        DownloadCmd.Integral(RS485, address, part, hour)
        showbyte(txtSend, RS485.outputbuffer, RS485.outputlength)
        tmrRecv.Interval = 300 + 400
        tmrRecv.Enabled = True
    End Sub

    Private Sub btnDistribute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistribute.Click
        Dim address As Byte = str2byte(txtDisAdd.Text)

        prm.max = str2byte(txtMax.Text)
        prm.mini = str2byte(txtMin.Text)
        If chkDis.Checked Then
            prm.hour = DownloadCmd.Num2BCD(Now.Hour)
            prm.minute = DownloadCmd.Num2BCD(Now.Minute)
            prm.second = DownloadCmd.Num2BCD(Now.Second)
            prm.week = DownloadCmd.Num2BCD(Now.DayOfWeek)
            prm.day = DownloadCmd.Num2BCD(Now.Day)
            prm.month = DownloadCmd.Num2BCD(Now.Month)
            prm.year = DownloadCmd.Num2BCD(Now.Year - 2000)
        Else
            prm.hour = DownloadCmd.Num2BCD(txtDisHour.Text)
            prm.minute = DownloadCmd.Num2BCD(txtDisMinute.Text)
            prm.second = DownloadCmd.Num2BCD(txtDisSecond.Text)
            prm.week = DownloadCmd.Num2BCD(txtDisWeek.Text)
            prm.day = DownloadCmd.Num2BCD(txtDisDay.Text)
            prm.month = DownloadCmd.Num2BCD(txtDisMonth.Text)
            prm.year = DownloadCmd.Num2BCD(txtDisYear.Text)
        End If

        prm.type = (cmbDisWei.SelectedIndex << 4) + cmbDisVolt.SelectedIndex
        If cmbDisCurrent.SelectedIndex = 0 Then '10mA
            prm.type = prm.type Or &B1000000
        ElseIf cmbDisCurrent.SelectedIndex = 1 Then '20mA
            prm.type = prm.type Or &B10000000
        ElseIf cmbDisCurrent.SelectedIndex = 2 Then '30mA
            prm.type = prm.type Or &B11000000
        ElseIf cmbDisCurrent.SelectedIndex = 3 Then '无电流
            prm.type = prm.type Or &B11001000
        End If

        DownloadCmd.Distribute(RS485, prm, address)
        showbyte(txtSend, RS485.outputbuffer, RS485.outputlength)
        tmrRecv.Interval = 300 + 320
        tmrRecv.Enabled = True
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        txtSend.Text = ""
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        txtRecv.Text=""
    End Sub

    
    Private Sub btnLHTimeModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLHTimeModify.Click
        Dim address As Byte = str2byte(txtReAdd.Text)
        Dim second As Byte = DownloadCmd.Num2BCD(txtReSecond.Text)
        Dim minute As Byte = DownloadCmd.Num2BCD(txtReMinute.Text)
        Dim lhour As Byte = txtReHour.Text Mod 256
        Dim hhour As Byte = txtReHour.Text \ 256

        DownloadCmd.LHTimeModify(RS485,address,second,minute,hhour,lhour)
        showbyte(txtSend, RS485.outputbuffer, RS485.outputlength)
        tmrRecv.Interval = 300 + 140
        tmrRecv.Enabled = True
    End Sub

    Private Sub Form1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If RS485.IsOpen Then RS485.Close()
    End Sub
End Class

Public Class prmDistribute
    Public second As Byte
    Public minute As Byte
    Public hour As Byte
    Public week As Byte
    Public day As Byte
    Public month As Byte
    Public year As Byte
    Public pos(11) As Byte
    Public type As Byte
    Public max As Byte
    Public mini As Byte
End Class

Public Class commFlag
    Public polling As Boolean
    Public startup As Boolean
    Public integral As Boolean
    Public unitNo As Byte
End Class

Public Class LHSerialPort
    Inherits System.IO.Ports.SerialPort

    Public outputbuffer(31) As Byte
    Public outputlength As Byte

    Public Shared beginning As Byte = &HA5   '起始符
    Public Shared terminal As Byte = &H16   '结束符

    '命令域
    Public Shared cmdOrdinary As Byte = &H3 '一般请求
    Public Shared cmdIntegral As Byte = &HC '整点数据请求
    Public Shared cmdDistribute As Byte = &HF   '参数下发
    Public Shared cmdStartup As Byte = &H30 '启动
    Public Shared cmdTimeModify As Byte = &H3F '对时
    Public Shared cmdLHTimeModify As Byte = &HC0 '老化时间校正
    Public Shared cmdRecord As Byte = &HC3 '招记录信息

    Public Sub New(ByVal portName As String, ByVal baudRate As Integer, _
                   ByVal parity As IO.Ports.Parity, ByVal dataBits As Integer, ByVal stopBits As IO.Ports.StopBits)
        MyBase.new(portName, baudRate, parity, dataBits, stopBits)
    End Sub
    Private Function CS(ByVal input() As Byte, ByVal len As Integer) As Byte
        '计算校验码
        Dim input2(len - 1) As Byte
        For i = 0 To len - 1
            input2(i) = input(i)
        Next

        Dim num As Integer = 0
        For i = 0 To input2.Length - 1
            num += input2(i)
        Next
        Dim re As Byte = num Mod 256
        Return re
    End Function

    '发送一般请求帧
    Public Sub WriteOrdinary(ByVal address As Byte)
        Dim wbuffer(6) As Byte
        wbuffer(0) = beginning
        wbuffer(1) = 2
        wbuffer(2) = beginning
        wbuffer(3) = address
        wbuffer(4) = cmdOrdinary
        wbuffer(5) = CS(wbuffer, wbuffer.Length - 2)
        wbuffer(6) = terminal

        MyBase.Write(wbuffer, 0, wbuffer.Length)

        outputbuffer = wbuffer
        outputlength = wbuffer.Length
    End Sub

    '发送启动帧
    Public Sub WriteStartup(ByVal address As Byte)
        Dim wbuffer(6) As Byte
        wbuffer(0) = beginning
        wbuffer(1) = 2
        wbuffer(2) = beginning
        wbuffer(3) = address
        wbuffer(4) = cmdStartup
        wbuffer(5) = CS(wbuffer, wbuffer.Length - 2)
        wbuffer(6) = terminal
        MyBase.Write(wbuffer, 0, wbuffer.Length)

        outputbuffer = wbuffer
        outputlength = wbuffer.Length
    End Sub

    '发送参数下发帧
    Public Sub WriteDistribute(ByVal address As Byte, ByVal prm As prmDistribute)
        Dim wbuffer(28) As Byte
        wbuffer(0) = beginning
        wbuffer(1) = 24
        wbuffer(2) = beginning
        wbuffer(3) = address
        wbuffer(4) = cmdDistribute
        wbuffer(5) = prm.second
        wbuffer(6) = prm.minute
        wbuffer(7) = prm.hour
        wbuffer(8) = prm.week
        wbuffer(9) = prm.day
        wbuffer(10) = prm.month
        wbuffer(11) = prm.year
        For i = 0 To 11
            wbuffer(12 + i) = prm.pos(i)
        Next
        wbuffer(24) = prm.type
        wbuffer(25) = prm.max
        wbuffer(26) = prm.mini
        wbuffer(27) = CS(wbuffer, wbuffer.Length - 2)
        wbuffer(28) = terminal
        MyBase.Write(wbuffer, 0, wbuffer.Length)

        outputbuffer = wbuffer
        outputlength = wbuffer.Length
    End Sub

    '发送整点数据请求帧
    Public Sub WriteIntegral(ByVal address As Byte, ByVal part As Byte, ByVal time As Byte)
        Dim wbuffer(7) As Byte

        wbuffer(0) = beginning
        wbuffer(1) = 3
        wbuffer(2) = beginning
        wbuffer(3) = address
        wbuffer(4) = cmdIntegral
        wbuffer(5) = (part << 6) + time
        wbuffer(6) = CS(wbuffer, wbuffer.Length - 2)
        wbuffer(7) = terminal
        MyBase.Write(wbuffer, 0, wbuffer.Length)

        outputbuffer = wbuffer
        outputlength = wbuffer.Length
    End Sub

    '发送对时帧
    Public Sub WriteTimeModify(ByVal address As Byte, ByVal second As Byte, ByVal minute As Byte, ByVal hour As Byte)
        Dim wbuffer(9) As Byte

        wbuffer(0) = beginning
        wbuffer(1) = 5
        wbuffer(2) = beginning
        wbuffer(3) = address
        wbuffer(4) = cmdTimeModify
        wbuffer(5) = second
        wbuffer(6) = minute
        wbuffer(7) = hour
        wbuffer(8) = CS(wbuffer, wbuffer.Length - 2)
        wbuffer(9) = terminal
        MyBase.Write(wbuffer, 0, wbuffer.Length)

        outputbuffer = wbuffer
        outputlength = wbuffer.Length
    End Sub

    '发送老化时间对时帧
    Public Sub WriteLHTimeModify(ByVal address As Byte, ByVal second As Byte, _
                                 ByVal minute As Byte, ByVal lhour As Byte, ByVal hhour As Byte)
        Dim wbuffer(10) As Byte

        wbuffer(0) = beginning
        wbuffer(1) = 6
        wbuffer(2) = beginning
        wbuffer(3) = address
        wbuffer(4) = cmdLHTimeModify
        wbuffer(5) = second
        wbuffer(6) = minute
        wbuffer(7) = lhour
        wbuffer(8) = hhour
        wbuffer(9) = CS(wbuffer, wbuffer.Length - 2)
        wbuffer(10) = terminal
        MyBase.Write(wbuffer, 0, wbuffer.Length)

        outputbuffer = wbuffer
        outputlength = wbuffer.Length
    End Sub

    '发送招记录信息帧
    Public Sub WriteRecord(ByVal address As Byte)
        Dim wbuffer(6) As Byte
        wbuffer(0) = beginning
        wbuffer(1) = 2
        wbuffer(2) = beginning
        wbuffer(3) = address
        wbuffer(4) = cmdRecord
        wbuffer(5) = CS(wbuffer, wbuffer.Length - 2)
        wbuffer(6) = terminal
        MyBase.Write(wbuffer, 0, wbuffer.Length)

        outputbuffer = wbuffer
        outputlength = wbuffer.Length
    End Sub
    Public Function ReadUp(ByRef buffer() As Byte) As Boolean
        Dim len As Byte
        If BytesToRead > 0 Then
            While Not MyBase.ReadByte() = &H63  '查找起始字符
                If BytesToRead = 0 Then Return False
            End While

            len = MyBase.ReadByte()             '地址域+命令域+数据域，比帧长度小5字节
            buffer(0) = &H63
            buffer(1) = len
            MyBase.Read(buffer, 2, len + 3)

            If buffer(len + 4) <> &H16 Then Return False '不是以结束符结尾
            If CS(buffer, len + 3) <> buffer(len + 3) Then Return False '校验错误

            Return True
        End If
        Return False
    End Function

End Class
