Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Data Validation
        If txtUser.Text = "" OrElse txtPassword.Text = "" Then
            lblWarning.Text = "Please fill out all fields to login"
            lblWarning.Visible = True
        Else
            Dim cnnDatabase As New OleDb.OleDbConnection
            Dim cmdSelect As New OleDb.OleDbCommand
            Dim rdDatabase As OleDb.OleDbDataReader
            Dim userFound As Boolean = False

            lblWarning.ForeColor = Color.Blue
            lblWarning.Text = "Accessing Database..."
            lblWarning.Visible = True

            cnnDatabase.ConnectionString = "Provider=Microsoft.ACE.oleDB.12.0; Data Source=Login.accdb"
            cmdSelect.Connection = cnnDatabase
            cmdSelect.CommandText = "Select User_ID, Password From Admin"
            cnnDatabase.Open()
            rdDatabase = cmdSelect.ExecuteReader()

            lblWarning.Text = "Checking user credentials..."
            Do While rdDatabase.Read
                If rdDatabase.GetString(0) = txtUser.Text And rdDatabase.GetString(1) = txtPassword.Text Then
                    userFound = True
                    Exit Do
                End If
            Loop

            If userFound = True Then
                rdDatabase.Close()
                cnnDatabase.Close()
                frmMain.Show()
                Me.Hide()
            Else
                lblWarning.ForeColor = Color.Red
                lblWarning.Text = "Username/Password Not Found. Please try again."
                rdDatabase.Close()
                cnnDatabase.Close()
            End If
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
