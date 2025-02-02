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
        Me.LBLtitle = New System.Windows.Forms.Label()
        Me.LBLone = New System.Windows.Forms.Label()
        Me.TXTmoney = New System.Windows.Forms.TextBox()
        Me.GBone = New System.Windows.Forms.GroupBox()
        Me.RBthree = New System.Windows.Forms.RadioButton()
        Me.RBtwo = New System.Windows.Forms.RadioButton()
        Me.RBone = New System.Windows.Forms.RadioButton()
        Me.LBLtwo = New System.Windows.Forms.Label()
        Me.LBLoutput = New System.Windows.Forms.Label()
        Me.BTNquit = New System.Windows.Forms.Button()
        Me.BTNstart = New System.Windows.Forms.Button()
        Me.GBone.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBLtitle
        '
        Me.LBLtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLtitle.Location = New System.Drawing.Point(286, 40)
        Me.LBLtitle.Name = "LBLtitle"
        Me.LBLtitle.Size = New System.Drawing.Size(205, 45)
        Me.LBLtitle.TabIndex = 0
        Me.LBLtitle.Text = "Currency Coverter"
        '
        'LBLone
        '
        Me.LBLone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLone.Location = New System.Drawing.Point(13, 110)
        Me.LBLone.Name = "LBLone"
        Me.LBLone.Size = New System.Drawing.Size(141, 74)
        Me.LBLone.TabIndex = 1
        Me.LBLone.Text = "Enter the amout in australian dollars:"
        '
        'TXTmoney
        '
        Me.TXTmoney.Location = New System.Drawing.Point(12, 187)
        Me.TXTmoney.Name = "TXTmoney"
        Me.TXTmoney.Size = New System.Drawing.Size(100, 22)
        Me.TXTmoney.TabIndex = 2
        '
        'GBone
        '
        Me.GBone.Controls.Add(Me.RBthree)
        Me.GBone.Controls.Add(Me.RBtwo)
        Me.GBone.Controls.Add(Me.RBone)
        Me.GBone.Location = New System.Drawing.Point(274, 110)
        Me.GBone.Name = "GBone"
        Me.GBone.Size = New System.Drawing.Size(217, 187)
        Me.GBone.TabIndex = 3
        Me.GBone.TabStop = False
        '
        'RBthree
        '
        Me.RBthree.AutoSize = True
        Me.RBthree.Location = New System.Drawing.Point(7, 127)
        Me.RBthree.Name = "RBthree"
        Me.RBthree.Size = New System.Drawing.Size(125, 21)
        Me.RBthree.TabIndex = 2
        Me.RBthree.TabStop = True
        Me.RBthree.Text = "European Euro"
        Me.RBthree.UseVisualStyleBackColor = True
        '
        'RBtwo
        '
        Me.RBtwo.AutoSize = True
        Me.RBtwo.Location = New System.Drawing.Point(7, 77)
        Me.RBtwo.Name = "RBtwo"
        Me.RBtwo.Size = New System.Drawing.Size(94, 21)
        Me.RBtwo.TabIndex = 1
        Me.RBtwo.TabStop = True
        Me.RBtwo.Text = "UK dollars"
        Me.RBtwo.UseVisualStyleBackColor = True
        '
        'RBone
        '
        Me.RBone.AutoSize = True
        Me.RBone.Location = New System.Drawing.Point(7, 32)
        Me.RBone.Name = "RBone"
        Me.RBone.Size = New System.Drawing.Size(94, 21)
        Me.RBone.TabIndex = 0
        Me.RBone.TabStop = True
        Me.RBone.Text = "US dollars"
        Me.RBone.UseVisualStyleBackColor = True
        '
        'LBLtwo
        '
        Me.LBLtwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLtwo.Location = New System.Drawing.Point(590, 135)
        Me.LBLtwo.Name = "LBLtwo"
        Me.LBLtwo.Size = New System.Drawing.Size(133, 28)
        Me.LBLtwo.TabIndex = 4
        Me.LBLtwo.Text = "Coverted amout:"
        '
        'LBLoutput
        '
        Me.LBLoutput.Location = New System.Drawing.Point(590, 185)
        Me.LBLoutput.Name = "LBLoutput"
        Me.LBLoutput.Size = New System.Drawing.Size(100, 23)
        Me.LBLoutput.TabIndex = 5
        '
        'BTNquit
        '
        Me.BTNquit.Location = New System.Drawing.Point(593, 350)
        Me.BTNquit.Name = "BTNquit"
        Me.BTNquit.Size = New System.Drawing.Size(165, 88)
        Me.BTNquit.TabIndex = 6
        Me.BTNquit.Text = "Quit"
        Me.BTNquit.UseVisualStyleBackColor = True
        '
        'BTNstart
        '
        Me.BTNstart.Location = New System.Drawing.Point(303, 350)
        Me.BTNstart.Name = "BTNstart"
        Me.BTNstart.Size = New System.Drawing.Size(165, 88)
        Me.BTNstart.TabIndex = 7
        Me.BTNstart.Text = "Convert"
        Me.BTNstart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNstart)
        Me.Controls.Add(Me.BTNquit)
        Me.Controls.Add(Me.LBLoutput)
        Me.Controls.Add(Me.LBLtwo)
        Me.Controls.Add(Me.GBone)
        Me.Controls.Add(Me.TXTmoney)
        Me.Controls.Add(Me.LBLone)
        Me.Controls.Add(Me.LBLtitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBone.ResumeLayout(False)
        Me.GBone.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLtitle As Label
    Friend WithEvents LBLone As Label
    Friend WithEvents TXTmoney As TextBox
    Friend WithEvents GBone As GroupBox
    Friend WithEvents RBthree As RadioButton
    Friend WithEvents RBtwo As RadioButton
    Friend WithEvents RBone As RadioButton
    Friend WithEvents LBLtwo As Label
    Friend WithEvents LBLoutput As Label
    Friend WithEvents BTNquit As Button
    Friend WithEvents BTNstart As Button
End Class
