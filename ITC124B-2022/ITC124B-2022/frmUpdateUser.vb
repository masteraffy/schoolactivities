Imports ITC124B_2022.Class1
Public Class frmUpdateUser
    Dim errorCount As Integer = 0
    Dim status As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorCount = 0
        ErrorProvider1.Clear()

        If String.IsNullOrEmpty(txtPassword.Text) Then
            errorCount += 1
            ErrorProvider1.SetError(txtPassword, "Password is Required!")
        End If

        If txtPassword.TextLength < 6 Then
            errorCount += 1
            ErrorProvider1.SetError(txtPassword, "Password must be 6 characters up!")
        End If

        If cmbUsertype.SelectedIndex < 0 Then
            errorCount += 1
            ErrorProvider1.SetError(cmbUsertype, "Usertype is Required!")
        End If

        If errorCount = 0 Then
            If rbActive.Checked Then
                status = "ACTIVE"
            Else
                status = "INACTIVE"
            End If
        End If

        executeSQL("UPDATE tblaccounts SET PASSWORD = '" + txtPassword.Text + "', USERTYPE = '" + cmbUsertype.Text.ToUpper +
                   "', status ='" + status + "' WHERE USERNAME = '" + txtUsername.Text + "'")

        If rowAffected > 0 Then
            MessageBox.Show("Account Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            frmAccounts.frmAccounts_Load(sender, e)
        End If

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class