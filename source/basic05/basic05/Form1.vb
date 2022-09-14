Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height, weight, bmi
        height = Val(InputBox("身長を入力（m）"))
        weight = Val(InputBox("体重を入力（kg）"))
        bmi = weight / (height ^ 2)

        TextBox3OutBmi.Text = bmi

        If bmi >= 18.5 And bmi <= 25.0 Then
            TextBox3OutJudge.Text = "問題なし"
        Else
            TextBox3OutJudge.Text = "気をつけよう"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim diffH, diffM, commuteM
        diffH = Val(TextBox4InArrivalH.Text) - Val(TextBox4InStartH.Text)
        diffM = Val(TextBox4InArrivalM.Text) - Val(TextBox4InStartM.Text)
        commuteM = (diffH * 60) + diffM
        TextBox4OutTimeM.Text = commuteM
        If commuteM >= 75 Then
            TextBox4OutJudge.Text = "長い"
        Else
            TextBox4OutJudge.Text = "普通"
        End If
    End Sub
End Class
