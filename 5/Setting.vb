Public Class Setting
    Dim p As SByte
    Private Sub ButtonP3_Click(sender As Object, e As EventArgs) Handles ButtonP3.Click
        ButtonP3.Enabled = False
        ButtonP4.Enabled = True
        ButtonP5.Enabled = True
        p = 3
    End Sub

    Private Sub ButtonP4_Click(sender As Object, e As EventArgs) Handles ButtonP4.Click
        ButtonP3.Enabled = True
        ButtonP4.Enabled = False
        ButtonP5.Enabled = True
        p = 4
    End Sub

    Private Sub ButtonP5_Click(sender As Object, e As EventArgs) Handles ButtonP5.Click
        ButtonP3.Enabled = True
        ButtonP4.Enabled = True
        ButtonP5.Enabled = False
        p = 5
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Game()
        f.Label.Text = p
        f.Show()
        Close()
    End Sub

    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p = 4
    End Sub
End Class