Imports ITC124B_2022.Class1
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If logintype = "ADMINISTRATOR" Then
            AccountsToolStripMenuItem.Visible = True
            EquipmentToolStripMenuItem.Visible = True
        Else
            AccountsToolStripMenuItem.Visible = False
            EquipmentToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click
        Dim accountsfrm As New frmAccounts
        accountsfrm.MdiParent = Me
        accountsfrm.Show()
    End Sub
End Class