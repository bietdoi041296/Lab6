Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmKH
        Dim db As New DataTable
        Dim chuoiketnoi As String = "workstation id=Assignment.mssql.somee.com;packet size=4096;user id=bietdoi041296_SQLLogin_1;pwd=6cn4ehd7vc;data source=Assignment.mssql.somee.com;persist security info=False;initial catalog=Assignment"
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG where MAKH='" & txtMaKH.Text & "'", connect)
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                DataGridView1.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    DataGridView1.DataSource = db.DefaultView
                    txtMAKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMAKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnXemTatCa_Click(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        Dim hienthi As New Class1
        DataGridView1.DataSource = hienthi.Loadkhachang.Tables(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class