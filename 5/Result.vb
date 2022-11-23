Public Class Result
    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Label11.Text = 3 Then
            Label4.Hide()
            Label9.Hide()
            LabelR4.Hide()
            Label5.Hide()
            Label10.Hide()
            LabelR5.Hide()
        ElseIf Label11.Text = 4 Then
            Label5.Hide()
            Label10.Hide()
            LabelR5.Hide()
        End If
    End Sub
End Class