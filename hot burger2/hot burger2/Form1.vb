Public Class ال

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "بيرقر جامبو " Then
            TextBox1.Text = 1000
        ElseIf ComboBox1.Text = "بيرقر عادي" Then
            TextBox1.Text = 2000
        ElseIf ComboBox1.Text = "شاورما عادي" Then
            TextBox1.Text = 1000
        ElseIf ComboBox1.Text = "شاورما جامبو" Then
            TextBox1.Text = 1000
        Else : MsgBox("تاكد من الصنف المدخل")
            ComboBox1.Text = ""

        End If
    End Sub
End Class
