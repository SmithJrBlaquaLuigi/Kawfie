Imports Discord

Public Class Form1
    Dim WithEvents Discord As New DiscordClient


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Discord.Connect("MzUxMTMyODcwMjU5MTEzOTg0.DIT1-g.qqIEft3YKe1H_vnXw3Np_q4UfBU", TokenType.Bot)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Class DiscordClient
        Friend Sub Connect(v As String, bot As TokenType)
            
        End Sub
    End Class
End Class
