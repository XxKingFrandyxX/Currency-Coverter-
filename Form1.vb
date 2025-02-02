Public Class Form1
    Private Sub BTNstart_Click(sender As Object, e As EventArgs) Handles BTNstart.Click
        Dim value As Integer
        value = TXTmoney.Text

        If RBone.Checked = True Then
            value = value * 0.78
        Else
            value = value * 1
        End If
        If RBtwo.Checked = True Then
            value = value * 0.5
        Else
            value = value * 1
        End If
        If RBthree.Checked = True Then
            value = value * 0.6
        Else
            value = value * 1
        End If

        LBLoutput.Text = value

    End Sub

    Private Sub BTNquit_Click(sender As Object, e As EventArgs) Handles BTNquit.Click
        Application.Exit()
    End Sub
End Class
