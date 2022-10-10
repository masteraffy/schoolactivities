Public Class Form1

    Private errorCount As Integer = 0
    Private sss = 0, tax = 0, pagibig = 0, philhealth = 0, gross_pay = 0, net_pay As Integer = 0
    Private message As String = ""

    Private Sub txtRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRate.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back Then
            errorProvider.SetError(txtRate, "Input must be numeric")
            e.Handled = True
            txtRate.Select()
        Else
            errorProvider.SetError(txtRate, "")
        End If
    End Sub

    Private Sub txtHrsWorked_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHrsWorked.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back Then
            errorProvider.SetError(txtHrsWorked, "Input must be numeric")
            e.Handled = True
            txtHrsWorked.Select()
        Else
            errorProvider.SetError(txtHrsWorked, "")
        End If
    End Sub

    Public Sub validateRate()

        If txtRate.Text = "" Then
            errorProvider.SetError(txtRate, "Input is empty")
        ElseIf Val(txtRate.Text) <= 1 Or Val(txtRate.Text) >= 5000 Then
            errorProvider.SetError(txtRate, "Input must be from 1 to 5000 only")
        Else
            errorProvider.SetError(txtRate, "")
        End If
    End Sub

    Public Sub validateHrsofWork()
        If txtHrsWorked.Text = "" Then
            errorProvider.SetError(txtHrsWorked, "Input is empty")
        ElseIf Val(txtHrsWorked.Text) <= 1 Or Val(txtHrsWorked.Text) >= 200 Then
            errorProvider.SetError(txtHrsWorked, "Input must be from 1 to 200 only")
        Else
            errorProvider.SetError(txtHrsWorked, "")
        End If
    End Sub

    Private Sub counteErrors()
        For Each c As Control In errorProvider.ContainerControl.Controls
            If errorProvider.GetError(c) <> "" Then
                errorCount += 1
            End If
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHrsWorked.Clear()
        txtRate.Clear()

        rbContractual.Checked = False
        rbPermanent.Checked = True

        cbSSS.Checked = False
        cbPagibig.Checked = False
        cbPhilhealth.Checked = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        errorProvider.Clear()
        errorCount = 0
        validateRate()
        validateHrsofWork()
        counteErrors()

        If errorCount = 0 Then

            message = ""
            sss = 0
            tax = 0
            pagibig = 0
            philhealth = 0
            gross_pay = 0
            net_pay = 0

            If rbContractual.Checked Then
                gross_pay = Val(txtRate.Text) * Val(txtHrsWorked.Text)
                tax = gross_pay * 0.12
            ElseIf rbPermanent.Checked Then
                gross_pay = Val(txtRate.Text) * Val(txtHrsWorked.Text)
                tax = gross_pay * 0.1
            End If

            message += vbCrLf + "Gross Pay: " + gross_pay.ToString()
            message += vbCrLf + "Tax: " + tax.ToString()

            If cbSSS.Checked Then
                sss = gross_pay * 0.1
                message += vbCrLf + "SSS : " + sss.ToString()
            End If

            If cbPagibig.Checked Then
                pagibig = gross_pay * 0.06
                message += vbCrLf + "Pagibig: " + pagibig.ToString()
            End If

            If cbPhilhealth.Checked Then
                philhealth = gross_pay * 0.06
                message += vbCrLf + "Philhealth: " + philhealth.ToString()
            End If

            net_pay = gross_pay - (sss + pagibig + philhealth + tax)
            message += vbCrLf + "Net Pay: " + net_pay.ToString()


            MessageBox.Show(message, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)



        End If


    End Sub
End Class
