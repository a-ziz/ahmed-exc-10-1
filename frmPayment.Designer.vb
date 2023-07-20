<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.grpBilling = New System.Windows.Forms.GroupBox()
        Me.rdoBillCustomer = New System.Windows.Forms.RadioButton()
        Me.rdoCreditCard = New System.Windows.Forms.RadioButton()
        Me.lblCreditCardType = New System.Windows.Forms.Label()
        Me.lstCreditCardType = New System.Windows.Forms.ListBox()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.lblExpirationDate = New System.Windows.Forms.Label()
        Me.cboExpirationMonth = New System.Windows.Forms.ComboBox()
        Me.cboExpirationYear = New System.Windows.Forms.ComboBox()
        Me.chkDefault = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpBilling.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBilling
        '
        Me.grpBilling.Controls.Add(Me.rdoBillCustomer)
        Me.grpBilling.Controls.Add(Me.rdoCreditCard)
        Me.grpBilling.Location = New System.Drawing.Point(33, 21)
        Me.grpBilling.Name = "grpBilling"
        Me.grpBilling.Size = New System.Drawing.Size(410, 73)
        Me.grpBilling.TabIndex = 0
        Me.grpBilling.TabStop = False
        Me.grpBilling.Text = "Billing"
        '
        'rdoBillCustomer
        '
        Me.rdoBillCustomer.AutoSize = True
        Me.rdoBillCustomer.Location = New System.Drawing.Point(242, 31)
        Me.rdoBillCustomer.Name = "rdoBillCustomer"
        Me.rdoBillCustomer.Size = New System.Drawing.Size(109, 21)
        Me.rdoBillCustomer.TabIndex = 1
        Me.rdoBillCustomer.TabStop = True
        Me.rdoBillCustomer.Text = "Bill customer"
        Me.rdoBillCustomer.UseVisualStyleBackColor = True
        '
        'rdoCreditCard
        '
        Me.rdoCreditCard.AutoSize = True
        Me.rdoCreditCard.Location = New System.Drawing.Point(23, 31)
        Me.rdoCreditCard.Name = "rdoCreditCard"
        Me.rdoCreditCard.Size = New System.Drawing.Size(98, 21)
        Me.rdoCreditCard.TabIndex = 0
        Me.rdoCreditCard.TabStop = True
        Me.rdoCreditCard.Text = "Credit card"
        Me.rdoCreditCard.UseVisualStyleBackColor = True
        '
        'lblCreditCardType
        '
        Me.lblCreditCardType.AutoSize = True
        Me.lblCreditCardType.Location = New System.Drawing.Point(33, 118)
        Me.lblCreditCardType.Name = "lblCreditCardType"
        Me.lblCreditCardType.Size = New System.Drawing.Size(112, 17)
        Me.lblCreditCardType.TabIndex = 1
        Me.lblCreditCardType.Text = "Credit card type:"
        '
        'lstCreditCardType
        '
        Me.lstCreditCardType.FormattingEnabled = True
        Me.lstCreditCardType.ItemHeight = 16
        Me.lstCreditCardType.Location = New System.Drawing.Point(167, 118)
        Me.lstCreditCardType.Name = "lstCreditCardType"
        Me.lstCreditCardType.Size = New System.Drawing.Size(276, 84)
        Me.lstCreditCardType.TabIndex = 2
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Location = New System.Drawing.Point(33, 229)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(94, 17)
        Me.lblCardNumber.TabIndex = 3
        Me.lblCardNumber.Text = "Card number:"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(167, 226)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(276, 22)
        Me.txtCardNumber.TabIndex = 4
        '
        'lblExpirationDate
        '
        Me.lblExpirationDate.AutoSize = True
        Me.lblExpirationDate.Location = New System.Drawing.Point(33, 269)
        Me.lblExpirationDate.Name = "lblExpirationDate"
        Me.lblExpirationDate.Size = New System.Drawing.Size(106, 17)
        Me.lblExpirationDate.TabIndex = 5
        Me.lblExpirationDate.Text = "Expiration date:"
        '
        'cboExpirationMonth
        '
        Me.cboExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExpirationMonth.FormattingEnabled = True
        Me.cboExpirationMonth.Location = New System.Drawing.Point(167, 266)
        Me.cboExpirationMonth.Name = "cboExpirationMonth"
        Me.cboExpirationMonth.Size = New System.Drawing.Size(129, 24)
        Me.cboExpirationMonth.TabIndex = 6
        '
        'cboExpirationYear
        '
        Me.cboExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExpirationYear.FormattingEnabled = True
        Me.cboExpirationYear.Location = New System.Drawing.Point(311, 266)
        Me.cboExpirationYear.Name = "cboExpirationYear"
        Me.cboExpirationYear.Size = New System.Drawing.Size(132, 24)
        Me.cboExpirationYear.TabIndex = 7
        '
        'chkDefault
        '
        Me.chkDefault.AutoSize = True
        Me.chkDefault.Checked = True
        Me.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDefault.Location = New System.Drawing.Point(36, 318)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(157, 21)
        Me.chkDefault.TabIndex = 8
        Me.chkDefault.Text = "Set as default billing"
        Me.chkDefault.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(252, 350)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(82, 29)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(364, 350)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 29)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmPayment
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(485, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.chkDefault)
        Me.Controls.Add(Me.cboExpirationYear)
        Me.Controls.Add(Me.cboExpirationMonth)
        Me.Controls.Add(Me.lblExpirationDate)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.lstCreditCardType)
        Me.Controls.Add(Me.lblCreditCardType)
        Me.Controls.Add(Me.grpBilling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.grpBilling.ResumeLayout(False)
        Me.grpBilling.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBilling As GroupBox
    Friend WithEvents rdoBillCustomer As RadioButton
    Friend WithEvents rdoCreditCard As RadioButton
    Friend WithEvents lblCreditCardType As Label
    Friend WithEvents lstCreditCardType As ListBox
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblExpirationDate As Label
    Friend WithEvents cboExpirationMonth As ComboBox
    Friend WithEvents cboExpirationYear As ComboBox
    Friend WithEvents chkDefault As CheckBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
End Class
