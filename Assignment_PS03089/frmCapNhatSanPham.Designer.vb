<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapNhatSanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCapNhatSanPham))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dgvSanpham = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.txtSoluong)
        Me.GroupBox1.Controls.Add(Me.txtTenLoai)
        Me.GroupBox1.Controls.Add(Me.txtMaLoai)
        Me.GroupBox1.Controls.Add(Me.txtTenSP)
        Me.GroupBox1.Controls.Add(Me.txtMaSP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'txtSoluong
        '
        resources.ApplyResources(Me.txtSoluong, "txtSoluong")
        Me.txtSoluong.Name = "txtSoluong"
        '
        'txtTenLoai
        '
        resources.ApplyResources(Me.txtTenLoai, "txtTenLoai")
        Me.txtTenLoai.Name = "txtTenLoai"
        '
        'txtMaLoai
        '
        resources.ApplyResources(Me.txtMaLoai, "txtMaLoai")
        Me.txtMaLoai.Name = "txtMaLoai"
        '
        'txtTenSP
        '
        resources.ApplyResources(Me.txtTenSP, "txtTenSP")
        Me.txtTenSP.Name = "txtTenSP"
        '
        'txtMaSP
        '
        resources.ApplyResources(Me.txtMaSP, "txtMaSP")
        Me.txtMaSP.Name = "txtMaSP"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnTimKiem
        '
        resources.ApplyResources(Me.btnTimKiem, "btnTimKiem")
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        resources.ApplyResources(Me.btnThem, "btnThem")
        Me.btnThem.Name = "btnThem"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        resources.ApplyResources(Me.btnSua, "btnSua")
        Me.btnSua.Name = "btnSua"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        resources.ApplyResources(Me.btnXoa, "btnXoa")
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'dgvSanpham
        '
        resources.ApplyResources(Me.dgvSanpham, "dgvSanpham")
        Me.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanpham.Name = "dgvSanpham"
        '
        'frmCapNhatSanPham
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvSanpham)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCapNhatSanPham"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtTenLoai As System.Windows.Forms.TextBox
    Friend WithEvents txtMaLoai As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents dgvSanpham As System.Windows.Forms.DataGridView
End Class
