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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Field2 = New System.Windows.Forms.TextBox()
        Me.Field3 = New System.Windows.Forms.TextBox()
        Me.Field4 = New System.Windows.Forms.TextBox()
        Me.Field5 = New System.Windows.Forms.TextBox()
        Me.Field1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(426, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(426, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Conference"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(426, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Division"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(426, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Record"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(426, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Position"
        '
        'Field2
        '
        Me.Field2.Location = New System.Drawing.Point(516, 137)
        Me.Field2.Name = "Field2"
        Me.Field2.Size = New System.Drawing.Size(125, 27)
        Me.Field2.TabIndex = 6
        '
        'Field3
        '
        Me.Field3.Location = New System.Drawing.Point(493, 190)
        Me.Field3.Name = "Field3"
        Me.Field3.Size = New System.Drawing.Size(125, 27)
        Me.Field3.TabIndex = 7
        '
        'Field4
        '
        Me.Field4.Location = New System.Drawing.Point(493, 240)
        Me.Field4.Name = "Field4"
        Me.Field4.Size = New System.Drawing.Size(125, 27)
        Me.Field4.TabIndex = 8
        '
        'Field5
        '
        Me.Field5.Location = New System.Drawing.Point(493, 290)
        Me.Field5.Name = "Field5"
        Me.Field5.Size = New System.Drawing.Size(125, 27)
        Me.Field5.TabIndex = 9
        '
        'Field1
        '
        Me.Field1.Location = New System.Drawing.Point(493, 90)
        Me.Field1.Name = "Field1"
        Me.Field1.Size = New System.Drawing.Size(125, 27)
        Me.Field1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(408, 390)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.NewToolStripMenuItem})
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Field1)
        Me.Controls.Add(Me.Field5)
        Me.Controls.Add(Me.Field4)
        Me.Controls.Add(Me.Field3)
        Me.Controls.Add(Me.Field2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Field2 As TextBox
    Friend WithEvents Field3 As TextBox
    Friend WithEvents Field4 As TextBox
    Friend WithEvents Field5 As TextBox
    Friend WithEvents Field1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
