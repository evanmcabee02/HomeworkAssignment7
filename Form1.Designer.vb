<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraoke
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
        Me.cboKaraoke = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboKaraoke
        '
        Me.cboKaraoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKaraoke.FormattingEnabled = True
        Me.cboKaraoke.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.cboKaraoke.Location = New System.Drawing.Point(330, 87)
        Me.cboKaraoke.Name = "cboKaraoke"
        Me.cboKaraoke.Size = New System.Drawing.Size(458, 33)
        Me.cboKaraoke.TabIndex = 1
        Me.cboKaraoke.Text = "Customize your Night:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(400, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Karaoke Music Night"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDisplay.Location = New System.Drawing.Point(403, 170)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(292, 22)
        Me.lblDisplay.TabIndex = 3
        Me.lblDisplay.Text = "Hourly Rental of Karaoke Room"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(516, 208)
        Me.txtHours.Multiline = True
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(64, 35)
        Me.txtHours.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(348, 328)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(168, 38)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Total Cost"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(579, 328)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(168, 38)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalCost.Location = New System.Drawing.Point(403, 397)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(322, 22)
        Me.lblTotalCost.TabIndex = 7
        Me.lblTotalCost.Text = "Total Cost of Karaoke Night - $$$$"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HomeworkAssignment7.My.Resources.Resources.Karaokefix
        Me.PictureBox1.InitialImage = Global.HomeworkAssignment7.My.Resources.Resources.karaoke
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(317, 455)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmKaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboKaraoke)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmKaraoke"
        Me.Text = "Karaoke Music Night"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboKaraoke As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalCost As Label
End Class
