Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim birthYear, age

        birthYear = Val(TextBox1InYear.Text)
        age = DateTime.Now.Year - birthYear
        TextBox1OutAge.Text = age & "歳"

        If age < 15 Then
            TextBox1OutJugde.Text = "子供"
        ElseIf age < 26 Then
            TextBox1OutJugde.Text = "青年"
        ElseIf age < 50 Then
            TextBox1OutJugde.Text = "大人"
        ElseIf age < 70 Then
            TextBox1OutJugde.Text = "中年"
        Else
            TextBox1OutJugde.Text = "老人"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dice1, dice2, diceSum
        Randomize()
        dice1 = Int(Rnd() * 6 + 1)
        dice2 = Int(Rnd() * 6 + 1)
        diceSum = dice1 + dice2

        TextBox2OutDice1.Text = dice1
        TextBox2OutDice2.Text = dice2
        TextBox2OutDiceSum.Text = diceSum

        If diceSum <= 6 Then
            TextBox2OutJudge1.Text = "小"
        Else
            TextBox2OutJudge1.Text = "大"
        End If

        If diceSum Mod 2 = 0 Then
            TextBox2OutJudge2.Text = "偶数"
        Else
            TextBox2OutJudge2.Text = "奇数"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bmi
        bmi = Val(TextBox3InWeight.Text) / (Val(TextBox3InHeight.Text) ^ 2)
        TextBox3OutBmi.Text = bmi
        If bmi < 18.5 Then
            TextBox3OutJudge.Text = "痩せ気味"
        ElseIf bmi < 25.0 Then
            TextBox3OutJudge.Text = "問題なし"
        Else
            TextBox3OutJudge.Text = "太り気味"
        End If
    End Sub
End Class
