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
        Me.components = New System.ComponentModel.Container()
        Me.spinButton = New System.Windows.Forms.Button()
        Me.ReelControl1 = New SlotMachine.ReelControl()
        Me.ReelControl2 = New SlotMachine.ReelControl()
        Me.ReelControl3 = New SlotMachine.ReelControl()
        Me.r1Label = New System.Windows.Forms.Label()
        Me.r2Label = New System.Windows.Forms.Label()
        Me.r3Label = New System.Windows.Forms.Label()
        Me.DoButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'spinButton
        '
        Me.spinButton.Location = New System.Drawing.Point(123, 116)
        Me.spinButton.Name = "spinButton"
        Me.spinButton.Size = New System.Drawing.Size(94, 29)
        Me.spinButton.TabIndex = 0
        Me.spinButton.Text = "Spin"
        Me.spinButton.UseVisualStyleBackColor = True
        '
        'ReelControl1
        '
        Me.ReelControl1.itemValue = 0
        Me.ReelControl1.Location = New System.Drawing.Point(223, 89)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Size = New System.Drawing.Size(107, 102)
        Me.ReelControl1.spinTime = 2000
        Me.ReelControl1.TabIndex = 3
        '
        'ReelControl2
        '
        Me.ReelControl2.itemValue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(336, 89)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Size = New System.Drawing.Size(107, 102)
        Me.ReelControl2.spinTime = 2000
        Me.ReelControl2.TabIndex = 4
        '
        'ReelControl3
        '
        Me.ReelControl3.itemValue = 0
        Me.ReelControl3.Location = New System.Drawing.Point(449, 89)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Size = New System.Drawing.Size(107, 102)
        Me.ReelControl3.spinTime = 2000
        Me.ReelControl3.TabIndex = 5
        '
        'r1Label
        '
        Me.r1Label.AutoSize = True
        Me.r1Label.Location = New System.Drawing.Point(223, 219)
        Me.r1Label.Name = "r1Label"
        Me.r1Label.Size = New System.Drawing.Size(53, 20)
        Me.r1Label.TabIndex = 6
        Me.r1Label.Text = "Label1"
        '
        'r2Label
        '
        Me.r2Label.AutoSize = True
        Me.r2Label.Location = New System.Drawing.Point(336, 219)
        Me.r2Label.Name = "r2Label"
        Me.r2Label.Size = New System.Drawing.Size(53, 20)
        Me.r2Label.TabIndex = 7
        Me.r2Label.Text = "Label2"
        '
        'r3Label
        '
        Me.r3Label.AutoSize = True
        Me.r3Label.Location = New System.Drawing.Point(449, 219)
        Me.r3Label.Name = "r3Label"
        Me.r3Label.Size = New System.Drawing.Size(53, 20)
        Me.r3Label.TabIndex = 8
        Me.r3Label.Text = "Label3"
        '
        'DoButton
        '
        Me.DoButton.Location = New System.Drawing.Point(71, 296)
        Me.DoButton.Name = "DoButton"
        Me.DoButton.Size = New System.Drawing.Size(125, 29)
        Me.DoButton.TabIndex = 10
        Me.DoButton.Text = "Add 1 Dollar"
        Me.DoButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(71, 331)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(258, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DoButton)
        Me.Controls.Add(Me.r3Label)
        Me.Controls.Add(Me.r2Label)
        Me.Controls.Add(Me.r1Label)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.ReelControl1)
        Me.Controls.Add(Me.spinButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spinButton As Button
    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents r1Label As Label
    Friend WithEvents r2Label As Label
    Friend WithEvents r3Label As Label
    Friend WithEvents DoButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
