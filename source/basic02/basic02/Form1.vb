Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 3-1
        Dim pencil, eraser, sum_goods, tax, pay
        pencil = 50
        eraser = 100
        sum_goods = pencil * 2 + eraser
        tax = sum_goods * 0.1
        pay = sum_goods + tax
        TextBox1.Text = sum_goods
        TextBox2.Text = tax
        TextBox3.Text = pay

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 3-2
        Dim a, b, c, rose, carnation, goods_set, founding, buy
        a = 500
        b = 1000
        c = 1500
        rose = 300
        carnation = 200
        founding = a + b + c
        goods_set = (rose + carnation) * 1.1
        buy = founding / goods_set
        TextBox4.Text = buy
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '3-3
        Dim height, ideal_body_weight
        height = 170
        ideal_body_weight = 0.9 * (height - 100)
        TextBox5.Text = ideal_body_weight
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' 3-4
        Dim height, weight, ideal_body_weight, weight_difference
        height = Val(TextBox6.Text)
        weight = Val(TextBox7.Text)
        ideal_body_weight = 0.9 * (height - 100)
        weight_difference = ideal_body_weight - weight
        TextBox8.Text = ideal_body_weight
        TextBox9.Text = weight_difference

    End Sub
End Class
