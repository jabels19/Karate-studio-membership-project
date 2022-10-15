Imports System.Data.SqlClient


Public Class Form1
    Dim str1 As String

    Private Sub DtpKarate_ValueChanged(sender As Object, e As EventArgs) Handles DtpKarate.ValueChanged
        Dim dt As Date = DateValue(DtpKarate.Value)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)

    End Sub

    Private Sub MembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembersToolStripMenuItem.Click
        Members.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentsToolStripMenuItem.Click
        Payments.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageBox.Show("Karate database by Joel Black")
    End Sub

End Class
