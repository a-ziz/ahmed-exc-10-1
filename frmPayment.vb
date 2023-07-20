Imports System.ComponentModel

Public Class frmPayment
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstCreditCardType.Items.Add("Visa")
        lstCreditCardType.Items.Add("Mastercard")
        lstCreditCardType.Items.Add("American Express")
        lstCreditCardType.SelectedIndex = 0

        Dim months() As String = {"Select a Month...", "January", "February", "March", "April",
            "May", "June", "July", "August", "September", "October", "November", "December"}

        For Each month As String In months
            cboExpirationMonth.Items.Add(month)
        Next
        cboExpirationMonth.SelectedIndex = 0


        cboExpirationYear.Items.Add("Select a Year...")
        For i As Integer = DateTime.Today.Year To (DateTime.Today.Year + 20)
            cboExpirationYear.Items.Add(i)
        Next
        cboExpirationYear.SelectedIndex = 0

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If Me.IsValidData() Then
            Me.SaveData()
        End If

    End Sub

    Private Sub SaveData()

        Dim message As String
        If rdoCreditCard.Checked Then
            message = "Charge to credit card." & vbNewLine & vbNewLine
            message &= "Card type: " & vbTab & lstCreditCardType.Items(lstCreditCardType.SelectedIndex).ToString & vbNewLine
            message &= "Card number: " & vbTab & txtCardNumber.Text & vbNewLine
            message &= "Expiration date: " & vbTab & cboExpirationMonth.Text & "/" & cboExpirationYear.Text & vbNewLine
        Else
            message = "Bill customer. " & vbNewLine & vbNewLine
        End If

        If chkDefault.Checked Then
            message &= "Default billing: True"
        End If

        Me.Tag = message
        Me.DialogResult = DialogResult.OK

    End Sub

    Public Function IsValidData() As Boolean
        ' While Credit Card button is checked
        If rdoCreditCard.Checked Then
            If lstCreditCardType.SelectedIndex = -1 Then
                MessageBox.Show("You must select a credit card type.", "Entry Error")
                lstCreditCardType.Select()
                Return False
            End If
            If txtCardNumber.Text = "" Then
                MessageBox.Show("You must enter a credit card number.", "Entry Error")
                txtCardNumber.Select()
                Return False
            End If
            If cboExpirationMonth.SelectedIndex = 0 Then
                MessageBox.Show("You must select a month.", "Entry Error")
                cboExpirationMonth.Select()
                Return False
            End If
            If cboExpirationYear.SelectedIndex = 0 Then
                MessageBox.Show("You must select a year.", "Entry Error")
                cboExpirationYear.Select()
                Return False
            End If

        End If
        'return True if validation is passed
        Return True
    End Function

    Private Sub BillingChecked(sender As Object, e As EventArgs) _
            Handles rdoCreditCard.CheckedChanged, rdoBillCustomer.CheckedChanged
        ' only enables the items if credit card is checked, disabled when billing is checked  
        If rdoCreditCard.Checked Then
            Me.EnableControls()
        Else
            Me.DisableControls()
        End If

    End Sub

    Private Sub EnableControls()
        lstCreditCardType.Enabled = True
        txtCardNumber.Enabled = True
        cboExpirationMonth.Enabled = True
        cboExpirationYear.Enabled = True
    End Sub

    Private Sub DisableControls()
        lstCreditCardType.Enabled = False
        txtCardNumber.Enabled = False
        cboExpirationMonth.Enabled = False
        cboExpirationYear.Enabled = False
    End Sub

End Class