Imports ITC124B_2022.Class1
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            DSRec.Clear()
            DSRec = GetDataTable("SELECT * FROM tblAccounts WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text +
                                 "' AND status = 'ACTIVE'")
            If DSRec.Rows.Count > 0 Then
                Dim main As New frmMain
                main.ToolStripStatusLabel1.Text = "Username:" + txtUsername.Text
                main.ToolStripStatusLabel2.Text = "Usertype:" + DSRec.Rows(0).Item("usertype").ToString
                loginuser = txtUsername.Text
                logintype = DSRec.Rows(0).Item("usertype").ToString
                main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect Account credentials or Account is inactive", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            MessageBox.Show("Error on the login button", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogin_Click(sender, e)
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Select()
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub


End Class
