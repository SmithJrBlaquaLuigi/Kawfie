Imports Discord
Public Class Form1

    Dim WithEvents Discord As New DiscordClient

    Dim trigger As String = "!"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Discord.Connect("MzUxMTMyODcwMjU5MTEzOTg0.DIT1-g.qqIEft3YKe1H_vnXw3Np_q4UfBU", TokenType.Bot)

        Catch ex As Exception

            MessageBox.Show(ex.Message)


        End Try

    End Sub
    Private Sub OnMsg(sender As Object, message As Discord.MessageEventArgs) Handles Discord.MessageReceived

        If message.User.Name = "Nikibot" Then


            'ignore the message

        Else

            Dim msg As String = message.Message.RawText

            If msg.StartsWith(trigger) Then

                If msg.Contains(" ") Then

                    Dim cmd As String = msg.Split(trigger)(1).Split(" ")(0)
                    Dim arg As String = msg.Split(" ")(1)

                    Select Case cmd.ToLower

                        Case "test"
                            message.Channel.SendMessage("Your argument is: " + arg)

                        Case Else
                            message.Channel.SendMessage("Sorry, you've entered the incorrect command. Please try again later.")

                    End Select

                Else

                    Dim cmd As String = msg.Split(trigger)(1)

                    Select Case cmd.ToLower

                        Case "help"
                            message.Channel.SendMessage("commands:" + vbNewLine + "test - shows a test argument")

                        Case Else
                            message.Channel.SendMessage("Sorry, you have entered the incorrect command. Please try again.")

                    End Select

                End If

            Else

                'ignore the message

            End If

        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Discord.Disconnect()
    End Sub
End Class
