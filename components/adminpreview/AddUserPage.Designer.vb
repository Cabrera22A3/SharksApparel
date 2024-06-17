<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserPage
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Button6 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 32)
        Label1.TabIndex = 2
        Label1.Text = "ADD USER PAGE"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Verdana", 21.75F, FontStyle.Bold)
        TextBox1.Location = New Point(371, 52)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(400, 43)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 21.75F, FontStyle.Bold)
        Label2.Location = New Point(43, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(306, 35)
        Label2.TabIndex = 4
        Label2.Text = "Create Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 21.75F, FontStyle.Bold)
        Label3.Location = New Point(43, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(298, 35)
        Label3.TabIndex = 5
        Label3.Text = "Create Password:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Verdana", 21.75F, FontStyle.Bold)
        TextBox3.Location = New Point(371, 111)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(400, 43)
        TextBox3.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 21.75F, FontStyle.Bold)
        Label5.Location = New Point(43, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(280, 35)
        Label5.TabIndex = 9
        Label5.Text = "Enter User Role:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Verdana", 21.75F, FontStyle.Bold)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"admin", "staff", "cashier"})
        ComboBox1.Location = New Point(371, 170)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(400, 43)
        ComboBox1.TabIndex = 11
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Lime
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(43, 487)
        Button6.Name = "Button6"
        Button6.Size = New Size(120, 40)
        Button6.TabIndex = 12
        Button6.Text = "SAVE"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(651, 487)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 40)
        Button1.TabIndex = 13
        Button1.Text = "CLEAR"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Lime
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(217, 487)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 40)
        Button2.TabIndex = 14
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(43, 219)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(728, 262)
        DataGridView1.TabIndex = 15
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Lime
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(474, 487)
        Button3.Name = "Button3"
        Button3.Size = New Size(120, 40)
        Button3.TabIndex = 16
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' AddUserPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.LightCyan
        ClientSize = New Size(819, 539)
        Controls.Add(Button3)
        Controls.Add(DataGridView1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Button6)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddUserPage"
        ShowInTaskbar = False
        Text = "AddUserPage"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
End Class
