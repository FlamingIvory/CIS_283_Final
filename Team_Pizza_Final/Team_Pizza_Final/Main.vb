Public Class frmMain

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        frmLogin.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim theSQL As String
        Dim cnnDatabase As New OleDb.OleDbConnection
        Dim cmdSelect As New OleDb.OleDbCommand
        Dim cmdUpdate As New OleDb.OleDbCommand

        cnnDatabase.ConnectionString = "Provider=Microsoft.ACE.oleDB.12.0; Data Source=Login.accdb"
        theSQL = "Update Student Set Student_first = '" & txtFirstName.Text & "',Student_Last = '" & txtLastName.Text & "'," _
            & "Student_Address = '" & txtAddress.Text & "',Student City = '" & txtCity.Text & "',Student_State = '" & txtState.Text & "'," _
            & "Student_Zip = '" & txtZip.Text & "', Student_Phone = '" & mskPhone.Text & "', Student_Email = '" & txtEmail.Text & "', Student_SSN = '" & mskSSN.Text & "'" _
            & "Where Student_OID = 1"

        MsgBox("YOur student information has been changed.")

    End Sub
End Class