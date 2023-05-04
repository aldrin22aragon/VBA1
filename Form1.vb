Public Class Form1
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      ComboBox1.Items.Add("1")
      ComboBox1.SelectedIndex = 0
      Me.Text = "Sample headeer"
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      MsgBox("Text show message box")
   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      MsgBox(ComboBox1.SelectedItem.ToString)
   End Sub
End Class
