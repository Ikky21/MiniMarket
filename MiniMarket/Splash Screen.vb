Public Class SplashScreen
    Dim progress As Integer = 0
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' menghitung progres terbaru
        Dim newprogess = Progress + 1

        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            Label2.Text = "Isntalation Syistem"
        ElseIf ProgressBar1.Value <= 50 Then
            Label2.Text = "Connaction To Database"
        ElseIf ProgressBar1.Value <= 100 Then
            Label2.Text = "Please Wait For Configuration"
        End If
        ' mengupdate global variabel aga tidak stuck di angka 0
        Progress = newprogess

        ' untuk menghentikan timer ketika angka sudah 100
        If (Progress = 100) Then
            Timer1.Stop()
            Me.Hide()
            MainForm.Show()
        End If

        ' set progresbar value menggunakan nilai newprogres
        ProgressBar1.Value = newprogess

        LblLoading.Text = "Loading... " & newprogess & "%"

    End Sub
End Class
