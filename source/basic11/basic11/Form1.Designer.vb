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
        Me.TextBox1A = New System.Windows.Forms.TextBox()
        Me.TextBox1B = New System.Windows.Forms.TextBox()
        Me.TextBox1Result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2User = New System.Windows.Forms.TextBox()
        Me.TextBox2Cp = New System.Windows.Forms.TextBox()
        Me.TextBox2Result = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "RUN12-2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1A
        '
        Me.TextBox1A.Location = New System.Drawing.Point(83, 140)
        Me.TextBox1A.Name = "TextBox1A"
        Me.TextBox1A.Size = New System.Drawing.Size(100, 19)
        Me.TextBox1A.TabIndex = 1
        '
        'TextBox1B
        '
        Me.TextBox1B.Location = New System.Drawing.Point(83, 189)
        Me.TextBox1B.Name = "TextBox1B"
        Me.TextBox1B.Size = New System.Drawing.Size(100, 19)
        Me.TextBox1B.TabIndex = 2
        '
        'TextBox1Result
        '
        Me.TextBox1Result.Location = New System.Drawing.Point(83, 240)
        Me.TextBox1Result.Name = "TextBox1Result"
        Me.TextBox1Result.Size = New System.Drawing.Size(100, 19)
        Me.TextBox1Result.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Result"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 282)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 43)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "RUN12-5"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2User
        '
        Me.TextBox2User.Location = New System.Drawing.Point(287, 139)
        Me.TextBox2User.Name = "TextBox2User"
        Me.TextBox2User.Size = New System.Drawing.Size(100, 19)
        Me.TextBox2User.TabIndex = 8
        '
        'TextBox2Cp
        '
        Me.TextBox2Cp.Location = New System.Drawing.Point(287, 188)
        Me.TextBox2Cp.Name = "TextBox2Cp"
        Me.TextBox2Cp.Size = New System.Drawing.Size(100, 19)
        Me.TextBox2Cp.TabIndex = 9
        '
        'TextBox2Result
        '
        Me.TextBox2Result.Location = New System.Drawing.Point(287, 239)
        Me.TextBox2Result.Name = "TextBox2Result"
        Me.TextBox2Result.Size = New System.Drawing.Size(100, 19)
        Me.TextBox2Result.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "USER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "CP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 12)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2Result)
        Me.Controls.Add(Me.TextBox2Cp)
        Me.Controls.Add(Me.TextBox2User)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1Result)
        Me.Controls.Add(Me.TextBox1B)
        Me.Controls.Add(Me.TextBox1A)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1A As TextBox
    Friend WithEvents TextBox1B As TextBox
    Friend WithEvents TextBox1Result As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2User As TextBox
    Friend WithEvents TextBox2Cp As TextBox
    Friend WithEvents TextBox2Result As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
