Public Class Loading

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = 100 Then
            Me.Hide()
            ' Dim log = New login
            Login.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class
