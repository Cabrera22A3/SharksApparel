﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHome))
        HomeBtn = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        ProductApprovalBtn = New Button()
        AddUserBtn = New Button()
        AboutUsBtn = New Button()
        SalesBtn = New Button()
        ProductsBtn = New Button()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' HomeBtn
        ' 
        HomeBtn.BackColor = Color.Azure
        HomeBtn.Cursor = Cursors.Hand
        HomeBtn.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        HomeBtn.Location = New Point(0, 20)
        HomeBtn.Name = "HomeBtn"
        HomeBtn.Size = New Size(188, 58)
        HomeBtn.TabIndex = 0
        HomeBtn.Text = "Dashboard"
        HomeBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1006, 66)
        Panel1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(66, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 38)
        Label1.TabIndex = 1
        Label1.Text = "SharksApparel"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.PaleTurquoise
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(15, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 45)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightBlue
        Panel2.Controls.Add(ProductApprovalBtn)
        Panel2.Controls.Add(AddUserBtn)
        Panel2.Controls.Add(AboutUsBtn)
        Panel2.Controls.Add(SalesBtn)
        Panel2.Controls.Add(ProductsBtn)
        Panel2.Controls.Add(HomeBtn)
        Panel2.Location = New Point(-1, 61)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(188, 542)
        Panel2.TabIndex = 5
        ' 
        ' ProductApprovalBtn
        ' 
        ProductApprovalBtn.BackColor = Color.Azure
        ProductApprovalBtn.Cursor = Cursors.Hand
        ProductApprovalBtn.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        ProductApprovalBtn.Location = New Point(0, 148)
        ProductApprovalBtn.Name = "ProductApprovalBtn"
        ProductApprovalBtn.Size = New Size(188, 58)
        ProductApprovalBtn.TabIndex = 1
        ProductApprovalBtn.Text = "Product Approval"
        ProductApprovalBtn.UseVisualStyleBackColor = False
        ' 
        ' AddUserBtn
        ' 
        AddUserBtn.BackColor = Color.Azure
        AddUserBtn.Cursor = Cursors.Hand
        AddUserBtn.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        AddUserBtn.Location = New Point(0, 276)
        AddUserBtn.Name = "AddUserBtn"
        AddUserBtn.Size = New Size(188, 58)
        AddUserBtn.TabIndex = 1
        AddUserBtn.Text = "Add User"
        AddUserBtn.UseVisualStyleBackColor = False
        ' 
        ' AboutUsBtn
        ' 
        AboutUsBtn.BackColor = Color.Azure
        AboutUsBtn.Cursor = Cursors.Hand
        AboutUsBtn.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        AboutUsBtn.Location = New Point(0, 340)
        AboutUsBtn.Name = "AboutUsBtn"
        AboutUsBtn.Size = New Size(188, 58)
        AboutUsBtn.TabIndex = 4
        AboutUsBtn.Text = "About Us"
        AboutUsBtn.UseVisualStyleBackColor = False
        ' 
        ' SalesBtn
        ' 
        SalesBtn.BackColor = Color.Azure
        SalesBtn.Cursor = Cursors.Hand
        SalesBtn.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        SalesBtn.Location = New Point(0, 212)
        SalesBtn.Name = "SalesBtn"
        SalesBtn.Size = New Size(188, 58)
        SalesBtn.TabIndex = 3
        SalesBtn.Text = "Sales Stock"
        SalesBtn.UseVisualStyleBackColor = False
        ' 
        ' ProductsBtn
        ' 
        ProductsBtn.BackColor = Color.Azure
        ProductsBtn.Cursor = Cursors.Hand
        ProductsBtn.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        ProductsBtn.Location = New Point(0, 84)
        ProductsBtn.Name = "ProductsBtn"
        ProductsBtn.Size = New Size(188, 58)
        ProductsBtn.TabIndex = 1
        ProductsBtn.Text = "Products"
        ProductsBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightCyan
        Panel3.Location = New Point(186, 64)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(819, 539)
        Panel3.TabIndex = 6
        ' 
        ' AdminHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1004, 601)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(50, 50)
        MaximizeBox = False
        Name = "AdminHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin - SharksApparel"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents HomeBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AboutUsBtn As Button
    Friend WithEvents SalesBtn As Button
    Friend WithEvents ProductsBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AddUserBtn As Button
    Friend WithEvents ProductApprovalBtn As Button
End Class
