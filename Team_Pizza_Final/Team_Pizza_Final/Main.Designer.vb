<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabSearch = New System.Windows.Forms.TabPage()
        Me.grbSearchCriteria = New System.Windows.Forms.GroupBox()
        Me.txtSearchState = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtSearchCity = New System.Windows.Forms.TextBox()
        Me.lblSearchCity = New System.Windows.Forms.Label()
        Me.txtSearchSSN = New System.Windows.Forms.TextBox()
        Me.lblSearchStudentID = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearchFirstName = New System.Windows.Forms.TextBox()
        Me.lblSearchLastName = New System.Windows.Forms.Label()
        Me.lblSearchFirstName = New System.Windows.Forms.Label()
        Me.txtSearchLastName = New System.Windows.Forms.TextBox()
        Me.grbSearchResults = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtResultAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtResultEmail = New System.Windows.Forms.TextBox()
        Me.lblResultEmail = New System.Windows.Forms.Label()
        Me.txtResultPhoneNo = New System.Windows.Forms.TextBox()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.txtResultSSN = New System.Windows.Forms.TextBox()
        Me.cboSelectResults = New System.Windows.Forms.ComboBox()
        Me.lblResultSSN = New System.Windows.Forms.Label()
        Me.lblResultLastName = New System.Windows.Forms.Label()
        Me.lblResultFirstName = New System.Windows.Forms.Label()
        Me.txtResultLastName = New System.Windows.Forms.TextBox()
        Me.txtResultFirstName = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblDorm = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnEditSave = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cdlOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.lstImportedRecords = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        Me.grbSearchCriteria.SuspendLayout()
        Me.grbSearchResults.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This is the main form window"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(11, 326)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabSearch)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(326, 320)
        Me.TabControl1.TabIndex = 2
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.grbSearchCriteria)
        Me.tabSearch.Controls.Add(Me.grbSearchResults)
        Me.tabSearch.Location = New System.Drawing.Point(4, 22)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearch.Size = New System.Drawing.Size(318, 294)
        Me.tabSearch.TabIndex = 0
        Me.tabSearch.Text = "Search"
        Me.tabSearch.UseVisualStyleBackColor = True
        '
        'grbSearchCriteria
        '
        Me.grbSearchCriteria.Controls.Add(Me.txtSearchState)
        Me.grbSearchCriteria.Controls.Add(Me.lblState)
        Me.grbSearchCriteria.Controls.Add(Me.txtSearchCity)
        Me.grbSearchCriteria.Controls.Add(Me.lblSearchCity)
        Me.grbSearchCriteria.Controls.Add(Me.txtSearchSSN)
        Me.grbSearchCriteria.Controls.Add(Me.lblSearchStudentID)
        Me.grbSearchCriteria.Controls.Add(Me.btnSearch)
        Me.grbSearchCriteria.Controls.Add(Me.txtSearchFirstName)
        Me.grbSearchCriteria.Controls.Add(Me.lblSearchLastName)
        Me.grbSearchCriteria.Controls.Add(Me.lblSearchFirstName)
        Me.grbSearchCriteria.Controls.Add(Me.txtSearchLastName)
        Me.grbSearchCriteria.Location = New System.Drawing.Point(7, 0)
        Me.grbSearchCriteria.Name = "grbSearchCriteria"
        Me.grbSearchCriteria.Size = New System.Drawing.Size(305, 127)
        Me.grbSearchCriteria.TabIndex = 11
        Me.grbSearchCriteria.TabStop = False
        Me.grbSearchCriteria.Text = "Search Criteria"
        '
        'txtSearchState
        '
        Me.txtSearchState.Location = New System.Drawing.Point(219, 72)
        Me.txtSearchState.Name = "txtSearchState"
        Me.txtSearchState.Size = New System.Drawing.Size(75, 20)
        Me.txtSearchState.TabIndex = 9
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(178, 75)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "State:"
        '
        'txtSearchCity
        '
        Me.txtSearchCity.Location = New System.Drawing.Point(71, 72)
        Me.txtSearchCity.Name = "txtSearchCity"
        Me.txtSearchCity.Size = New System.Drawing.Size(75, 20)
        Me.txtSearchCity.TabIndex = 7
        '
        'lblSearchCity
        '
        Me.lblSearchCity.AutoSize = True
        Me.lblSearchCity.Location = New System.Drawing.Point(38, 75)
        Me.lblSearchCity.Name = "lblSearchCity"
        Me.lblSearchCity.Size = New System.Drawing.Size(27, 13)
        Me.lblSearchCity.TabIndex = 8
        Me.lblSearchCity.Text = "City:"
        '
        'txtSearchSSN
        '
        Me.txtSearchSSN.Location = New System.Drawing.Point(71, 20)
        Me.txtSearchSSN.Name = "txtSearchSSN"
        Me.txtSearchSSN.Size = New System.Drawing.Size(75, 20)
        Me.txtSearchSSN.TabIndex = 5
        '
        'lblSearchStudentID
        '
        Me.lblSearchStudentID.AutoSize = True
        Me.lblSearchStudentID.Location = New System.Drawing.Point(33, 23)
        Me.lblSearchStudentID.Name = "lblSearchStudentID"
        Me.lblSearchStudentID.Size = New System.Drawing.Size(32, 13)
        Me.lblSearchStudentID.TabIndex = 4
        Me.lblSearchStudentID.Text = "SSN:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(219, 98)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearchFirstName
        '
        Me.txtSearchFirstName.Location = New System.Drawing.Point(71, 46)
        Me.txtSearchFirstName.Name = "txtSearchFirstName"
        Me.txtSearchFirstName.Size = New System.Drawing.Size(75, 20)
        Me.txtSearchFirstName.TabIndex = 2
        '
        'lblSearchLastName
        '
        Me.lblSearchLastName.AutoSize = True
        Me.lblSearchLastName.Location = New System.Drawing.Point(152, 49)
        Me.lblSearchLastName.Name = "lblSearchLastName"
        Me.lblSearchLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblSearchLastName.TabIndex = 1
        Me.lblSearchLastName.Text = "Last Name:"
        '
        'lblSearchFirstName
        '
        Me.lblSearchFirstName.AutoSize = True
        Me.lblSearchFirstName.Location = New System.Drawing.Point(5, 49)
        Me.lblSearchFirstName.Name = "lblSearchFirstName"
        Me.lblSearchFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblSearchFirstName.TabIndex = 3
        Me.lblSearchFirstName.Text = "First Name:"
        '
        'txtSearchLastName
        '
        Me.txtSearchLastName.Location = New System.Drawing.Point(219, 46)
        Me.txtSearchLastName.Name = "txtSearchLastName"
        Me.txtSearchLastName.Size = New System.Drawing.Size(75, 20)
        Me.txtSearchLastName.TabIndex = 0
        '
        'grbSearchResults
        '
        Me.grbSearchResults.Controls.Add(Me.btnDelete)
        Me.grbSearchResults.Controls.Add(Me.btnEdit)
        Me.grbSearchResults.Controls.Add(Me.txtResultAddress)
        Me.grbSearchResults.Controls.Add(Me.lblAddress)
        Me.grbSearchResults.Controls.Add(Me.txtResultEmail)
        Me.grbSearchResults.Controls.Add(Me.lblResultEmail)
        Me.grbSearchResults.Controls.Add(Me.txtResultPhoneNo)
        Me.grbSearchResults.Controls.Add(Me.lblPhoneNo)
        Me.grbSearchResults.Controls.Add(Me.txtResultSSN)
        Me.grbSearchResults.Controls.Add(Me.cboSelectResults)
        Me.grbSearchResults.Controls.Add(Me.lblResultSSN)
        Me.grbSearchResults.Controls.Add(Me.lblResultLastName)
        Me.grbSearchResults.Controls.Add(Me.lblResultFirstName)
        Me.grbSearchResults.Controls.Add(Me.txtResultLastName)
        Me.grbSearchResults.Controls.Add(Me.txtResultFirstName)
        Me.grbSearchResults.Location = New System.Drawing.Point(6, 127)
        Me.grbSearchResults.Name = "grbSearchResults"
        Me.grbSearchResults.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbSearchResults.Size = New System.Drawing.Size(306, 161)
        Me.grbSearchResults.TabIndex = 10
        Me.grbSearchResults.TabStop = False
        Me.grbSearchResults.Text = "Search Results"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(8, 122)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 23)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(220, 122)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtResultAddress
        '
        Me.txtResultAddress.Location = New System.Drawing.Point(71, 97)
        Me.txtResultAddress.Name = "txtResultAddress"
        Me.txtResultAddress.ReadOnly = True
        Me.txtResultAddress.Size = New System.Drawing.Size(120, 20)
        Me.txtResultAddress.TabIndex = 20
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(17, 100)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 19
        Me.lblAddress.Text = "Address:"
        '
        'txtResultEmail
        '
        Me.txtResultEmail.Location = New System.Drawing.Point(221, 71)
        Me.txtResultEmail.Name = "txtResultEmail"
        Me.txtResultEmail.ReadOnly = True
        Me.txtResultEmail.Size = New System.Drawing.Size(75, 20)
        Me.txtResultEmail.TabIndex = 18
        '
        'lblResultEmail
        '
        Me.lblResultEmail.AutoSize = True
        Me.lblResultEmail.Location = New System.Drawing.Point(180, 74)
        Me.lblResultEmail.Name = "lblResultEmail"
        Me.lblResultEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblResultEmail.TabIndex = 17
        Me.lblResultEmail.Text = "Email:"
        '
        'txtResultPhoneNo
        '
        Me.txtResultPhoneNo.Location = New System.Drawing.Point(71, 71)
        Me.txtResultPhoneNo.Name = "txtResultPhoneNo"
        Me.txtResultPhoneNo.ReadOnly = True
        Me.txtResultPhoneNo.Size = New System.Drawing.Size(75, 20)
        Me.txtResultPhoneNo.TabIndex = 16
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Location = New System.Drawing.Point(4, 74)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(61, 13)
        Me.lblPhoneNo.TabIndex = 15
        Me.lblPhoneNo.Text = "Phone No.:"
        '
        'txtResultSSN
        '
        Me.txtResultSSN.Location = New System.Drawing.Point(71, 19)
        Me.txtResultSSN.Name = "txtResultSSN"
        Me.txtResultSSN.ReadOnly = True
        Me.txtResultSSN.Size = New System.Drawing.Size(75, 20)
        Me.txtResultSSN.TabIndex = 14
        '
        'cboSelectResults
        '
        Me.cboSelectResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectResults.Location = New System.Drawing.Point(157, 14)
        Me.cboSelectResults.Name = "cboSelectResults"
        Me.cboSelectResults.Size = New System.Drawing.Size(145, 21)
        Me.cboSelectResults.TabIndex = 7
        '
        'lblResultSSN
        '
        Me.lblResultSSN.AutoSize = True
        Me.lblResultSSN.Location = New System.Drawing.Point(33, 22)
        Me.lblResultSSN.Name = "lblResultSSN"
        Me.lblResultSSN.Size = New System.Drawing.Size(32, 13)
        Me.lblResultSSN.TabIndex = 13
        Me.lblResultSSN.Text = "SSN:"
        '
        'lblResultLastName
        '
        Me.lblResultLastName.AutoSize = True
        Me.lblResultLastName.Location = New System.Drawing.Point(154, 48)
        Me.lblResultLastName.Name = "lblResultLastName"
        Me.lblResultLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblResultLastName.TabIndex = 10
        Me.lblResultLastName.Text = "Last Name:"
        '
        'lblResultFirstName
        '
        Me.lblResultFirstName.AutoSize = True
        Me.lblResultFirstName.Location = New System.Drawing.Point(5, 48)
        Me.lblResultFirstName.Name = "lblResultFirstName"
        Me.lblResultFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblResultFirstName.TabIndex = 12
        Me.lblResultFirstName.Text = "First Name:"
        '
        'txtResultLastName
        '
        Me.txtResultLastName.Location = New System.Drawing.Point(221, 45)
        Me.txtResultLastName.Name = "txtResultLastName"
        Me.txtResultLastName.ReadOnly = True
        Me.txtResultLastName.Size = New System.Drawing.Size(75, 20)
        Me.txtResultLastName.TabIndex = 9
        '
        'txtResultFirstName
        '
        Me.txtResultFirstName.Location = New System.Drawing.Point(71, 45)
        Me.txtResultFirstName.Name = "txtResultFirstName"
        Me.txtResultFirstName.ReadOnly = True
        Me.txtResultFirstName.Size = New System.Drawing.Size(75, 20)
        Me.txtResultFirstName.TabIndex = 11
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btnAdd)
        Me.TabPage2.Controls.Add(Me.txtSSN)
        Me.TabPage2.Controls.Add(Me.txtPhone)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.txtZip)
        Me.TabPage2.Controls.Add(Me.lblDorm)
        Me.TabPage2.Controls.Add(Me.txtState)
        Me.TabPage2.Controls.Add(Me.lblMajor)
        Me.TabPage2.Controls.Add(Me.txtCity)
        Me.TabPage2.Controls.Add(Me.lblID)
        Me.TabPage2.Controls.Add(Me.lblLastName)
        Me.TabPage2.Controls.Add(Me.lblFirstName)
        Me.TabPage2.Controls.Add(Me.txtAddress)
        Me.TabPage2.Controls.Add(Me.txtLastName)
        Me.TabPage2.Controls.Add(Me.btnEditSave)
        Me.TabPage2.Controls.Add(Me.txtFirstName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(318, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.Location = New System.Drawing.Point(243, 210)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(69, 36)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add Student"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(101, 237)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(124, 20)
        Me.txtSSN.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(101, 185)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(124, 20)
        Me.txtPhone.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Zipcode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Phone #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "SSN"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(101, 211)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(124, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(101, 159)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(124, 20)
        Me.txtZip.TabIndex = 5
        '
        'lblDorm
        '
        Me.lblDorm.AutoSize = True
        Me.lblDorm.ForeColor = System.Drawing.Color.Black
        Me.lblDorm.Location = New System.Drawing.Point(27, 140)
        Me.lblDorm.Name = "lblDorm"
        Me.lblDorm.Size = New System.Drawing.Size(32, 13)
        Me.lblDorm.TabIndex = 12
        Me.lblDorm.Text = "State"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(101, 133)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(124, 20)
        Me.txtState.TabIndex = 4
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.ForeColor = System.Drawing.Color.Black
        Me.lblMajor.Location = New System.Drawing.Point(27, 114)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(24, 13)
        Me.lblMajor.TabIndex = 10
        Me.lblMajor.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(101, 107)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(124, 20)
        Me.txtCity.TabIndex = 3
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(27, 88)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(45, 13)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "Address"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.ForeColor = System.Drawing.Color.Black
        Me.lblLastName.Location = New System.Drawing.Point(27, 62)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.ForeColor = System.Drawing.Color.Black
        Me.lblFirstName.Location = New System.Drawing.Point(27, 36)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "First Name"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(101, 81)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(124, 20)
        Me.txtAddress.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(101, 55)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(124, 20)
        Me.txtLastName.TabIndex = 1
        '
        'btnEditSave
        '
        Me.btnEditSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnEditSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditSave.Enabled = False
        Me.btnEditSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditSave.Location = New System.Drawing.Point(243, 252)
        Me.btnEditSave.Name = "btnEditSave"
        Me.btnEditSave.Size = New System.Drawing.Size(69, 36)
        Me.btnEditSave.TabIndex = 1
        Me.btnEditSave.Text = "Save Changes"
        Me.btnEditSave.UseVisualStyleBackColor = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(101, 29)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(124, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lstImportedRecords)
        Me.TabPage3.Controls.Add(Me.btnUpdate)
        Me.TabPage3.Controls.Add(Me.btnOpen)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(318, 294)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "From File"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(237, 265)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(8, 265)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 91)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'cdlOpenFile
        '
        Me.cdlOpenFile.FileName = "OpenFileDialog1"
        '
        'lstImportedRecords
        '
        Me.lstImportedRecords.FormattingEnabled = True
        Me.lstImportedRecords.Location = New System.Drawing.Point(26, 117)
        Me.lstImportedRecords.Name = "lstImportedRecords"
        Me.lstImportedRecords.Size = New System.Drawing.Size(267, 134)
        Me.lstImportedRecords.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 361)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "ACME Student Registration System"
        Me.TabControl1.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        Me.grbSearchCriteria.ResumeLayout(False)
        Me.grbSearchCriteria.PerformLayout()
        Me.grbSearchResults.ResumeLayout(False)
        Me.grbSearchResults.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabSearch As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblDorm As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnEditSave As System.Windows.Forms.Button
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents grbSearchCriteria As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearchState As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtSearchCity As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchCity As System.Windows.Forms.Label
    Friend WithEvents txtSearchSSN As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchStudentID As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearchFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchLastName As System.Windows.Forms.Label
    Friend WithEvents lblSearchFirstName As System.Windows.Forms.Label
    Friend WithEvents txtSearchLastName As System.Windows.Forms.TextBox
    Friend WithEvents grbSearchResults As System.Windows.Forms.GroupBox
    Friend WithEvents txtResultAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtResultEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblResultEmail As System.Windows.Forms.Label
    Friend WithEvents txtResultPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents txtResultSSN As System.Windows.Forms.TextBox
    Friend WithEvents cboSelectResults As System.Windows.Forms.ComboBox
    Friend WithEvents lblResultSSN As System.Windows.Forms.Label
    Friend WithEvents lblResultLastName As System.Windows.Forms.Label
    Friend WithEvents lblResultFirstName As System.Windows.Forms.Label
    Friend WithEvents txtResultLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtResultFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtSSN As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cdlOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lstImportedRecords As System.Windows.Forms.ListBox
End Class
