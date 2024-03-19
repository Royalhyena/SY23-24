<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2DPlatformer
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
        Me.components = New System.ComponentModel.Container()
        Me.PBPlayer = New System.Windows.Forms.PictureBox()
        Me.PBAir = New System.Windows.Forms.PictureBox()
        Me.PBGround = New System.Windows.Forms.PictureBox()
        Me.TmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.TmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Mover1 = New Platformer.mover()
        Me.Mover2 = New Platformer.mover()
        Me.Mover3 = New Platformer.mover()
        Me.Mover4 = New Platformer.mover()
        Me.PictureBox27 = New System.Windows.Forms.PictureBox()
        Me.PictureBox28 = New System.Windows.Forms.PictureBox()
        Me.PictureBox29 = New System.Windows.Forms.PictureBox()
        CType(Me.PBPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBPlayer
        '
        Me.PBPlayer.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PBPlayer.Location = New System.Drawing.Point(22, 372)
        Me.PBPlayer.Name = "PBPlayer"
        Me.PBPlayer.Size = New System.Drawing.Size(36, 40)
        Me.PBPlayer.TabIndex = 0
        Me.PBPlayer.TabStop = False
        '
        'PBAir
        '
        Me.PBAir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PBAir.Location = New System.Drawing.Point(2, 0)
        Me.PBAir.Name = "PBAir"
        Me.PBAir.Size = New System.Drawing.Size(792, 383)
        Me.PBAir.TabIndex = 1
        Me.PBAir.TabStop = False
        '
        'PBGround
        '
        Me.PBGround.BackColor = System.Drawing.SystemColors.GrayText
        Me.PBGround.Location = New System.Drawing.Point(2, 409)
        Me.PBGround.Name = "PBGround"
        Me.PBGround.Size = New System.Drawing.Size(792, 41)
        Me.PBGround.TabIndex = 2
        Me.PBGround.TabStop = False
        '
        'TmrRight
        '
        Me.TmrRight.Interval = 20
        '
        'TmrLeft
        '
        Me.TmrLeft.Interval = 20
        '
        'TmrUp
        '
        Me.TmrUp.Interval = 20
        '
        'TmrGameLogic
        '
        Me.TmrGameLogic.Interval = 20
        '
        'TmrGravity
        '
        Me.TmrGravity.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox1.Location = New System.Drawing.Point(559, 237)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Restart"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox2.Location = New System.Drawing.Point(222, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 17)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "Bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox3.Location = New System.Drawing.Point(325, 107)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "Bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox4.Location = New System.Drawing.Point(485, 43)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 18)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "Win"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox5.Location = New System.Drawing.Point(161, 165)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "Collectable"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox6.Location = New System.Drawing.Point(22, 165)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "Bound"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox7.Location = New System.Drawing.Point(31247, 40)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "Bound"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox8.Location = New System.Drawing.Point(479, 274)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "Restart"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox9.Location = New System.Drawing.Point(474, 165)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "Bound"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox10.Location = New System.Drawing.Point(202, 143)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox10.TabIndex = 12
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "Restart"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox11.Location = New System.Drawing.Point(674, 142)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox11.TabIndex = 13
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "Bound"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox12.Location = New System.Drawing.Point(592, 291)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox12.TabIndex = 14
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "Bound"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox13.Location = New System.Drawing.Point(96, 119)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox13.TabIndex = 15
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "Bound"
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox14.Location = New System.Drawing.Point(344, 143)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox14.TabIndex = 16
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Tag = "Bound"
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox15.Location = New System.Drawing.Point(87, 53)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox15.TabIndex = 17
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Tag = "Restart"
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox16.Location = New System.Drawing.Point(213, 304)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox16.TabIndex = 18
        Me.PictureBox16.TabStop = False
        Me.PictureBox16.Tag = "Restart"
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox17.Location = New System.Drawing.Point(634, 344)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox17.TabIndex = 19
        Me.PictureBox17.TabStop = False
        Me.PictureBox17.Tag = "Restart"
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox18.Location = New System.Drawing.Point(37, 216)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox18.TabIndex = 20
        Me.PictureBox18.TabStop = False
        Me.PictureBox18.Tag = "Restart"
        '
        'PictureBox19
        '
        Me.PictureBox19.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox19.Location = New System.Drawing.Point(677, 165)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox19.TabIndex = 21
        Me.PictureBox19.TabStop = False
        Me.PictureBox19.Tag = "Restart"
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox20.Location = New System.Drawing.Point(614, 74)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox20.TabIndex = 22
        Me.PictureBox20.TabStop = False
        Me.PictureBox20.Tag = "Restart"
        '
        'PictureBox21
        '
        Me.PictureBox21.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.PictureBox21.Location = New System.Drawing.Point(345, 84)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(111, 18)
        Me.PictureBox21.TabIndex = 23
        Me.PictureBox21.TabStop = False
        Me.PictureBox21.Tag = "Restart"
        '
        'PictureBox22
        '
        Me.PictureBox22.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox22.Location = New System.Drawing.Point(161, 274)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox22.TabIndex = 24
        Me.PictureBox22.TabStop = False
        Me.PictureBox22.Tag = "Collectable"
        '
        'PictureBox23
        '
        Me.PictureBox23.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox23.Location = New System.Drawing.Point(435, 337)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox23.TabIndex = 25
        Me.PictureBox23.TabStop = False
        Me.PictureBox23.Tag = "Collectable"
        '
        'PictureBox24
        '
        Me.PictureBox24.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox24.Location = New System.Drawing.Point(519, 100)
        Me.PictureBox24.Name = "PictureBox24"
        Me.PictureBox24.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox24.TabIndex = 26
        Me.PictureBox24.TabStop = False
        Me.PictureBox24.Tag = "Collectable"
        '
        'PictureBox25
        '
        Me.PictureBox25.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox25.Location = New System.Drawing.Point(335, 43)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox25.TabIndex = 27
        Me.PictureBox25.TabStop = False
        Me.PictureBox25.Tag = "Collectable"
        '
        'PictureBox26
        '
        Me.PictureBox26.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox26.Location = New System.Drawing.Point(724, 231)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox26.TabIndex = 28
        Me.PictureBox26.TabStop = False
        Me.PictureBox26.Tag = "Collectable"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(370, 389)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 33
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 100
        Me.Mover1.Location = New System.Drawing.Point(370, 201)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(233, 33)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox1
        Me.Mover1.TabIndex = 29
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 100
        Me.Mover2.Location = New System.Drawing.Point(470, 104)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(233, 33)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.PictureBox11
        Me.Mover2.TabIndex = 30
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(96, 13)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(233, 33)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.PictureBox15
        Me.Mover3.TabIndex = 31
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 100
        Me.Mover4.Location = New System.Drawing.Point(52, 264)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(233, 33)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.PictureBox16
        Me.Mover4.TabIndex = 32
        '
        'PictureBox27
        '
        Me.PictureBox27.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox27.Location = New System.Drawing.Point(325, 220)
        Me.PictureBox27.Name = "PictureBox27"
        Me.PictureBox27.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox27.TabIndex = 34
        Me.PictureBox27.TabStop = False
        Me.PictureBox27.Tag = "Collectable"
        '
        'PictureBox28
        '
        Me.PictureBox28.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox28.Location = New System.Drawing.Point(68, 57)
        Me.PictureBox28.Name = "PictureBox28"
        Me.PictureBox28.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox28.TabIndex = 35
        Me.PictureBox28.TabStop = False
        Me.PictureBox28.Tag = "Collectable"
        '
        'PictureBox29
        '
        Me.PictureBox29.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox29.Location = New System.Drawing.Point(724, 112)
        Me.PictureBox29.Name = "PictureBox29"
        Me.PictureBox29.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox29.TabIndex = 36
        Me.PictureBox29.TabStop = False
        Me.PictureBox29.Tag = "Collectable"
        '
        'Form2DPlatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox29)
        Me.Controls.Add(Me.PictureBox28)
        Me.Controls.Add(Me.PictureBox27)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox26)
        Me.Controls.Add(Me.PictureBox25)
        Me.Controls.Add(Me.PictureBox24)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.PictureBox22)
        Me.Controls.Add(Me.PictureBox21)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PBPlayer)
        Me.Controls.Add(Me.PBGround)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.PBAir)
        Me.Name = "Form2DPlatformer"
        Me.Text = "Form1"
        CType(Me.PBPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBPlayer As PictureBox
    Friend WithEvents PBAir As PictureBox
    Friend WithEvents PBGround As PictureBox
    Friend WithEvents TmrRight As Timer
    Friend WithEvents TmrLeft As Timer
    Friend WithEvents TmrUp As Timer
    Friend WithEvents TmrGameLogic As Timer
    Friend WithEvents TmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox24 As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents Mover2 As mover
    Friend WithEvents Mover3 As mover
    Friend WithEvents Mover4 As mover
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox27 As PictureBox
    Friend WithEvents PictureBox28 As PictureBox
    Friend WithEvents PictureBox29 As PictureBox
End Class
