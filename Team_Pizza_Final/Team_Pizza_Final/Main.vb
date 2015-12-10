Public Class frmMain

    Dim dtbStudent As DataTable 'Data table for the Search tab
    Dim studentRowNo As Integer 'Row counter for the Search tab
    Dim ImportedFileName As String 'File Name for From File tab
    Dim NumRecords As Integer 'Number of imported records for From File tab

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' Confirm exit message
        Dim Confirm As String = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Are you sure?")
        If Confirm = MsgBoxResult.No Then
            Exit Sub
        Else
            Me.Close()
            frmLogin.Close()
        End If
    End Sub


    '==========FUNCTIONS FOR SEARCH TAB==========
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Connect to the database
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
        ' Enable/Diable buttons for data validation
        btnAdd.Enabled = False
        btnEditSave.Enabled = True

        ' Move information from Search tab to Add/Edit tab
        txtFirstName.Text = dtbStudent.Rows(studentRowNo)("Student_First")
        txtLastName.Text = dtbStudent.Rows(studentRowNo)("Student_Last")
        txtAddress.Text = dtbStudent.Rows(studentRowNo)("Student_Address")
        txtCity.Text = dtbStudent.Rows(studentRowNo)("Student_City")
        txtState.Text = dtbStudent.Rows(studentRowNo)("Student_State")
        txtZip.Text = dtbStudent.Rows(studentRowNo)("Student_Zip")
        txtPhone.Text = dtbStudent.Rows(studentRowNo)("Student_Phone")
        txtEmail.Text = dtbStudent.Rows(studentRowNo)("Student_Email")
        txtSSN.Text = dtbStudent.Rows(studentRowNo)("Student_SSN")

        ' Go to Add/Edit Tab
        TabControl1.SelectTab(1)
    End Sub

    '==========FUNCTIONS FOR EDIT TAB==========
    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click
        ' Connect to the database
        Dim theSQL As String
        Dim cnnDatabase As New OleDb.OleDbConnection
        Dim cmdUpdate As New OleDb.OleDbCommand

        cnnDatabase.ConnectionString = "Provider=Microsoft.ACE.oleDB.12.0; Data Source=Login.accdb"

        ' Prepare the query
        theSQL = "UPDATE Student SET Student_First = '" & txtFirstName.Text & "',Student_Last = '" & txtLastName.Text & "'," _
            & "Student_Address = '" & txtAddress.Text & "',Student_City = '" & txtCity.Text & "',Student_State = '" & txtState.Text & "'," _
            & "Student_Zip = '" & txtZip.Text & "', Student_Phone = '" & txtPhone.Text & "', Student_Email = '" & txtEmail.Text & "', Student_SSN = '" & txtSSN.Text & "'" _
            & " WHERE Student_OID = " & dtbStudent.Rows(studentRowNo)("Student_OID")

        ' Execute the Query
        cmdUpdate = New OleDb.OleDbCommand(theSQL, cnnDatabase)
        cnnDatabase.Open()
        cmdUpdate.ExecuteNonQuery()
        cnnDatabase.Close()
        MsgBox("The information was updated successfully", MsgBoxStyle.Information, "Success!")

        ' Enable/Disable buttons
        btnEditSave.Enabled = False
        btnAdd.Enabled = True

        'Clear information
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtSSN.Clear()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Confirm delete action
        Dim Confirm As String = MsgBox("The following action will PERMANENTLY delete record from the database. Are you sure you want to proceed?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Delete Data?")
        If Confirm = MsgBoxResult.No Then
            Exit Sub
        Else
            ' Connect to the database
            Dim theSQL As String
            Dim cnnDatabase As New OleDb.OleDbConnection
            Dim cmdDelete As New OleDb.OleDbCommand

            cnnDatabase.ConnectionString = "Provider=Microsoft.ACE.oleDB.12.0; Data Source=Login.accdb"

            ' Prepare the query
            theSQL = "DELETE FROM Student WHERE Student_OID = " & dtbStudent.Rows(studentRowNo)("Student_OID")

            ' Execute the query
            cmdDelete = New OleDb.OleDbCommand(theSQL, cnnDatabase)
            cnnDatabase.Open()
            cmdDelete.ExecuteNonQuery()
            cnnDatabase.Close()
            MsgBox("The information was deleted successfully", MsgBoxStyle.Information, "Success!")
            ' Clear information
            txtResultSSN.Clear()
            txtResultFirstName.Clear()
            txtResultLastName.Clear()
            txtResultPhoneNo.Clear()
            txtResultAddress.Clear()
            txtResultEmail.Clear()
            cboSelectResults.Items.Clear()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Connect to the database
        Dim theSQL As String
        Dim cnnDatabase As New OleDb.OleDbConnection
        Dim cmdAdd As New OleDb.OleDbCommand

        cnnDatabase.ConnectionString = "Provider=Microsoft.ACE.oleDB.12.0; Data Source=Login.accdb"

        ' Prepare the query
        theSQL = "INSERT INTO Student(Student_First,Student_Last,Student_Address,Student_City,Student_State,Student_Zip,Student_Phone,Student_Email,Student_SSN) " _
            & "VALUES ('" & txtFirstName.Text & "', '" & txtLastName.Text & "', '" & txtAddress.Text & "', '" & txtCity.Text & "', '" & txtState.Text & "', '" _
            & txtZip.Text & "', '" & txtPhone.Text & "', '" & txtEmail.Text & "', '" & txtSSN.Text & "')"

        ' Execute the query
        cmdAdd = New OleDb.OleDbCommand(theSQL, cnnDatabase)
        cnnDatabase.Open()
        cmdAdd.ExecuteNonQuery()
        cnnDatabase.Close()
        MsgBox("The information was added successfully", MsgBoxStyle.Information, "Success!")

        ' Clear information
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtSSN.Clear()

    End Sub

    '==========FUNCTIONS FOR FROM FILE TAB==========
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim ImportFileName As String
        Dim FileFilter As String = "Text Files (*.txt)|*txt|All Files (*.*)|*.*"

        ' User selects the file
        ImportFileName = GetTheFileName(cdlOpenFile, "Please select a file to import", FileFilter)
        If ImportFileName = "" Then
            Exit Sub
        Else
            ImportedFileName = ImportFileName
            ListRecords()
        End If
    End Sub

    Private Function GetTheFileName(ByRef TheDialog As FileDialog, ByVal TheTitle As String, ByVal TheFilter As String) As String
        With TheDialog
            .Title = TheTitle
            .Filter = TheFilter
            If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Return ("")
            End If
            Return (.FileName)
        End With
    End Function

    Private Sub ListRecords()
        ' Open the filer eader
        Dim FileReader As System.IO.StreamReader
        FileReader = New System.IO.StreamReader(ImportedFileName)
        Dim CurrentRecord() As String
        Dim Counter As Integer = 0 ' Number of records found

        Do Until FileReader.Peek() = -1
            CurrentRecord = Split(FileReader.ReadLine(), ",") ' Get rid of commas
            lstImportedRecords.Items.Add(CurrentRecord(0) & " " & CurrentRecord(1) & ", " & CurrentRecord(2) & ", " & CurrentRecord(3) & ", " _
                                         & CurrentRecord(4) & ", " & CurrentRecord(5)) ' Populate the list box
            Counter += 1
        Loop
        NumRecords = Counter ' Set global variable
        FileReader.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Confirm update action
        Dim Confirm As String = MsgBox("The imported records will be added to the database. Are you sure you want to import the data?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Import Data?")
        If Confirm = MsgBoxResult.No Then
            Exit Sub
        Else
            If ImportedFileName = "" Then ' If no file has been selected yet...
                MsgBox("Please choose the file you want to import information from.", MsgBoxStyle.Information, "Error")
                Exit Sub
            End If
            Dim ImportedRecords(NumRecords - 1) As String ' Imported Records
            Dim FileReader As System.IO.StreamReader = New System.IO.StreamReader(ImportedFileName) ' File Reader
            Dim CurrentRecord() As String

            'Connect to the database
            Dim theSQL As String
            Dim cnnDatabase As New OleDb.OleDbConnection
            Dim cmdAdd As New OleDb.OleDbCommand
            cnnDatabase.ConnectionString = "Provider=Microsoft.ACE.oleDB.12.0; Data Source=Login.accdb"

            ' Add the records to the database
            Do Until FileReader.Peek() = -1
                CurrentRecord = Split(FileReader.ReadLine(), ",")

                ' Prepare query
                theSQL = "INSERT INTO Student(Student_First,Student_Last,Student_Address,Student_City,Student_State,Student_Zip,Student_Phone,Student_Email,Student_SSN) " _
                & "VALUES ('" & CurrentRecord(0) & "', '" & CurrentRecord(1) & "', '" & CurrentRecord(2) & "', '" & CurrentRecord(3) & "', '" & CurrentRecord(4) & "', '" _
                & CurrentRecord(5) & "', '" & CurrentRecord(6) & "', '" & CurrentRecord(7) & "', '" & CurrentRecord(8) & "')"

                ' Execute query
                cmdAdd = New OleDb.OleDbCommand(theSQL, cnnDatabase)
                cnnDatabase.Open()
                cmdAdd.ExecuteNonQuery()
                cnnDatabase.Close()
            Loop
            MsgBox("The information was added successfully", MsgBoxStyle.Information, "Success!")

            ' Clear information
            lstImportedRecords.Items.Clear()
        End If
    End Sub
End Class