
Public Class frmMain

    Private Sub ThôngTinKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinKháchHàngToolStripMenuItem.Click
        frmThongTinKhachHang.Show()
    End Sub

    Private Sub XemKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemKháchHàngToolStripMenuItem.Click
        frmKH.Show()
    End Sub

    Private Sub CậpNhậtSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtSảnPhẩmToolStripMenuItem.Click
        frmCapNhatSanPham.Show()
    End Sub

    Private Sub XemSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemSảnPhẩmToolStripMenuItem.Click
        frmXemSanPham.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class