Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input, cal
        input = Val(TextBoxInput401.Text)
        cal = input * 60
        TextBoxOutput401.Text = cal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim input, cal
        input = Val(TextBoxInput402.Text)
        cal = input / 60
        TextBoxOutput402.Text = cal
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pencil, eraser, notebook, pay, taxRatio, pencilCount, eraserCount, notebookCount, taxIncluded
        pencil = 20
        eraser = 50
        notebook = 100
        pay = 1000
        taxRatio = 1.1
        pencilCount = Val(TextBoxInput403Pencil.Text)
        eraserCount = Val(TextBoxInput403Eraser.Text)
        notebookCount = Val(TextBoxInput403Notebook.Text)
        TextBoxOutput403Pencil.Text = pencilCount * pencil * taxRatio
        TextBoxOutput403Eraser.Text = eraserCount * eraser * taxRatio
        TextBoxOutput403Notebook.Text = notebookCount * notebook * taxRatio
        taxIncluded = (pencilCount * pencil + eraserCount * eraser + notebookCount * notebook) * taxRatio
        TextBoxOutput403Sum.Text = taxIncluded
        TextBoxOutput403Change.Text = pay - taxIncluded
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pencil, eraser, notebook, pay, taxRatio, pencilCount, eraserCount, notebookCount, taxIncluded
        pencil = 20
        eraser = 50
        notebook = 100
        pay = Val(TextBoxInput404Pay.Text)
        taxRatio = 1.1
        pencilCount = Val(TextBoxInput404Pencil.Text)
        eraserCount = Val(TextBoxInput404Eraser.Text)
        notebookCount = Val(TextBoxInput404Notebook.Text)
        TextBoxOutput404Pencil.Text = pencilCount * pencil * taxRatio
        TextBoxOutput404Eraser.Text = eraserCount * eraser * taxRatio
        TextBoxOutput404Notebook.Text = notebookCount * notebook * taxRatio
        taxIncluded = (pencilCount * pencil + eraserCount * eraser + notebookCount * notebook) * taxRatio
        TextBoxOutput404Sum.Text = taxIncluded
        TextBoxOutput404Change.Text = pay - taxIncluded
    End Sub
End Class
