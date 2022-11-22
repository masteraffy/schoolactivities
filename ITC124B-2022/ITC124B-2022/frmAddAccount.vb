Imports ITC124B_2022.Class1
Public Class frmAddAccount
    Dim errorCount As Integer
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            errorCount = 0
            ErrorProvider1.Clear()

            'error checking on each input
            If String.IsNullOrEmpty(txtUsername.Text) Then
                errorCount += 1
                ErrorProvider1.SetError(txtUsername, "Username is Required")
            End If

            If String.IsNullOrEmpty(txtPassword.Text) Then
                errorCount += 1
                ErrorProvider1.SetError(txtPassword, "Password is Required")
            End If

            If txtPassword.TextLength < 6 Then
                errorCount += 1
                ErrorProvider1.SetError(txtPassword, "Password must be 6 characters up!")
            End If

            If cmbUsertype.SelectedIndex < 0 Then
                errorCount += 1
                ErrorProvider1.SetError(cmbUsertype, "Usertype is Required")
            End If

            'verifying if the username of the new account exists on the accounts table

            DSRec.Clear()
            DSRec = GetDataTable("Select USERNAME from tblaccounts where USERNAME ='" + txtUsername.Text + "'")

            If DSRec.Rows.Count > 0 Then
                errorCount += 1
                ErrorProvider1.SetError(txtUsername, "Username is Already in Use!")
            End If


            'save if no error

            If errorCount = 0 Then
                executeSQL("INSERT INTO tblaccounts (USERNAME, PASSWORD, USERTYPE, STATUS, DATECREATED, TIMECREATED, CREATEDBY) VALUES ('" +
                           txtUsername.Text + "', '" + txtPassword.Text + "', '" + cmbUsertype.Text.ToUpper + "', 'ACTIVE', '" +
                           DateTime.Now.ToString("MM/dd/yyyy") + "', '" + DateTime.Now.ToLongTimeString + "', '" + loginuser + "')")

                If rowAffected > 0 Then
                    MessageBox.Show("New Account Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    frmAccounts.frmAccounts_Load(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error on adding new user", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub cmbUsertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsertype.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class