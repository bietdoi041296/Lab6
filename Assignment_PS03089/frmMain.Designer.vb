<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CậpNhậtSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KháchHàngToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'KháchHàngToolStripMenuItem
        '
        resources.ApplyResources(Me.KháchHàngToolStripMenuItem, "KháchHàngToolStripMenuItem")
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinKháchHàngToolStripMenuItem, Me.XemKháchHàngToolStripMenuItem})
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        '
        'ThôngTinKháchHàngToolStripMenuItem
        '
        resources.ApplyResources(Me.ThôngTinKháchHàngToolStripMenuItem, "ThôngTinKháchHàngToolStripMenuItem")
        Me.ThôngTinKháchHàngToolStripMenuItem.Name = "ThôngTinKháchHàngToolStripMenuItem"
        '
        'XemKháchHàngToolStripMenuItem
        '
        resources.ApplyResources(Me.XemKháchHàngToolStripMenuItem, "XemKháchHàngToolStripMenuItem")
        Me.XemKháchHàngToolStripMenuItem.Name = "XemKháchHàngToolStripMenuItem"
        '
        'SảnPhẩmToolStripMenuItem
        '
        resources.ApplyResources(Me.SảnPhẩmToolStripMenuItem, "SảnPhẩmToolStripMenuItem")
        Me.SảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CậpNhậtSảnPhẩmToolStripMenuItem, Me.XemSảnPhẩmToolStripMenuItem})
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        '
        'CậpNhậtSảnPhẩmToolStripMenuItem
        '
        resources.ApplyResources(Me.CậpNhậtSảnPhẩmToolStripMenuItem, "CậpNhậtSảnPhẩmToolStripMenuItem")
        Me.CậpNhậtSảnPhẩmToolStripMenuItem.Name = "CậpNhậtSảnPhẩmToolStripMenuItem"
        '
        'XemSảnPhẩmToolStripMenuItem
        '
        resources.ApplyResources(Me.XemSảnPhẩmToolStripMenuItem, "XemSảnPhẩmToolStripMenuItem")
        Me.XemSảnPhẩmToolStripMenuItem.Name = "XemSảnPhẩmToolStripMenuItem"
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CậpNhậtSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
