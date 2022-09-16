Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim flg, x, num_of_examinees_jp, point_jp, y, num_of_examinees_en, point_en
        ' それぞれ初期化
        flg = True ' ループ制御フラグ
        num_of_examinees_jp = 0
        point_jp = 0
        num_of_examinees_en = 0
        point_en = 0

        ' 日本語処理開始
        Do While flg = True
            x = Val(InputBox("国語の点数を入力してください。マイナスの値を入力すると終了します。"))

            If x < 0 Then
                flg = False
            Else
                point_jp += x
                num_of_examinees_jp += 1
            End If

        Loop
        LabelJpExaminees.Text = num_of_examinees_jp
        TextBoxJpSum.Text = point_jp
        TextBoxJpAve.Text = point_jp / num_of_examinees_jp

        ' 英語処理開始
        flg = True
        Do While flg = True
            y = Val(InputBox("英語の点数を入力してください。マイナスの値を入力すると終了します。"))

            If y < 0 Then
                flg = False
            Else
                point_en += y
                num_of_examinees_en += 1
            End If

        Loop
        LabelEnExaminees.Text = num_of_examinees_en
        TextBoxEnSum.Text = point_en
        TextBoxEnAve.Text = point_en / num_of_examinees_en
    End Sub
End Class
