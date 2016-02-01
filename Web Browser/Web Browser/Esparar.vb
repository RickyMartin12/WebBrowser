Public Class Esparar
    Public Cont As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Cont < 100 Then
            ProgressBar1.Value = Cont
            Cont = Cont + 1
            Label3.Text = Cont & " % Concluido"
        Else
            Form1.StartPosition = FormStartPosition.CenterScreen
            Form1.Visible = True
            Me.Visible = False
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Esparar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = 100
        Timer1.Enabled = True
        Timer1.Interval = 150
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class