Public Class MyApplication
    Dim errorCount As Integer = 0
    Dim seatFare, tax, grossFare, totalFare As Double
    Dim classification As String = ""
    Public Function validation() As Boolean

        If cmbIn_seatCode.SelectedIndex < 0 Then
            errorProvider.SetError(cmbIn_seatCode, "Please Select A Value")
            errorCount += 1
        End If

        If String.IsNullOrEmpty(txtIn_seatNo.Text) Then
            errorProvider.SetError(txtIn_seatNo, "This cannot be Empty")
            errorCount += 1
        End If


        Return IIf(errorCount <= 0, True, False)
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Public Sub confirm()
        errorProvider.Clear()
        errorCount = 0
        grossFare = 0
        tax = 0
        totalFare = 0
        classification = ""


        If validation() = True Then

            Select Case cmbIn_seatCode.SelectedIndex
                Case 0
                    seatFare = 5000
                    classification = "SPECIAL"
                Case 1
                    seatFare = 7000
                    classification = "ECONOMY"
                Case 2
                    seatFare = 9000
                    classification = "FIRST CLASS"
                Case 3
                    seatFare = 15000
                    classification = "EXECUTIVE"
            End Select

            grossFare = seatFare * Convert.ToDouble(txtIn_seatNo.Text)

            If rbIn_OneWay.Checked = True Then
                grossFare *= 1
            ElseIf rbIn_TwoWay.Checked = True Then
                grossFare *= 2
            End If

            tax = grossFare * 0.12

            totalFare = grossFare + tax

            txtO_classification.Text = classification.ToString()
            txtO_grossFare.Text = grossFare.ToString()
            txtO_seatFare.Text = seatFare.ToString()
            txtO_tax.Text = tax.ToString()
            txtO_totalFare.Text = totalFare.ToString()

        End If
    End Sub

    Public Sub clear()
        cmbIn_seatCode.SelectedIndex = -1
        txtIn_seatNo.Clear()
        rbIn_OneWay.Checked = True
        txtO_grossFare.Clear()
        txtO_classification.Clear()
        txtO_seatFare.Clear()
        txtO_tax.Clear()
        txtO_totalFare.Clear()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        confirm()
    End Sub
End Class
