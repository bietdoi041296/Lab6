<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXemSanPham))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.btnXemTatCa = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.dgvXemsp = New System.Windows.Forms.DataGridView()
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtMaSP
        '
        resources.ApplyResources(Me.txtMaSP, "txtMaSP")
        Me.txtMaSP.Name = "txtMaSP"
        '
        'btnXem
        '
        resources.ApplyResources(Me.btnXem, "btnXem")
        Me.btnXem.Name = "btnXem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'btnXemTatCa
        '
        resources.ApplyResources(Me.btnXemTatCa, "btnXemTatCa")
        Me.btnXemTatCa.Name = "btnXemTatCa"
        Me.btnXemTatCa.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        resources.ApplyResources(Me.btnDong, "btnDong")
        Me.btnDong.Name = "btnDong"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'dgvXemsp
        '
        resources.ApplyResources(Me.dgvXemsp, "dgvXemsp")
        Me.dgvXemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemsp.Name = "dgvXemsp"
        '
        'frmXemSanPham
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvXemsp)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXemTatCa)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmXemSanPham"
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents btnXemTatCa As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents dgvXemsp As System.Windows.Forms.DataGridView
End Class
