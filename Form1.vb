﻿Public Class Form1
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Text = "Sample headeer"
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      MsgBox("Text show message box")
   End Sub
End Class
