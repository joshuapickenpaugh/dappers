<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.rdoIllinois = New System.Windows.Forms.RadioButton()
        Me.rdoMichigan = New System.Windows.Forms.RadioButton()
        Me.rdoIndiana = New System.Windows.Forms.RadioButton()
        Me.rdoWisconsin = New System.Windows.Forms.RadioButton()
        Me.rdoOvernight = New System.Windows.Forms.RadioButton()
        Me.rdoTwoDay = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoWisconsin)
        Me.GroupBox1.Controls.Add(Me.rdoIndiana)
        Me.GroupBox1.Controls.Add(Me.rdoMichigan)
        Me.GroupBox1.Controls.Add(Me.rdoIllinois)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "State:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoNone)
        Me.GroupBox2.Controls.Add(Me.rdoTwoDay)
        Me.GroupBox2.Controls.Add(Me.rdoOvernight)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 68)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Shipping Options:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 166)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(95, 35)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(117, 166)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(52, 223)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(160, 23)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = " "
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdoIllinois
        '
        Me.rdoIllinois.AutoSize = True
        Me.rdoIllinois.Location = New System.Drawing.Point(6, 19)
        Me.rdoIllinois.Name = "rdoIllinois"
        Me.rdoIllinois.Size = New System.Drawing.Size(53, 17)
        Me.rdoIllinois.TabIndex = 0
        Me.rdoIllinois.TabStop = True
        Me.rdoIllinois.Text = "&Illinois"
        Me.rdoIllinois.UseVisualStyleBackColor = True
        '
        'rdoMichigan
        '
        Me.rdoMichigan.AutoSize = True
        Me.rdoMichigan.Location = New System.Drawing.Point(6, 42)
        Me.rdoMichigan.Name = "rdoMichigan"
        Me.rdoMichigan.Size = New System.Drawing.Size(68, 17)
        Me.rdoMichigan.TabIndex = 1
        Me.rdoMichigan.TabStop = True
        Me.rdoMichigan.Text = "&Michigan"
        Me.rdoMichigan.UseVisualStyleBackColor = True
        '
        'rdoIndiana
        '
        Me.rdoIndiana.AutoSize = True
        Me.rdoIndiana.Location = New System.Drawing.Point(102, 19)
        Me.rdoIndiana.Name = "rdoIndiana"
        Me.rdoIndiana.Size = New System.Drawing.Size(60, 17)
        Me.rdoIndiana.TabIndex = 2
        Me.rdoIndiana.TabStop = True
        Me.rdoIndiana.Text = "I&ndiana"
        Me.rdoIndiana.UseVisualStyleBackColor = True
        '
        'rdoWisconsin
        '
        Me.rdoWisconsin.AutoSize = True
        Me.rdoWisconsin.Location = New System.Drawing.Point(102, 42)
        Me.rdoWisconsin.Name = "rdoWisconsin"
        Me.rdoWisconsin.Size = New System.Drawing.Size(74, 17)
        Me.rdoWisconsin.TabIndex = 3
        Me.rdoWisconsin.TabStop = True
        Me.rdoWisconsin.Text = "&Wisconsin"
        Me.rdoWisconsin.UseVisualStyleBackColor = True
        '
        'rdoOvernight
        '
        Me.rdoOvernight.AutoSize = True
        Me.rdoOvernight.Location = New System.Drawing.Point(5, 42)
        Me.rdoOvernight.Name = "rdoOvernight"
        Me.rdoOvernight.Size = New System.Drawing.Size(71, 17)
        Me.rdoOvernight.TabIndex = 0
        Me.rdoOvernight.TabStop = True
        Me.rdoOvernight.Text = "&Overnight"
        Me.rdoOvernight.UseVisualStyleBackColor = True
        '
        'rdoTwoDay
        '
        Me.rdoTwoDay.AutoSize = True
        Me.rdoTwoDay.Location = New System.Drawing.Point(101, 42)
        Me.rdoTwoDay.Name = "rdoTwoDay"
        Me.rdoTwoDay.Size = New System.Drawing.Size(53, 17)
        Me.rdoTwoDay.TabIndex = 1
        Me.rdoTwoDay.TabStop = True
        Me.rdoTwoDay.Text = "&2 Day"
        Me.rdoTwoDay.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(5, 19)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 2
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "Non&e"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 261)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dappers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents rdoWisconsin As RadioButton
    Friend WithEvents rdoIndiana As RadioButton
    Friend WithEvents rdoMichigan As RadioButton
    Friend WithEvents rdoIllinois As RadioButton
    Friend WithEvents rdoTwoDay As RadioButton
    Friend WithEvents rdoOvernight As RadioButton
    Friend WithEvents rdoNone As RadioButton
End Class
