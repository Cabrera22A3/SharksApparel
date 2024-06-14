<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.BackColor = Color.DodgerBlue
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(370, 492)
        Button1.Name = "Button1"
        Button1.Size = New Size(252, 63)
        Button1.TabIndex = 0
        Button1.Text = "LOG IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.LightCyan
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(370, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(250, 250)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(304, 292)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 23)
        Label1.TabIndex = 2
        Label1.Text = "USERNAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(304, 371)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 23)
        Label2.TabIndex = 3
        Label2.Text = "PASSWORD:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(304, 318)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(371, 31)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(304, 397)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(371, 31)
        TextBox2.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1004, 601)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(50, 50)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SharksApparel"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

End Class
