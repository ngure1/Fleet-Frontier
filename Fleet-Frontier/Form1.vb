Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub minimizeButton_Click(sender As Object, e As EventArgs) Handles minimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class
