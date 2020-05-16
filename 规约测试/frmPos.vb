Public Class frmPos
    Dim check(95) As CheckBox
    Dim pos(11) As Byte

    Private Sub frmPos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 11
            'Dim i As Byte = 0
            For j = 0 To 7
                check(i * 8 + j) = New CheckBox
                With check(i * 8 + j)
                    .Width = 70
                    .Left = j * 70 + 10
                    .Top = i * 20 + 10
                    .Text = i * 8 + j + 1
                    .Parent = Me
                End With
                check(i * 8 + j).Show()
            Next
        Next
        For i = 0 To 95 Step 2
            check(i).Text += "-" & i / 2 + 1
        Next
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        For i = 0 To 95
            check(i).Checked = False
        Next
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Form1.lblPos.Text = "点此输入对位表"
        For i = 0 To 11
            For j = 0 To 7
                If check(i * 8 + j).Checked Then
                    pos(i) = pos(i) Or (&H1 << j)
                End If
            Next
            Form1.prm.pos(i) = pos(i)
            Form1.lblPos.Text += " " & Form1.prm.pos(i).ToString("X2")
        Next
        Me.Close()
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        For j = 16 To 88 Step 24
            For i = 0 To 7
                check(j+i).Checked = True
            Next
        Next
    End Sub

    Private Sub btnMid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMid.Click
        For j = 8 To 80 Step 24
            For i = 0 To 7
                check(j + i).Checked = True
            Next
        Next
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        For i = 0 To 95 Step 2
            check(i).Checked = True
        Next
    End Sub
End Class