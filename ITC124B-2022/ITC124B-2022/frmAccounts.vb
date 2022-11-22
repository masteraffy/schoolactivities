Imports ITC124B_2022.Class1
Public Class frmAccounts
    Dim selectedUser As String = ""
    Dim selectedPassword As String = ""
    Dim selectedUsertype As String = ""
    Dim selectedStatus As String = ""
    Public Sub frmAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DSRec.Clear()
            DSRec = GetDataTable("SELECT * FROM tblaccounts ORDER BY USERNAME")
            DataGridView1.DataSource = DSRec
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(6).Visible = False
        Catch ex As Exception
            MessageBox.Show("Error on accounts load", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            DSRec.Clear()
            DSRec = GetDataTable("SELECT * FROM tblaccounts WHERE username LIKE '%" + txtSearch.Text +
                                 "%' OR usertype LIKE '%" + txtSearch.Text + "%' ORDER BY username")
            DataGridView1.DataSource = DSRec
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(6).Visible = False
        Catch ex As Exception
            MessageBox.Show("Error on accounts search", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim adduser As New frmAddAccount
        adduser.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            selectedUser = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            selectedPassword = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            selectedUsertype = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            selectedStatus = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("Error on datagrid cellclick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updateUser As New frmUpdateUser
        updateUser.txtUsername.Text = selectedUser
        updateUser.txtPassword.Text = selectedPassword
        If selectedUsertype = "ADMINISTRATOR" Then
            updateUser.cmbUsertype.SelectedIndex = 0
        ElseIf selectedUsertype = "TECHNICAL" Then
            updateUser.cmbUsertype.SelectedIndex = 1
        Else
            updateUser.cmbUsertype.SelectedIndex = 2
        End If

        If selectedStatus = "ACTIVE" Then
            updateUser.rbActive.Checked = True
        Else
            updateUser.rbInactive.Checked = True
        End If
        updateUser.txtUsername.Enabled = False
        updateUser.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to delete this account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = DialogResult.Yes Then
                executeSQL("DELETE FROM tblaccounts where USERNAME ='" + selectedUser + "'")
                If rowAffected > 0 Then
                    executeSQL("INSERT INTO tbldeleteLogs VALUES('" + DateTime.Now.ToShortDateString() + "', '" +
                               DateTime.Now.ToLongTimeString() + "', '" + selectedUser + "',  '" + loginuser + "', 'Accounts Management')")
                    MessageBox.Show("Accounts Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmAccounts_Load(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error on Delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class