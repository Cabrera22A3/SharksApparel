<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsPage))
        TableLayoutPanel2 = New TableLayoutPanel()
        Products2 = New Button()
        Products3 = New Button()
        Products4 = New Button()
        Products1 = New Button()
        Button1 = New Button()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.Controls.Add(Products2, 1, 0)
        TableLayoutPanel2.Controls.Add(Products3, 2, 0)
        TableLayoutPanel2.Controls.Add(Products4, 3, 0)
        TableLayoutPanel2.Controls.Add(Products1, 0, 0)
        TableLayoutPanel2.Location = New Point(3, 2)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(784, 170)
        TableLayoutPanel2.TabIndex = 13
        ' 
        ' Products2
        ' 
        Products2.BackColor = Color.Azure
        Products2.BackgroundImage = CType(resources.GetObject("Products2.BackgroundImage"), Image)
        Products2.BackgroundImageLayout = ImageLayout.Zoom
        Products2.Cursor = Cursors.Hand
        Products2.Location = New Point(199, 3)
        Products2.Name = "Products2"
        Products2.Size = New Size(187, 164)
        Products2.TabIndex = 4
        Products2.Text = "T-Shirt"
        Products2.TextAlign = ContentAlignment.BottomCenter
        Products2.UseVisualStyleBackColor = False
        ' 
        ' Products3
        ' 
        Products3.BackColor = Color.Azure
        Products3.BackgroundImage = CType(resources.GetObject("Products3.BackgroundImage"), Image)
        Products3.BackgroundImageLayout = ImageLayout.Zoom
        Products3.Cursor = Cursors.Hand
        Products3.Location = New Point(395, 3)
        Products3.Name = "Products3"
        Products3.Size = New Size(187, 164)
        Products3.TabIndex = 5
        Products3.Text = "T-Shirt"
        Products3.TextAlign = ContentAlignment.BottomCenter
        Products3.UseVisualStyleBackColor = False
        ' 
        ' Products4
        ' 
        Products4.BackColor = Color.Azure
        Products4.BackgroundImage = CType(resources.GetObject("Products4.BackgroundImage"), Image)
        Products4.BackgroundImageLayout = ImageLayout.Zoom
        Products4.Cursor = Cursors.Hand
        Products4.Location = New Point(591, 3)
        Products4.Name = "Products4"
        Products4.Size = New Size(190, 164)
        Products4.TabIndex = 6
        Products4.Text = "T-Shirt"
        Products4.TextAlign = ContentAlignment.BottomCenter
        Products4.UseVisualStyleBackColor = False
        ' 
        ' Products1
        ' 
        Products1.BackColor = Color.Azure
        Products1.BackgroundImage = CType(resources.GetObject("Products1.BackgroundImage"), Image)
        Products1.BackgroundImageLayout = ImageLayout.Zoom
        Products1.Cursor = Cursors.Hand
        Products1.Location = New Point(3, 3)
        Products1.Name = "Products1"
        Products1.Size = New Size(187, 164)
        Products1.TabIndex = 3
        Products1.Text = "T-Shirt"
        Products1.TextAlign = ContentAlignment.BottomCenter
        Products1.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.BackColor = Color.DeepSkyBlue
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(720, 496)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 31)
        Button1.TabIndex = 14
        Button1.Text = "Add New"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ProductsPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.LightCyan
        ClientSize = New Size(819, 539)
        Controls.Add(Button1)
        Controls.Add(TableLayoutPanel2)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "ProductsPage"
        ShowInTaskbar = False
        Text = "ProductsPage"
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Products2 As Button
    Friend WithEvents Products3 As Button
    Friend WithEvents Products4 As Button
    Friend WithEvents Products1 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Suppliers5 As Button
    Friend WithEvents Suppliers8 As Button
    Friend WithEvents Suppliers6 As Button
    Friend WithEvents Suppliers7 As Button
    Friend WithEvents Button1 As Button
End Class
