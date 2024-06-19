<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductsPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button2 = New Button()
        Panel1 = New Panel()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Button6 = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button3 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button6)
        Panel1.Location = New Point(147, 109)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(516, 309)
        Panel1.TabIndex = 20
        Panel1.Visible = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Verdana", 12F)
        TextBox2.Location = New Point(159, 78)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(293, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Verdana", 12F)
        TextBox3.Location = New Point(48, 140)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(404, 95)
        TextBox3.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label3.Location = New Point(48, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(190, 18)
        Label3.TabIndex = 6
        Label3.Text = "Request Description:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Verdana", 12F)
        TextBox1.Location = New Point(159, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(293, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label2.Location = New Point(48, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 18)
        Label2.TabIndex = 3
        Label2.Text = "Date:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Bold)
        Label1.Location = New Point(48, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 18)
        Label1.TabIndex = 2
        Label1.Text = "Product ID:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(380, 254)
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
        Button6.Location = New Point(13, 254)
        Button6.Name = "Button6"
        Button6.Size = New Size(120, 40)
        Button6.TabIndex = 0
        Button6.Text = "ACCEPT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Location = New Point(0, 28)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(819, 510)
        FlowLayoutPanel1.TabIndex = 21
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Lime
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(687, 487)
        Button3.Name = "Button3"
        Button3.Size = New Size(120, 40)
        Button3.TabIndex = 22
        Button3.Text = "REFRESH"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ProductsPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.LightCyan
        ClientSize = New Size(819, 539)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Button2)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "ProductsPage"
        ShowInTaskbar = False
        Text = "ProductsPage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Suppliers5 As Button
    Friend WithEvents Suppliers8 As Button
    Friend WithEvents Suppliers6 As Button
    Friend WithEvents Suppliers7 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button3 As Button
End Class
