Public Class frmRegisterAdmin

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Data Validation
        If txtUser.Text = "" OrElse txtPassword.Text = "" Then
            lblWarning.Text = "Please fill out all fields to create your admin account"
            lblWarning.Visible = True
        Else
            Dim cnnDatabase As New OleDb.OleDbConnection
            Dim cmdInsert As OleDb.OleDbCommand
            Dim InsertCommand As String

            lblWarning.ForeColor = Color.Blue
            lblWarning.Text = "Accessing Database..."
            lblWarning.Visible = True

            cnnDatabase.ConnectionString = "Provider=Microsoft.ACE.oleDB.12.0; Data Source=Login.accdb"
            InsertCommand = "INSERT INTO Admin(User_ID, [Password]) Values('" & txtUser.Text & "','" & txtPassword.Text & "')"
            'MsgBox(InsertCommand)
            cmdInsert = New OleDb.OleDbCommand(InsertCommand, cnnDatabase)
            cnnDatabase.Open()
            cmdInsert.ExecuteNonQuery()
            cnnDatabase.Close()
            MsgBox("The user information was added succesfully.", MsgBoxStyle.Information, "Success!")
            Me.Close()
            frmValidateAdmin.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim response = MsgBox("Are you sure you want to cancel?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Warning")
        If response = MsgBoxResult.Yes Then
            Me.Close()
            frmValidateAdmin.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class