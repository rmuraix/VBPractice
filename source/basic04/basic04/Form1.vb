Public Class Form1
    Private Sub Button5_1_Click(sender As Object, e As EventArgs) Handles Button5_1.Click
        Dim pointJp, pointMath, pointEn, sum
        pointJp = Val(TextBox501InJp.Text)
        pointMath = Val(TextBox501InMath.Text)
        pointEn = Val(TextBox501InEn.Text)
        sum = pointJp + pointMath + pointEn

        TextBox501OutSum.Text = sum
        TextBox501OutAve.Text = sum / 3
    End Sub

    Private Sub Button5_2_Click(sender As Object, e As EventArgs) Handles Button5_2.Click
        Dim userHeight, userWeight, standardWeight
        userHeight = Val(InputBox("メートルで身長を入力"))
        userWeight = Val(InputBox("Kgで体重を入力"))
        standardWeight = userHeight ^ 2 * 22

        TextBox502OutStanderd.Text = standardWeight
        TextBox502OutDiff.Text = standardWeight - userWeight
    End Sub

    Private Sub Button5_3_Click(sender As Object, e As EventArgs) Handles Button5_3.Click
        Dim workH, workM, payPerH, workMtoH, workHSum
        payPerH = Val(TextBox503InPerH.Text)
        workH = Val(TextBox503InH.Text)
        workM = Val(TextBox503InM.Text)
        workMtoH = workM / 60
        workHSum = workH + workMtoH
        TextBox503OutPayroll.Text = workHSum * payPerH
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, x
        a = Val(TextBox504InA.Text)
        b = Val(TextBox504InB.Text)
        c = Val(TextBox504InC.Text)

        x = a
        a = b
        b = c
        c = x

        TextBox504OutA.Text = a
        TextBox504OutB.Text = b
        TextBox504OutC.Text = c
    End Sub
End Class
