Public Class Form1

    Dim a As Integer

    Private Sub Button_1_Click(sender As Object, e As EventArgs) Handles button_1.Click
        a = a + 1
        label_4.Text = a Mod 10
        label_3.Text = (a Mod 100) \ 10
        label_2.Text = (a Mod 1000) \ 100
        label_1.Text = (a Mod 10000) \ 1000

        If a = 9999 Then
            MessageBox.Show("9999に達しました。リセットします。")
            label_1.Text = 0
            label_2.Text = 0
            label_3.Text = 0
            label_4.Text = 0
            a = 0
        End If
    End Sub

    Private Sub Button_2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        label_1.Text = 0
        label_2.Text = 0
        label_3.Text = 0
        label_4.Text = 0
        a = 0
    End Sub

End Class
