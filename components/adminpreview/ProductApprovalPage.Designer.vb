<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductApprovalPage
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewCheckBoxColumn()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        CheckBox1 = New CheckBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(423, 32)
        Label1.TabIndex = 2
        Label1.Text = "PRODUCT APPROVAL PAGE"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.Location = New Point(12, 204)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.Size = New Size(795, 323)
        DataGridView1.TabIndex = 3
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Column1.DefaultCellStyle = DataGridViewCellStyle2
        Column1.HeaderText = "Product Request ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Product ID"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Date Created"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        Column4.DefaultCellStyle = DataGridViewCellStyle3
        Column4.HeaderText = "Request Description"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Status"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.BackColor = Color.DeepSkyBlue
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.AliceBlue
        Button1.Location = New Point(521, 117)
        Button1.Name = "Button1"
        Button1.Size = New Size(256, 61)
        Button1.TabIndex = 4
        Button1.Text = "SAVE REQUEST"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Verdana", 14.25F)
        TextBox1.Location = New Point(243, 117)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(260, 31)
        TextBox1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(38, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(199, 23)
        Label2.TabIndex = 6
        Label2.Text = "Enter Product ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(38, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 23)
        Label3.TabIndex = 7
        Label3.Text = "Request Status:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        CheckBox1.Location = New Point(243, 154)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(130, 27)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "Approved"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(457, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 23)
        Label4.TabIndex = 9
        Label4.Text = "Search:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Verdana", 14.25F)
        TextBox2.Location = New Point(547, 61)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(260, 31)
        TextBox2.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Lime
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(413, 154)
        Button2.Name = "Button2"
        Button2.Size = New Size(90, 27)
        Button2.TabIndex = 11
        Button2.Text = "REFRESH"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ProductApprovalPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.LightCyan
        ClientSize = New Size(819, 539)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(CheckBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "ProductApprovalPage"
        ShowInTaskbar = False
        Text = "ProductApprovalPage"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewCheckBoxColumn
End Class
