Public Class Esparar

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(20)
        If ProgressBar1.Value = 300 Then
            Form1.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Esparar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Increment(20)
        If ProgressBar1.Value = 300 Then
            Form1.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class