<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierDashboard
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
        Button1 = New Button()
        Panel1 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        ListBox1 = New ListBox()
        Button2 = New Button()
        Panel2 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
        Button7 = New Button()
        TextBox4 = New TextBox()
        Label10 = New Label()
        Button5 = New Button()
        CheckBox1 = New CheckBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Button6 = New Button()
        TextBox7 = New TextBox()
        FlowLayoutPanel2.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.CornflowerBlue
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(525, 8)
        Button1.Name = "Button1"
        Button1.Size = New Size(290, 46)
        Button1.TabIndex = 5
        Button1.Text = "Add New Order"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Location = New Point(509, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(10, 540)
        Panel1.TabIndex = 1
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.Azure
        FlowLayoutPanel1.Location = New Point(2, 1)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(501, 534)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.Controls.Add(ListBox1)
        FlowLayoutPanel2.Location = New Point(525, 60)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(290, 356)
        FlowLayoutPanel2.TabIndex = 4
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(3, 3)
        ListBox1.Name = "ListBox1"
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.Size = New Size(280, 349)
        ListBox1.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Turquoise
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(525, 489)
        Button2.Name = "Button2"
        Button2.Size = New Size(290, 46)
        Button2.TabIndex = 6
        Button2.Text = "Pay"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(205, 129)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(458, 261)
        Panel2.TabIndex = 7
        Panel2.Visible = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Azure
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(278, 196)
        Button4.Name = "Button4"
        Button4.Size = New Size(152, 37)
        Button4.TabIndex = 7
        Button4.Text = "DONE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Azure
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(33, 196)
        Button3.Name = "Button3"
        Button3.Size = New Size(152, 37)
        Button3.TabIndex = 6
        Button3.Text = "PAY NOW"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Font = New Font("Verdana", 20.25F)
        TextBox3.Location = New Point(191, 123)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(239, 40)
        TextBox3.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(191, 31)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ScrollBars = ScrollBars.Horizontal
        TextBox2.Size = New Size(239, 40)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Verdana", 20.25F)
        TextBox1.Location = New Point(191, 77)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(239, 40)
        TextBox1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        Label4.Location = New Point(33, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 32)
        Label4.TabIndex = 2
        Label4.Text = "PAY:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        Label3.Location = New Point(33, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 32)
        Label3.TabIndex = 1
        Label3.Text = "CHANGE:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        Label1.Location = New Point(33, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 32)
        Label1.TabIndex = 0
        Label1.Text = "TOTAL:"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Button7)
        Panel4.Controls.Add(TextBox4)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(Button5)
        Panel4.Controls.Add(CheckBox1)
        Panel4.Controls.Add(TextBox6)
        Panel4.Controls.Add(TextBox5)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(185, 108)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(489, 292)
        Panel4.TabIndex = 8
        Panel4.Visible = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Red
        Button7.FlatStyle = FlatStyle.Popup
        Button7.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = SystemColors.ButtonFace
        Button7.Location = New Point(65, 158)
        Button7.Name = "Button7"
        Button7.Size = New Size(104, 38)
        Button7.TabIndex = 10
        Button7.Text = "CLOSE "
        Button7.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Enabled = False
        TextBox4.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(260, 62)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(212, 40)
        TextBox4.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        Label10.Location = New Point(14, 65)
        Label10.Name = "Label10"
        Label10.Size = New Size(240, 32)
        Label10.TabIndex = 8
        Label10.Text = "Product Name:"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.SpringGreen
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(18, 213)
        Button5.Name = "Button5"
        Button5.Size = New Size(454, 56)
        Button5.TabIndex = 7
        Button5.Text = "Save / Edit"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Font = New Font("Verdana", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(271, 154)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(185, 53)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Check if add / Uncheck if remove"
        CheckBox1.TextAlign = ContentAlignment.MiddleCenter
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Verdana", 20.25F)
        TextBox6.Location = New Point(260, 108)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(212, 40)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Verdana", 20.25F)
        TextBox5.Location = New Point(260, 16)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(212, 40)
        TextBox5.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        Label7.Location = New Point(14, 111)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 32)
        Label7.TabIndex = 2
        Label7.Text = "Quantity:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        Label6.Location = New Point(14, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(189, 32)
        Label6.TabIndex = 1
        Label6.Text = "Product ID:"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.GreenYellow
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Verdana", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.ActiveCaptionText
        Button6.Location = New Point(388, 489)
        Button6.Name = "Button6"
        Button6.Size = New Size(103, 38)
        Button6.TabIndex = 0
        Button6.Text = "REFRESH"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' TextBox7
        ' 
        TextBox7.Enabled = False
        TextBox7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(525, 429)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(290, 45)
        TextBox7.TabIndex = 9
        ' 
        ' CashierDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(819, 539)
        Controls.Add(TextBox7)
        Controls.Add(Button6)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(Panel1)
        Controls.Add(FlowLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CashierDashboard"
        Text = "CashierDashboard"
        FlowLayoutPanel2.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox7 As TextBox
End Class
