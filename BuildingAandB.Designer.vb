<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuildingAnadB
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
        Me.pbRoomMap = New System.Windows.Forms.PictureBox()
        Me.txtSearchBar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbRooms = New System.Windows.Forms.ComboBox()
        CType(Me.pbRoomMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbRoomMap
        '
        Me.pbRoomMap.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pbRoomMap.Location = New System.Drawing.Point(76, 110)
        Me.pbRoomMap.Name = "pbRoomMap"
        Me.pbRoomMap.Size = New System.Drawing.Size(1173, 559)
        Me.pbRoomMap.TabIndex = 0
        Me.pbRoomMap.TabStop = False
        '
        'txtSearchBar
        '
        Me.txtSearchBar.Location = New System.Drawing.Point(509, 56)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Size = New System.Drawing.Size(430, 26)
        Me.txtSearchBar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rooms:"
        '
        'cbRooms
        '
        Me.cbRooms.FormattingEnabled = True
        Me.cbRooms.Location = New System.Drawing.Point(509, 56)
        Me.cbRooms.Name = "cbRooms"
        Me.cbRooms.Size = New System.Drawing.Size(429, 28)
        Me.cbRooms.TabIndex = 3
        '
        'BuildingAnadB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.BuildingAandB.My.Resources.Resources._462637110_598407476024439_8393031355740119888_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1313, 724)
        Me.Controls.Add(Me.cbRooms)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchBar)
        Me.Controls.Add(Me.pbRoomMap)
        Me.Name = "BuildingAnadB"
        Me.Text = "Building A and B"
        CType(Me.pbRoomMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbRoomMap As PictureBox
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbRooms As ComboBox
End Class
