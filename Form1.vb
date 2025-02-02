Public Class Form1
    Private Sub BTNstart_Click(sender As Object, e As EventArgs) Handles BTNstart.Click
        Dim value As Integer
        value = TXTmoney.Text

        If RBone.Enabled = True Then
            value = value * 0.78
        Else
            value = value * 1
        End If
        If RBtwo.Enabled = True Then
            value = value * 0.5
        Else
            value = value * 1
        End If
        If RBthree.Enabled = True Then
            value = value * 0.6
        Else
            value = value * 1
        End If

        LBLoutput.Text = value

    End Sub
End Class
