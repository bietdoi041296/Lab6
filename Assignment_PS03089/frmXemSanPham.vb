Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmXemSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=Assignment.mssql.somee.com;packet size=4096;user id=bietdoi041296_SQLLogin_1;pwd=6cn4ehd7vc;data source=Assignment.mssql.somee.com;persist security info=False;initial catalog=Assignment"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP where SANPHAM.MASP ='" & txtMASP.Text & "' ", connect)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMASP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnXemTatCa_Click(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        Dim hienthi As New Class1
        dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub
End Class