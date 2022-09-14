Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b
        a = 10
        b = a * 3
        TextBox1.Text = b
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b
        a = 10
        b = 20
        a = a + b
        b = a + b
        TextBox4.Text = a
        TextBox5.Text = b
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c
        a = 10
        b = 20
        c = a * 2 + b * 3
        TextBox2.Text = c
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a
        a = 10
        a = a + 20
        TextBox3.Text = a
    End Sub
End Class
