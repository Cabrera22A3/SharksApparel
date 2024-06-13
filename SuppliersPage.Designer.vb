<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuppliersPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuppliersPage))
        Suppliers1 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Suppliers1
        ' 
        Suppliers1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Suppliers1.BackColor = SystemColors.ButtonHighlight
        Suppliers1.BackgroundImage = CType(resources.GetObject("Suppliers1.BackgroundImage"), Image)
        Suppliers1.BackgroundImageLayout = ImageLayout.Zoom
        Suppliers1.Cursor = Cursors.Hand
        Suppliers1.Location = New Point(12, 37)
        Suppliers1.Name = "Suppliers1"
        Suppliers1.Size = New Size(187, 187)
        Suppliers1.TabIndex = 7
        Suppliers1.Text = "Supplier"
        Suppliers1.TextAlign = ContentAlignment.BottomCenter
        Suppliers1.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DeepSkyBlue
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Top
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Verdana", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(819, 31)
        Button1.TabIndex = 15
        Button1.Text = "Add New"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.BackColor = SystemColors.ButtonHighlight
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.Cursor = Cursors.Hand
        Button2.Location = New Point(205, 37)
        Button2.Name = "Button2"
        Button2.Size = New Size(187, 187)
        Button2.TabIndex = 16
        Button2.Text = "Supplier"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button3.BackColor = SystemColors.ButtonHighlight
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Cursor = Cursors.Hand
        Button3.Location = New Point(398, 37)
        Button3.Name = "Button3"
        Button3.Size = New Size(187, 187)
        Button3.TabIndex = 17
        Button3.Text = "Supplier"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button4.BackColor = SystemColors.ButtonHighlight
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Cursor = Cursors.Hand
        Button4.Location = New Point(591, 37)
        Button4.Name = "Button4"
        Button4.Size = New Size(187, 187)
        Button4.TabIndex = 18
        Button4.Text = "Supplier"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.UseVisualStyleBackColor = False
        ' 
        ' SuppliersPage
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.LightCyan
        ClientSize = New Size(819, 539)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Suppliers1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SuppliersPage"
        Text = "SuppliersPage"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Suppliers1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button


End Class
