<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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

    Private Const V As String = "Form"

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        product_id = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        name = New TextBox()
        Label3 = New Label()
        description = New TextBox()
        Label4 = New Label()
        category_id = New TextBox()
        Label5 = New Label()
        size = New TextBox()
        Label7 = New Label()
        color = New TextBox()
        Label8 = New Label()
        cost_price = New TextBox()
        Label9 = New Label()
        retail_price = New TextBox()
        Label10 = New Label()
        stock_quantity = New TextBox()
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
        Button2 = New Button()
        reload = New Button()
        formname = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(669, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 34)
        Button1.TabIndex = 0
        Button1.Text = "Check Database"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' product_id
        ' 
        product_id.Location = New Point(84, 19)
        product_id.Name = "product_id"
        product_id.Size = New Size(162, 23)
        product_id.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 2
        Label1.Text = "Product ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 4
        Label2.Text = "Name:"
        ' 
        ' name
        ' 
        name.Location = New Point(84, 48)
        name.Name = "name"
        name.Size = New Size(162, 23)
        name.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 6
        Label3.Text = "Description:"
        ' 
        ' description
        ' 
        description.Location = New Point(84, 77)
        description.Multiline = True
        description.Name = "description"
        description.Size = New Size(162, 109)
        description.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(256, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 8
        Label4.Text = "Category ID:"
        ' 
        ' category_id
        ' 
        category_id.Location = New Point(350, 18)
        category_id.Name = "category_id"
        category_id.Size = New Size(162, 23)
        category_id.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(256, 53)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 10
        Label5.Text = "Size:"
        ' 
        ' size
        ' 
        size.Location = New Point(350, 47)
        size.Name = "size"
        size.Size = New Size(162, 23)
        size.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(256, 82)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 14
        Label7.Text = "Color:"
        ' 
        ' color
        ' 
        color.Location = New Point(350, 76)
        color.Name = "color"
        color.Size = New Size(162, 23)
        color.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(256, 111)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 15)
        Label8.TabIndex = 16
        Label8.Text = "Cost Price:"
        ' 
        ' cost_price
        ' 
        cost_price.Location = New Point(350, 105)
        cost_price.Name = "cost_price"
        cost_price.Size = New Size(162, 23)
        cost_price.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(256, 140)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 15)
        Label9.TabIndex = 18
        Label9.Text = "Retail Price:"
        ' 
        ' retail_price
        ' 
        retail_price.Location = New Point(350, 134)
        retail_price.Name = "retail_price"
        retail_price.Size = New Size(162, 23)
        retail_price.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(256, 169)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 15)
        Label10.TabIndex = 20
        Label10.Text = "Stock Quantity:"
        ' 
        ' stock_quantity
        ' 
        stock_quantity.Location = New Point(350, 163)
        stock_quantity.Name = "stock_quantity"
        stock_quantity.Size = New Size(162, 23)
        stock_quantity.TabIndex = 19
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        DataGridView1.Location = New Point(12, 192)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(779, 296)
        DataGridView1.TabIndex = 21
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "product_id"
        Column1.HeaderText = "Product ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "name"
        Column2.HeaderText = "Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "description"
        Column3.HeaderText = "Description"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "category_id"
        Column4.HeaderText = "Category ID"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "size"
        Column5.HeaderText = "Size"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "color"
        Column6.HeaderText = "Color"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.DataPropertyName = "cost_price"
        Column7.HeaderText = "Cost Price"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.DataPropertyName = "retail_price"
        Column8.HeaderText = "Retail Price"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.DataPropertyName = "stock_quantity"
        Column9.HeaderText = "Stock Quantity"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(547, 19)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 22
        Button2.Text = "Create"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' reload
        ' 
        reload.Location = New Point(547, 48)
        reload.Name = "reload"
        reload.Size = New Size(75, 23)
        reload.TabIndex = 23
        reload.Text = "Reload"
        reload.UseVisualStyleBackColor = True
        ' 
        ' formname
        ' 
        formname.Location = New Point(84, 47)
        formname.Name = "formname"
        formname.Size = New Size(162, 23)
        formname.TabIndex = 24
        ' 
        ' Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(803, 500)
        Controls.Add(formname)
        Controls.Add(reload)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Label10)
        Controls.Add(stock_quantity)
        Controls.Add(Label9)
        Controls.Add(retail_price)
        Controls.Add(Label8)
        Controls.Add(cost_price)
        Controls.Add(Label7)
        Controls.Add(color)
        Controls.Add(Label5)
        Controls.Add(size)
        Controls.Add(Label4)
        Controls.Add(category_id)
        Controls.Add(Label3)
        Controls.Add(description)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(product_id)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "SalesPage"
        Text = "SalesPage"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents product_id As TextBox
    Friend WithEvents name As TextBox
    Friend WithEvents description As TextBox
    Friend WithEvents category_id As TextBox
    Friend WithEvents size As TextBox
    Friend WithEvents color As TextBox
    Friend WithEvents cost_price As TextBox
    Friend WithEvents retail_price As TextBox
    Friend WithEvents stock_quantity As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents reload As Button
    Friend WithEvents formname As TextBox
End Class
