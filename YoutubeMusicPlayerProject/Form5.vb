﻿Public Class Form5
    Private Sub Form5_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim VideoURL As String = Form1.TextBox1.Text
        Form1.Close()
        WebBrowser1.DocumentText = "<iframe width=""590"" height=""360"" src=""https://www.youtube.com/embed/" & VideoURL & """ frameborder=""0"" allowfullscreen></iframe>"
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        End
    End Sub

End Class