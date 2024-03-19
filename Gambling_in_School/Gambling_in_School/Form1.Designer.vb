<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Money = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.WheelControl3 = New Gambling_in_School.WheelControl()
        Me.WheelControl2 = New Gambling_in_School.WheelControl()
        Me.WheelControl1 = New Gambling_in_School.WheelControl()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(228, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(566, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Money
        '
        Me.Money.Location = New System.Drawing.Point(363, 367)
        Me.Money.Name = "Money"
        Me.Money.Size = New System.Drawing.Size(75, 23)
        Me.Money.TabIndex = 8
        Me.Money.Text = "Button2"
        Me.Money.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(540, 337)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'WheelControl3
        '
        Me.WheelControl3.itemvalue = 0
        Me.WheelControl3.Location = New System.Drawing.Point(502, 98)
        Me.WheelControl3.Name = "WheelControl3"
        Me.WheelControl3.Size = New System.Drawing.Size(150, 150)
        Me.WheelControl3.spintime = 2000
        Me.WheelControl3.TabIndex = 5
        '
        'WheelControl2
        '
        Me.WheelControl2.itemvalue = 0
        Me.WheelControl2.Location = New System.Drawing.Point(319, 98)
        Me.WheelControl2.Name = "WheelControl2"
        Me.WheelControl2.Size = New System.Drawing.Size(150, 150)
        Me.WheelControl2.spintime = 2000
        Me.WheelControl2.TabIndex = 4
        '
        'WheelControl1
        '
        Me.WheelControl1.itemvalue = 0
        Me.WheelControl1.Location = New System.Drawing.Point(48, 98)
        Me.WheelControl1.Name = "WheelControl1"
        Me.WheelControl1.Size = New System.Drawing.Size(150, 150)
        Me.WheelControl1.spintime = 2000
        Me.WheelControl1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Money)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WheelControl3)
        Me.Controls.Add(Me.WheelControl2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WheelControl1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents WheelControl1 As WheelControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents WheelControl2 As WheelControl
    Friend WithEvents WheelControl3 As WheelControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Money As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer2 As Timer
End Class
