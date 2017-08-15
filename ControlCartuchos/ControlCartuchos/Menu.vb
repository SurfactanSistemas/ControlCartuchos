Public Class Menu

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        With AdministracionStock

            .ShowDialog()

            .Dispose()
        End With
    End Sub
End Class