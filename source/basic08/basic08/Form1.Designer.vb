<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelOutDice = New System.Windows.Forms.Label()
        Me.LabelOutJudge = New System.Windows.Forms.Label()
        Me.LabelOutPredict = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("IBM Plex Sans JP", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(306, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 68)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "RUN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("IBM Plex Sans JP", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "トランプ："
        '
        'LabelOutDice
        '
        Me.LabelOutDice.AutoSize = True
        Me.LabelOutDice.Font = New System.Drawing.Font("IBM Plex Sans JP", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOutDice.Location = New System.Drawing.Point(392, 142)
        Me.LabelOutDice.Name = "LabelOutDice"
        Me.LabelOutDice.Size = New System.Drawing.Size(175, 32)
        Me.LabelOutDice.TabIndex = 2
        Me.LabelOutDice.Text = "[引かれたカード]"
        '
        'LabelOutJudge
        '
        Me.LabelOutJudge.AutoSize = True
        Me.LabelOutJudge.Font = New System.Drawing.Font("IBM Plex Sans JP", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOutJudge.Location = New System.Drawing.Point(392, 225)
        Me.LabelOutJudge.Name = "LabelOutJudge"
        Me.LabelOutJudge.Size = New System.Drawing.Size(70, 32)
        Me.LabelOutJudge.TabIndex = 3
        Me.LabelOutJudge.Text = "[判定]"
        '
        'LabelOutPredict
        '
        Me.LabelOutPredict.AutoSize = True
        Me.LabelOutPredict.Font = New System.Drawing.Font("IBM Plex Sans JP", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOutPredict.Location = New System.Drawing.Point(392, 183)
        Me.LabelOutPredict.Name = "LabelOutPredict"
        Me.LabelOutPredict.Size = New System.Drawing.Size(154, 32)
        Me.LabelOutPredict.TabIndex = 4
        Me.LabelOutPredict.Text = "[あなたの予想]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("IBM Plex Sans JP", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "あなたの予想："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("IBM Plex Sans JP", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "判定："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelOutPredict)
        Me.Controls.Add(Me.LabelOutJudge)
        Me.Controls.Add(Me.LabelOutDice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelOutDice As Label
    Friend WithEvents LabelOutJudge As Label
    Friend WithEvents LabelOutPredict As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
