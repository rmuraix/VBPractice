<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3OutBmi = New System.Windows.Forms.TextBox()
        Me.TextBox3OutJudge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4OutJudge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4InStartH = New System.Windows.Forms.TextBox()
        Me.TextBox4InStartM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4InArrivalM = New System.Windows.Forms.TextBox()
        Me.TextBox4InArrivalH = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4OutTimeM = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "RUN6-3"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3OutBmi
        '
        Me.TextBox3OutBmi.Location = New System.Drawing.Point(118, 187)
        Me.TextBox3OutBmi.Name = "TextBox3OutBmi"
        Me.TextBox3OutBmi.Size = New System.Drawing.Size(142, 19)
        Me.TextBox3OutBmi.TabIndex = 2
        '
        'TextBox3OutJudge
        '
        Me.TextBox3OutJudge.Location = New System.Drawing.Point(120, 238)
        Me.TextBox3OutJudge.Name = "TextBox3OutJudge"
        Me.TextBox3OutJudge.Size = New System.Drawing.Size(142, 19)
        Me.TextBox3OutJudge.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "BMI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "判定"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(490, 286)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 53)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "RUN6-4"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "判定"
        '
        'TextBox4OutJudge
        '
        Me.TextBox4OutJudge.Location = New System.Drawing.Point(490, 238)
        Me.TextBox4OutJudge.Name = "TextBox4OutJudge"
        Me.TextBox4OutJudge.Size = New System.Drawing.Size(142, 19)
        Me.TextBox4OutJudge.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(488, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "出発"
        '
        'TextBox4InStartH
        '
        Me.TextBox4InStartH.Location = New System.Drawing.Point(490, 74)
        Me.TextBox4InStartH.Name = "TextBox4InStartH"
        Me.TextBox4InStartH.Size = New System.Drawing.Size(100, 19)
        Me.TextBox4InStartH.TabIndex = 10
        '
        'TextBox4InStartM
        '
        Me.TextBox4InStartM.Location = New System.Drawing.Point(597, 73)
        Me.TextBox4InStartM.Name = "TextBox4InStartM"
        Me.TextBox4InStartM.Size = New System.Drawing.Size(100, 19)
        Me.TextBox4InStartM.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(573, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "時"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(680, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "分"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(680, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "分"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(573, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 12)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "時"
        '
        'TextBox4InArrivalM
        '
        Me.TextBox4InArrivalM.Location = New System.Drawing.Point(597, 135)
        Me.TextBox4InArrivalM.Name = "TextBox4InArrivalM"
        Me.TextBox4InArrivalM.Size = New System.Drawing.Size(100, 19)
        Me.TextBox4InArrivalM.TabIndex = 16
        '
        'TextBox4InArrivalH
        '
        Me.TextBox4InArrivalH.Location = New System.Drawing.Point(490, 136)
        Me.TextBox4InArrivalH.Name = "TextBox4InArrivalH"
        Me.TextBox4InArrivalH.Size = New System.Drawing.Size(100, 19)
        Me.TextBox4InArrivalH.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(488, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "到着"
        '
        'TextBox4OutTimeM
        '
        Me.TextBox4OutTimeM.Location = New System.Drawing.Point(490, 202)
        Me.TextBox4OutTimeM.Name = "TextBox4OutTimeM"
        Me.TextBox4OutTimeM.Size = New System.Drawing.Size(142, 19)
        Me.TextBox4OutTimeM.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(488, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 12)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "通学時間（分）"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox4OutTimeM)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox4InArrivalM)
        Me.Controls.Add(Me.TextBox4InArrivalH)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4InStartM)
        Me.Controls.Add(Me.TextBox4InStartH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4OutJudge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3OutJudge)
        Me.Controls.Add(Me.TextBox3OutBmi)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3OutBmi As TextBox
    Friend WithEvents TextBox3OutJudge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4OutJudge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4InStartH As TextBox
    Friend WithEvents TextBox4InStartM As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4InArrivalM As TextBox
    Friend WithEvents TextBox4InArrivalH As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4OutTimeM As TextBox
    Friend WithEvents Label10 As Label
End Class
