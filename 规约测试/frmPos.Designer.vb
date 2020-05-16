<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPos
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnMid = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(487, 266)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(70, 22)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "确  认"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(396, 266)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(70, 22)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "重  置"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(334, 267)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(43, 20)
        Me.btnRight.TabIndex = 1
        Me.btnRight.Text = "右"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnMid
        '
        Me.btnMid.Location = New System.Drawing.Point(282, 267)
        Me.btnMid.Name = "btnMid"
        Me.btnMid.Size = New System.Drawing.Size(43, 20)
        Me.btnMid.TabIndex = 2
        Me.btnMid.Text = "中"
        Me.btnMid.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(233, 267)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(43, 20)
        Me.btnAll.TabIndex = 3
        Me.btnAll.Text = "全选"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'frmPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 299)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnMid)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmPos"
        Me.Text = "对位表"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnMid As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
End Class
