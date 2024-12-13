<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AulaMagna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AulaMagna))
        Me.cbRoom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbAula2 = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.pbAula2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbRoom
        '
        Me.cbRoom.DropDownHeight = 130
        Me.cbRoom.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoom.FormattingEnabled = True
        Me.cbRoom.IntegralHeight = False
        Me.cbRoom.Location = New System.Drawing.Point(715, 43)
        Me.cbRoom.Name = "cbRoom"
        Me.cbRoom.Size = New System.Drawing.Size(485, 36)
        Me.cbRoom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(629, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Room:"
        '
        'pbAula2
        '
        Me.pbAula2.BackColor = System.Drawing.Color.White
        Me.pbAula2.Image = Global.TRYING.My.Resources.Resources._2nd_floor
        Me.pbAula2.Location = New System.Drawing.Point(109, 114)
        Me.pbAula2.Name = "pbAula2"
        Me.pbAula2.Size = New System.Drawing.Size(1702, 854)
        Me.pbAula2.TabIndex = 2
        Me.pbAula2.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(1685, 43)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(126, 39)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'AulaMagna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TRYING.My.Resources.Resources._462643700_1252170696084857_7252594198127571684_n
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.pbAula2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbRoom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AulaMagna"
        Me.Text = "Lakbay: A DYCIan Tour Map Elida Campus"
        CType(Me.pbAula2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbRoom As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbAula2 As PictureBox
    Friend WithEvents btnPrint As Button
End Class
