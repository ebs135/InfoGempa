<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoGempa
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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTanggal = New System.Windows.Forms.TextBox()
        Me.txtJam = New System.Windows.Forms.TextBox()
        Me.txtLintang = New System.Windows.Forms.TextBox()
        Me.txtBujur = New System.Windows.Forms.TextBox()
        Me.txtMagnitude = New System.Windows.Forms.TextBox()
        Me.txtKedalaman = New System.Windows.Forms.TextBox()
        Me.txtWilayah = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(285, 42)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(100, 50)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&LOAD"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(19, 216)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(369, 33)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "&EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Informasi Gempa Terkini BMKG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Lintang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Bujur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(209, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Magnitude"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(204, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Kedalaman"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Wilayah"
        '
        'txtTanggal
        '
        Me.txtTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTanggal.Location = New System.Drawing.Point(92, 42)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.ReadOnly = True
        Me.txtTanggal.Size = New System.Drawing.Size(100, 23)
        Me.txtTanggal.TabIndex = 10
        '
        'txtJam
        '
        Me.txtJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJam.Location = New System.Drawing.Point(92, 72)
        Me.txtJam.Name = "txtJam"
        Me.txtJam.ReadOnly = True
        Me.txtJam.Size = New System.Drawing.Size(100, 23)
        Me.txtJam.TabIndex = 11
        '
        'txtLintang
        '
        Me.txtLintang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLintang.Location = New System.Drawing.Point(92, 102)
        Me.txtLintang.Name = "txtLintang"
        Me.txtLintang.ReadOnly = True
        Me.txtLintang.Size = New System.Drawing.Size(100, 23)
        Me.txtLintang.TabIndex = 12
        '
        'txtBujur
        '
        Me.txtBujur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBujur.Location = New System.Drawing.Point(92, 132)
        Me.txtBujur.Name = "txtBujur"
        Me.txtBujur.ReadOnly = True
        Me.txtBujur.Size = New System.Drawing.Size(100, 23)
        Me.txtBujur.TabIndex = 13
        '
        'txtMagnitude
        '
        Me.txtMagnitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMagnitude.Location = New System.Drawing.Point(285, 102)
        Me.txtMagnitude.Name = "txtMagnitude"
        Me.txtMagnitude.ReadOnly = True
        Me.txtMagnitude.Size = New System.Drawing.Size(100, 23)
        Me.txtMagnitude.TabIndex = 14
        '
        'txtKedalaman
        '
        Me.txtKedalaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKedalaman.Location = New System.Drawing.Point(285, 132)
        Me.txtKedalaman.Name = "txtKedalaman"
        Me.txtKedalaman.ReadOnly = True
        Me.txtKedalaman.Size = New System.Drawing.Size(100, 23)
        Me.txtKedalaman.TabIndex = 15
        '
        'txtWilayah
        '
        Me.txtWilayah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWilayah.Location = New System.Drawing.Point(92, 164)
        Me.txtWilayah.Multiline = True
        Me.txtWilayah.Name = "txtWilayah"
        Me.txtWilayah.ReadOnly = True
        Me.txtWilayah.Size = New System.Drawing.Size(293, 46)
        Me.txtWilayah.TabIndex = 16
        '
        'frmInfoGempa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 261)
        Me.Controls.Add(Me.txtWilayah)
        Me.Controls.Add(Me.txtKedalaman)
        Me.Controls.Add(Me.txtMagnitude)
        Me.Controls.Add(Me.txtBujur)
        Me.Controls.Add(Me.txtLintang)
        Me.Controls.Add(Me.txtJam)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "frmInfoGempa"
        Me.Text = "Tampilkan Informasi Gempa BMKG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtJam As System.Windows.Forms.TextBox
    Friend WithEvents txtLintang As System.Windows.Forms.TextBox
    Friend WithEvents txtBujur As System.Windows.Forms.TextBox
    Friend WithEvents txtMagnitude As System.Windows.Forms.TextBox
    Friend WithEvents txtKedalaman As System.Windows.Forms.TextBox
    Friend WithEvents txtWilayah As System.Windows.Forms.TextBox

End Class
