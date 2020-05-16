Public Class DownloadCmd
    Shared lock As New Object

    Public Shared Sub Polling(ByVal com As LHSerialPort, ByVal address As Byte)
        '轮询命令
        SyncLock lock
            'com.RtsEnable = True
            'Threading.Thread.Sleep(_rts前沿)
            com.WriteOrdinary(address)
            'Threading.Thread.Sleep(_rts后沿)
            'com.RtsEnable = False
        End SyncLock
    End Sub

    Public Shared Sub Integral(ByVal com As LHSerialPort, ByVal address As Byte, _
                               ByVal part As Byte, ByVal time As Byte)
        '整点召回
        SyncLock lock
            'com.RtsEnable = True
            'Threading.Thread.Sleep(_rts前沿)
            com.WriteIntegral(address, part, time)
            'Threading.Thread.Sleep(_rts后沿)
            'com.RtsEnable = False
        End SyncLock
    End Sub

    Public Shared Sub Distribute(ByVal com As LHSerialPort, ByVal param As prmDistribute, _
                                 ByVal address As Byte)
        '参数下发
        SyncLock lock
            'com.RtsEnable = True
            'Threading.Thread.Sleep(_rts前沿)
            com.WriteDistribute(address, param)
            'Threading.Thread.Sleep(_rts后沿)
            'com.RtsEnable = False
        End SyncLock
    End Sub

    Public Shared Sub Startup(ByVal com As LHSerialPort, ByVal address As Byte)
        '启动单元
        SyncLock lock
            'com.RtsEnable = True
            'Threading.Thread.Sleep(_rts前沿)
            com.WriteStartup(address)
            'Threading.Thread.Sleep(_rts后沿)
            'com.RtsEnable = False
        End SyncLock
    End Sub

    Public Shared Sub TimeModify(ByVal com As LHSerialPort, ByVal address As Byte, _
                                 ByVal second As Byte, ByVal minute As Byte, ByVal hour As Byte)
        '对时
        SyncLock lock
            'com.RtsEnable = True
            'Threading.Thread.Sleep(_rts前沿)
            com.WriteTimeModify(address, second, minute, hour)
            'Threading.Thread.Sleep(_rts后沿)
            'com.RtsEnable = False
        End SyncLock
    End Sub

    Public Shared Sub LHTimeModify(ByVal com As LHSerialPort, ByVal address As Byte, _
                                 ByVal second As Byte, ByVal minute As Byte, _
                                 ByVal hhour As Byte, ByVal lhour As Byte)
        '老化时间对时
        SyncLock lock
            'com.RtsEnable = True
            'Threading.Thread.Sleep(_rts前沿)
            com.WriteLHTimeModify(address, second, minute,lhour,hhour)
            'Threading.Thread.Sleep(_rts后沿)
            'com.RtsEnable = False
        End SyncLock
    End Sub

    Public Shared Sub Record(ByVal com As LHSerialPort, ByVal address As Byte)
        '招记录信息
        SyncLock lock
            'com.RtsEnable = True
            'Threading.Thread.Sleep(_rts前沿)
            com.WriteRecord(address)
            'Threading.Thread.Sleep(_rts后沿)
            'com.RtsEnable = False
        End SyncLock
    End Sub
    Public Shared Function Num2BCD(ByVal num As Byte) As Byte
        '数字转换为8421BCD码
        Return (num Mod 10) + ((num \ 10) << 4)
    End Function

    Public Shared Function BCD2Num(ByVal bcd As Byte) As Byte
        '8421BCD码转换为数字
        Return (bcd And &HF) + ((bcd >> 4) * 10)
    End Function
End Class
