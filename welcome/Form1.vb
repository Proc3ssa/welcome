Public Class form1
    Private Sub first_Load(sender As Object, e As EventArgs)


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datee.Text = Date.Now.ToString("dd-mm-yyyy")
        timee.Text = Date.Now.ToString("hh:mm:ss")

    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
