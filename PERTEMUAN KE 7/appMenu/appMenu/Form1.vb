Public Class Form1
    Private Sub Form2ToolsStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Dim F2 As New Form2
        F2.ShowDialog()
    End Sub
    Private Sub Form3ToolsStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem2.Click
        Dim F3 As New Form3
        F3.ShowDialog()
    End Sub
    Private Sub ExitToolsStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
