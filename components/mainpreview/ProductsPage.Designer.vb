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
        Products1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Panel1 = New Panel()
        Button1 = New Button()
        Button6 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Products1
        ' 
        Products1.BackColor = SystemColors.ButtonHighlight
        Products1.BackgroundImage = CType(resources.GetObject("Products1.BackgroundImage"), Image)
        Products1.BackgroundImageLayout = ImageLayout.Stretch
        Products1.Cursor = Cursors.Hand
        Products1.Location = New Point(12, 37)
        Products1.Name = "Products1"
        Products1.Size = New Size(187, 187)
        Products1.TabIndex = 3
        Products1.TextAlign = ContentAlignment.BottomCenter
        Products1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DeepSkyBlue
        Button2.Cursor = Cursors.Hand
        Button2.Dock = DockStyle.Top
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(0, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(819, 31)
        Button2.TabIndex = 16
        Button2.Text = "Add New"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonHighlight
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Cursor = Cursors.Hand
        Button3.Location = New Point(205, 37)
        Button3.Name = "Button3"
        Button3.Size = New Size(187, 187)
        Button3.TabIndex = 17
        Button3.Text = "T-Shirt"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ButtonHighlight
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Cursor = Cursors.Hand
        Button4.Location = New Point(398, 37)
        Button4.Name = "Button4"
        Button4.Size = New Size(187, 187)
        Button4.TabIndex = 18
        Button4.Text = "T-Shirt"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ButtonHighlight
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.BackgroundImageLayout = ImageLayout.Zoom
        Button5.Cursor = Cursors.Hand
        Button5.Location = New Point(591, 37)
        Button5.Name = "Button5"
        Button5.Size = New Size(187, 187)
        Button5.TabIndex = 19
        Button5.Text = "T-Shirt"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button6)
        Panel1.Location = New Point(147, 109)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(516, 309)
        Panel1.TabIndex = 20
        Panel1.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(391, 264)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 40)
        Button1.TabIndex = 1
        Button1.Text = "DECLINE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Lime
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(3, 264)
        Button6.Name = "Button6"
        Button6.Size = New Size(120, 40)
        Button6.TabIndex = 0
        Button6.Text = "ACCEPT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' ProductsPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.LightCyan
        ClientSize = New Size(819, 539)
        Controls.Add(Panel1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Products1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "ProductsPage"
        ShowInTaskbar = False
        Text = "ProductsPage"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Products1 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Suppliers5 As Button
    Friend WithEvents Suppliers8 As Button
    Friend WithEvents Suppliers6 As Button
    Friend WithEvents Suppliers7 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
End Class
