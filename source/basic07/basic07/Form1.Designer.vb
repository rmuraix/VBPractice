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
        Me.TextBox1InYear = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1OutJudge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2InGender = New System.Windows.Forms.TextBox()
        Me.TextBox2InYear = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2OutJudge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1InYear
        '
        Me.TextBox1InYear.Location = New System.Drawing.Point(47, 46)
        Me.TextBox1InYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1InYear.Name = "TextBox1InYear"
        Me.TextBox1InYear.Size = New System.Drawing.Size(116, 23)
        Me.TextBox1InYear.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 130)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "RUN8-1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1OutJudge
        '
        Me.TextBox1OutJudge.Location = New System.Drawing.Point(47, 99)
        Me.TextBox1OutJudge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1OutJudge.Name = "TextBox1OutJudge"
        Me.TextBox1OutJudge.Size = New System.Drawing.Size(116, 23)
        Me.TextBox1OutJudge.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "生まれた年を入力"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(212, 130)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 29)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "RUN8-2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2InGender
        '
        Me.TextBox2InGender.Location = New System.Drawing.Point(212, 45)
        Me.TextBox2InGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2InGender.Name = "TextBox2InGender"
        Me.TextBox2InGender.Size = New System.Drawing.Size(116, 23)
        Me.TextBox2InGender.TabIndex = 5
        '
        'TextBox2InYear
        '
        Me.TextBox2InYear.Location = New System.Drawing.Point(212, 99)
        Me.TextBox2InYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2InYear.Name = "TextBox2InYear"
        Me.TextBox2InYear.Size = New System.Drawing.Size(116, 23)
        Me.TextBox2InYear.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "生まれた年を入力"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "男性：0 女性：1"
        '
        'TextBox2OutJudge
        '
        Me.TextBox2OutJudge.Location = New System.Drawing.Point(337, 98)
        Me.TextBox2OutJudge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2OutJudge.Name = "TextBox2OutJudge"
        Me.TextBox2OutJudge.Size = New System.Drawing.Size(116, 23)
        Me.TextBox2OutJudge.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 562)
        Me.Controls.Add(Me.TextBox2OutJudge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2InYear)
        Me.Controls.Add(Me.TextBox2InGender)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1OutJudge)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1InYear)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1InYear As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1OutJudge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2InGender As TextBox
    Friend WithEvents TextBox2InYear As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2OutJudge As TextBox
End Class
