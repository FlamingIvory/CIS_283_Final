Public Class frmMain

    Dim dtbStudent As DataTable
    Dim studentRowNo As Integer

    '==========FUNCTIONS FOR SEARCH TAB==========
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim cnnDatabase As New OleDb.OleDbConnection
        Dim rdDatabase As OleDb.OleDbDataReader

        cnnDatabase.ConnectionString = "Provider=Microsoft.ACE.oleDB.12.0; Data Source=Login.accdb"

        ' prepares the SELECT query
        Dim TheSQL As String = "SELECT *" & _
                               "FROM Student " & _
                               "WHERE Student_SSN LIKE '%" & txtSearchSSN.Text & "%' AND " & _
                                    "Student_First LIKE '%" & txtSearchFirstName.Text & "%' AND " & _
                                    "Student_Last LIKE '%" & txtSearchLastName.Text & "%' AND " & _
                                    "Student_City LIKE '%" & txtSearchCity.Text & "%' AND " & _
                                    "Student_State LIKE '%" & txtSearchState.Text & "%';"
        Dim cmdSelect As OleDb.OleDbCommand = New OleDb.OleDbCommand(TheSQL, cnnDatabase)
        dtbStudent = New DataTable

        ' runs the SELECT query and stores the results in a data table
        cnnDatabase.Open()
        rdDatabase = cmdSelect.ExecuteReader()
        dtbStudent.Load(rdDatabase)
        rdDatabase.Close()
        cnnDatabase.Close()

        ' clears the results from any previous searches
        cboSelectResults.Items.Clear()
        cboSelectResults.Items.Add("-- Select Search Results --")
        cboSelectResults.SelectedIndex = 0

        ' populates the combo box with the search results
        Dim currentRow As Integer = 0
        Dim totalRows As Integer = dtbStudent.Rows.Count
        While currentRow < totalRows
            cboSelectResults.Items.Add(dtbStudent.Rows(currentRow)("Student_First") & _
                                       " " & dtbStudent.Rows(currentRow)("Student_Last"))
            currentRow = currentRow + 1
        End While
    End Sub

    Private Sub cboSelectResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectResults.SelectedIndexChanged
        Dim row As Integer = cboSelectResults.SelectedIndex - 1

        ' displays the data from the selected results
        If row < 0 = False Then
            txtResultSSN.Text = dtbStudent.Rows(row)("Student_SSN")
            txtResultFirstName.Text = dtbStudent.Rows(row)("Student_First")
            txtResultLastName.Text = dtbStudent.Rows(row)("Student_Last")
            txtResultPhoneNo.Text = dtbStudent.Rows(row)("Student_Phone")
            txtResultEmail.Text = dtbStudent.Rows(row)("Student_Email")
            txtResultAddress.Text = dtbStudent.Rows(row)("Student_Address") & ", " & _
                dtbStudent.Rows(row)("Student_City") & ", " & dtbStudent.Rows(row)("Student_State") & _
                " " & dtbStudent.Rows(row)("Student_Zip")

            studentRowNo = row
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtFirstName.Text = dtbStudent.Rows(studentRowNo)("Student_First")
        txtLastName.Text = dtbStudent.Rows(studentRowNo)("Student_Last")
        txtAddress.Text = dtbStudent.Rows(studentRowNo)("Student_Address")
        txtCity.Text = dtbStudent.Rows(studentRowNo)("Student_City")
        txtState.Text = dtbStudent.Rows(studentRowNo)("Student_State")
        txtZip.Text = dtbStudent.Rows(studentRowNo)("Student_Zip")
        txtPhone.Text = dtbStudent.Rows(studentRowNo)("Student_Phone")
        txtEmail.Text = dtbStudent.Rows(studentRowNo)("Student_Email")
        txtSSN.Text = dtbStudent.Rows(studentRowNo)("Student_SSN")

        TabControl1.SelectTab(1)
    End Sub

    '==========FUNCTIONS FOR EDIT TAB==========
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        frmLogin.Close()
    End Sub

    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click
        Dim theSQL As String
        Dim cnnDatabase As New OleDb.OleDbConnection
        Dim cmdUpdate As New OleDb.OleDbCommand

        cnnDatabase.ConnectionString = "Provider=Microsoft.ACE.oleDB.12.0; Data Source=Login.accdb"
        theSQL = "UPDATE Student SET Student_First = '" & txtFirstName.Text & "',Student_Last = '" & txtLastName.Text & "'," _
            & "Student_Address = '" & txtAddress.Text & "',Student_City = '" & txtCity.Text & "',Student_State = '" & txtState.Text & "'," _
            & "Student_Zip = '" & txtZip.Text & "', Student_Phone = '" & txtPhone.Text & "', Student_Email = '" & txtEmail.Text & "', Student_SSN = '" & txtSSN.Text & "'" _
            & " WHERE Student_OID = " & dtbStudent.Rows(studentRowNo)("Student_OID")

        cmdUpdate = New OleDb.OleDbCommand(theSQL, cnnDatabase)
        cnnDatabase.Open()
        cmdUpdate.ExecuteNonQuery()
        cnnDatabase.Close()

        MsgBox("The information was updated successfully", MsgBoxStyle.Information, "Success!")

    End Sub
End Class