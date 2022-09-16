Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim birth
        birth = Val(TextBox1InYear.Text)
        If birth <= 1988 Then
            TextBox1OutJudge.Text = "昭和以下"
        ElseIf birth <= 2018 Then
            TextBox1OutJudge.Text = "平成"
        Else
            TextBox1OutJudge.Text = "令和"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim gender, age, judge
        gender = Val(TextBox2InGender.Text)
        age = DateTime.Now.Year - Val(TextBox2InYear.Text)
        If gender = 0 Then
            If age <= 17 Then
                judge = "不可能"
            Else
                judge = "可能"
            End If
        ElseIf gender = 1 Then
            If age <= 15 Then
                judge = "不可能"
            Else
                judge = "可能"
            End If
        Else
            judge = "無効な値です"
        End If
        ' 以下性別に0 or 1以外が入力される場合エラーメッセージを返す
        If judge IsNot "無効な値です" Then
            TextBox2OutJudge.Text = "結婚" + judge
        Else
            TextBox2OutJudge.Text = judge
        End If
    End Sub
End Class
