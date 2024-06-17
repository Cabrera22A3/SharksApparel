<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutUsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutUsPage))
        Label1 = New Label()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label4 = New Label()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Label3 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(199, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(437, 38)
        Label1.TabIndex = 0
        Label1.Text = "About Us"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(199, 290)
        Label2.Name = "Label2"
        Label2.Size = New Size(437, 38)
        Label2.TabIndex = 2
        Label2.Text = "Mission and Values"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 55.75221F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 44.24779F))
        TableLayoutPanel1.Controls.Add(Label4, 1, 6)
        TableLayoutPanel1.Controls.Add(Panel2, 1, 5)
        TableLayoutPanel1.Controls.Add(Panel1, 1, 1)
        TableLayoutPanel1.Controls.Add(Label2, 1, 4)
        TableLayoutPanel1.Controls.Add(Label3, 1, 2)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Location = New Point(16, 12)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.263158F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 43.8596458F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25.6140347F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25.2631569F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 169F))
        TableLayoutPanel1.Size = New Size(795, 515)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Verdana", 9.75F)
        Label4.Location = New Point(199, 343)
        Label4.Name = "Label4"
        Label4.Size = New Size(437, 119)
        Label4.TabIndex = 5
        Label4.Text = resources.GetString("Label4.Text")
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel2.BackColor = Color.DodgerBlue
        Panel2.Location = New Point(232, 331)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(370, 9)
        Panel2.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Location = New Point(316, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(203, 7)
        Panel1.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(199, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(437, 105)
        Label3.TabIndex = 5
        Label3.Text = resources.GetString("Label3.Text")
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AboutUsPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.LightCyan
        ClientSize = New Size(819, 539)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AboutUsPage"
        Text = "AboutUsPage"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
