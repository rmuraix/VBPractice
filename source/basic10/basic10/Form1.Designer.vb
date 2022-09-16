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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelJpExaminees = New System.Windows.Forms.Label()
        Me.LabelEnExaminees = New System.Windows.Forms.Label()
        Me.TextBoxJpSum = New System.Windows.Forms.TextBox()
        Me.TextBoxJpAve = New System.Windows.Forms.TextBox()
        Me.TextBoxEnAve = New System.Windows.Forms.TextBox()
        Me.TextBoxEnSum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("IBM Plex Sans JP", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(337, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "RUN 11-3"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "合計値："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "平均値："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "受験者数："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "受験者数："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(423, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "平均値："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(423, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "合計値："
        '
        'LabelJpExaminees
        '
        Me.LabelJpExaminees.AutoSize = True
        Me.LabelJpExaminees.Location = New System.Drawing.Point(302, 179)
        Me.LabelJpExaminees.Name = "LabelJpExaminees"
        Me.LabelJpExaminees.Size = New System.Drawing.Size(61, 12)
        Me.LabelJpExaminees.TabIndex = 8
        Me.LabelJpExaminees.Text = "[受験者数]"
        '
        'LabelEnExaminees
        '
        Me.LabelEnExaminees.AutoSize = True
        Me.LabelEnExaminees.Location = New System.Drawing.Point(476, 179)
        Me.LabelEnExaminees.Name = "LabelEnExaminees"
        Me.LabelEnExaminees.Size = New System.Drawing.Size(61, 12)
        Me.LabelEnExaminees.TabIndex = 11
        Me.LabelEnExaminees.Text = "[受験者数]"
        '
        'TextBoxJpSum
        '
        Me.TextBoxJpSum.Location = New System.Drawing.Point(302, 199)
        Me.TextBoxJpSum.Name = "TextBoxJpSum"
        Me.TextBoxJpSum.Size = New System.Drawing.Size(59, 19)
        Me.TextBoxJpSum.TabIndex = 12
        '
        'TextBoxJpAve
        '
        Me.TextBoxJpAve.Location = New System.Drawing.Point(302, 222)
        Me.TextBoxJpAve.Name = "TextBoxJpAve"
        Me.TextBoxJpAve.Size = New System.Drawing.Size(59, 19)
        Me.TextBoxJpAve.TabIndex = 13
        '
        'TextBoxEnAve
        '
        Me.TextBoxEnAve.Location = New System.Drawing.Point(476, 222)
        Me.TextBoxEnAve.Name = "TextBoxEnAve"
        Me.TextBoxEnAve.Size = New System.Drawing.Size(59, 19)
        Me.TextBoxEnAve.TabIndex = 15
        '
        'TextBoxEnSum
        '
        Me.TextBoxEnSum.Location = New System.Drawing.Point(476, 199)
        Me.TextBoxEnSum.Name = "TextBoxEnSum"
        Me.TextBoxEnSum.Size = New System.Drawing.Size(59, 19)
        Me.TextBoxEnSum.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "国語"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(459, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "英語"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxEnAve)
        Me.Controls.Add(Me.TextBoxEnSum)
        Me.Controls.Add(Me.TextBoxJpAve)
        Me.Controls.Add(Me.TextBoxJpSum)
        Me.Controls.Add(Me.LabelEnExaminees)
        Me.Controls.Add(Me.LabelJpExaminees)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelJpExaminees As Label
    Friend WithEvents LabelEnExaminees As Label
    Friend WithEvents TextBoxJpSum As TextBox
    Friend WithEvents TextBoxJpAve As TextBox
    Friend WithEvents TextBoxEnAve As TextBox
    Friend WithEvents TextBoxEnSum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
