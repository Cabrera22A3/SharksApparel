<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesPageDisplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesPageDisplay))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        Label10 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label11 = New Label()
        TextBox9 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightCyan
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 25)
        Label1.TabIndex = 0
        Label1.Text = "SALES INFORMATION PAGE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 1
        Label2.Text = "Product ID: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 15)
        Label3.TabIndex = 2
        Label3.Text = "Name of Product:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 15)
        Label4.TabIndex = 3
        Label4.Text = "Description of Product:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 15)
        Label5.TabIndex = 4
        Label5.Text = "Category ID:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(393, 51)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 15)
        Label6.TabIndex = 5
        Label6.Text = "Color of Product:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(393, 80)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 15)
        Label7.TabIndex = 6
        Label7.Text = "Cost Price:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(393, 109)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 15)
        Label8.TabIndex = 7
        Label8.Text = "Retail Price:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(393, 138)
        Label9.Name = "Label9"
        Label9.Size = New Size(88, 15)
        Label9.TabIndex = 8
        Label9.Text = "Stock Quantity:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Cursor = Cursors.Hand
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"SMALL (S)", "MEDIUM (M)", "LARGE (L)", "EXTRA-LARGE (XL)"})
        ComboBox1.Location = New Point(141, 161)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(199, 23)
        ComboBox1.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 161)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 15)
        Label10.TabIndex = 10
        Label10.Text = "Size of Product:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(141, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(199, 23)
        TextBox1.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(141, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(199, 23)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(141, 103)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(199, 23)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(141, 132)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(199, 23)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(522, 48)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(199, 23)
        TextBox5.TabIndex = 15
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(522, 77)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(199, 23)
        TextBox6.TabIndex = 16
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(522, 106)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(199, 23)
        TextBox7.TabIndex = 17
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(522, 135)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(199, 23)
        TextBox8.TabIndex = 18
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10})
        DataGridView1.Location = New Point(341, 190)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(466, 337)
        DataGridView1.TabIndex = 19
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product ID"
        Column1.Name = "Column1"
        Column1.Width = 81
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Name of Product"
        Column2.Name = "Column2"
        Column2.Width = 113
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Description of Product"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Category ID"
        Column4.Name = "Column4"
        Column4.Width = 87
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Size of Product"
        Column5.Name = "Column5"
        Column5.Width = 102
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Color of Product"
        Column6.Name = "Column6"
        Column6.Width = 110
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Cost Price"
        Column7.Name = "Column7"
        Column7.Width = 79
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Retail Price"
        Column8.Name = "Column8"
        Column8.Width = 83
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Stock Quantity"
        Column9.Name = "Column9"
        Column9.Width = 101
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "Photo"
        Column10.Name = "Column10"
        Column10.Width = 64
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlLightLight
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.ErrorImage = Nothing
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(12, 190)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(168, 203)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 50)
        Button1.TabIndex = 21
        Button1.Text = "Browse Image..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(168, 277)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 50)
        Button2.TabIndex = 22
        Button2.Text = "Remove Image"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(12, 353)
        Button3.Name = "Button3"
        Button3.Size = New Size(323, 36)
        Button3.TabIndex = 23
        Button3.Text = "Save Information"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        Button4.Location = New Point(12, 395)
        Button4.Name = "Button4"
        Button4.Size = New Size(323, 36)
        Button4.TabIndex = 24
        Button4.Text = "Update Information"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        Button5.Location = New Point(12, 437)
        Button5.Name = "Button5"
        Button5.Size = New Size(323, 36)
        Button5.TabIndex = 25
        Button5.Text = "Delete Information"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        Button6.Location = New Point(12, 479)
        Button6.Name = "Button6"
        Button6.Size = New Size(323, 36)
        Button6.TabIndex = 26
        Button6.Text = "Clear Information"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(393, 15)
        Label11.Name = "Label11"
        Label11.Size = New Size(45, 15)
        Label11.TabIndex = 27
        Label11.Text = "Search:"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(444, 12)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(277, 23)
        TextBox9.TabIndex = 28
        ' 
        ' SalesPageDisplay
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.LightCyan
        ClientSize = New Size(819, 539)
        Controls.Add(TextBox9)
        Controls.Add(Label11)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label10)
        Controls.Add(ComboBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "SalesPageDisplay"
        Text = "SalesPageDisplay"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox9 As TextBox
End Class
