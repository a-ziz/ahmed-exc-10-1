<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.btnSelectPayment = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cboNames = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(336, 220)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(219, 220)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "&Save"
        '
        'lblPayment
        '
        Me.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPayment.Location = New System.Drawing.Point(16, 92)
        Me.lblPayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(267, 98)
        Me.lblPayment.TabIndex = 19
        '
        'btnSelectPayment
        '
        Me.btnSelectPayment.Location = New System.Drawing.Point(304, 92)
        Me.btnSelectPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectPayment.Name = "btnSelectPayment"
        Me.btnSelectPayment.Size = New System.Drawing.Size(139, 28)
        Me.btnSelectPayment.TabIndex = 18
        Me.btnSelectPayment.Text = "Select Payment"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 66)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(118, 17)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Payment method:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 17)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(111, 17)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Customer name:"
        '
        'cboNames
        '
        Me.cboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNames.FormattingEnabled = True
        Me.cboNames.Location = New System.Drawing.Point(176, 14)
        Me.cboNames.Margin = New System.Windows.Forms.Padding(4)
        Me.cboNames.Name = "cboNames"
        Me.cboNames.Size = New System.Drawing.Size(265, 24)
        Me.cboNames.TabIndex = 15
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(465, 266)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.btnSelectPayment)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cboNames)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents lblPayment As System.Windows.Forms.Label
    Private WithEvents btnSelectPayment As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cboNames As System.Windows.Forms.ComboBox

End Class
