Imports System.ComponentModel

Public Class frmCustomer

    Dim isDataSaved As Boolean = True

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboNames.Items.Add("Mike Smith")
        cboNames.Items.Add("Nancy Jones")
        cboNames.Items.Add("Gary Miller")
        cboNames.SelectedIndex = 0

    End Sub

    Private Sub frmCustomer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If isDataSaved = False Then
            Dim button As DialogResult = MessageBox.Show(
                "The data is not saved." & vbCrLf & "Do you want to save this data?",
                "Unsaved Data",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            )
            If button = DialogResult.Yes Then
                Me.isDataSaved = True
            ElseIf button = DialogResult.Cancel Then
                e.Cancel = True
            Else
                'Do noting.
            End If
        End If
    End Sub

    Private Sub btnSelectPayment_Click(sender As Object, e As EventArgs) Handles btnSelectPayment.Click

        Dim paymentForm As New frmPayment
        Dim selectedButton As DialogResult = paymentForm.ShowDialog()

        If selectedButton = DialogResult.OK Then
            lblPayment.Text = CStr(paymentForm.Tag)
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If IsValidData() Then
            Me.isDataSaved = True
            Me.Close()
        End If

    End Sub

    Private Function IsValidData() As Boolean

        If cboNames.SelectedIndex = -1 Then
            MessageBox.Show("You must select a customer. ", "Entry Error")
            cboNames.Select()
            Return False
        End If

        If lblPayment.Text = "" Then
            MessageBox.Show("You must enter a payment. ", "Entry Error")
            Return False
        End If

        Return True

    End Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cbonames_selectedindexchanged(sender As Object, e As EventArgs) Handles cboNames.SelectedIndexChanged
        lblPayment.Text = ""
        Me.isDataSaved = False
    End Sub

End Class
