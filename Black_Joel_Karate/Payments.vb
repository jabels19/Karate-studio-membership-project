Public Class Payments

    Private Sub Payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.KarateDataSet.Payments)

    End Sub

    Private Sub btnClose2_Click(sender As Object, e As EventArgs) Handles btnClose2.Click
        Me.Close()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Dim i As Integer

        With DataGridView1

            txtId.Text = .Rows(i).Cells("id").Value.ToString

        End With

    End Sub
End Class