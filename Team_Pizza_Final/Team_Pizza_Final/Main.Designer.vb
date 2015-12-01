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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.txtDorm = New System.Windows.Forms.TextBox()
        Me.lblDorm = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.btnQuit.Location = New System.Drawing.Point(235, 301)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(310, 295)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(302, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Navy
        Me.TabPage2.Controls.Add(Me.lblDorm)
        Me.TabPage2.Controls.Add(Me.txtDorm)
        Me.TabPage2.Controls.Add(Me.lblMajor)
        Me.TabPage2.Controls.Add(Me.txtMajor)
        Me.TabPage2.Controls.Add(Me.lblID)
        Me.TabPage2.Controls.Add(Me.lblLastName)
        Me.TabPage2.Controls.Add(Me.lblFirstName)
        Me.TabPage2.Controls.Add(Me.txtID)
        Me.TabPage2.Controls.Add(Me.txtLastName)
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Controls.Add(Me.txtFirstName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(302, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edit"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(93, 16)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(124, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Navy
        Me.btnSave.Location = New System.Drawing.Point(228, 227)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(69, 36)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(93, 42)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(124, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(93, 68)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(124, 20)
        Me.txtID.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.ForeColor = System.Drawing.Color.White
        Me.lblFirstName.Location = New System.Drawing.Point(19, 23)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(54, 13)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "FirstName"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.ForeColor = System.Drawing.Color.White
        Me.lblLastName.Location = New System.Drawing.Point(19, 49)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(19, 75)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(68, 13)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "Student ID #"
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(93, 94)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(124, 20)
        Me.txtMajor.TabIndex = 9
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.ForeColor = System.Drawing.Color.White
        Me.lblMajor.Location = New System.Drawing.Point(19, 101)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(33, 13)
        Me.lblMajor.TabIndex = 10
        Me.lblMajor.Text = "Major"
        '
        'txtDorm
        '
        Me.txtDorm.Location = New System.Drawing.Point(93, 120)
        Me.txtDorm.Name = "txtDorm"
        Me.txtDorm.Size = New System.Drawing.Size(124, 20)
        Me.txtDorm.TabIndex = 11
        '
        'lblDorm
        '
        Me.lblDorm.AutoSize = True
        Me.lblDorm.ForeColor = System.Drawing.Color.White
        Me.lblDorm.Location = New System.Drawing.Point(19, 127)
        Me.lblDorm.Name = "lblDorm"
        Me.lblDorm.Size = New System.Drawing.Size(72, 13)
        Me.lblDorm.TabIndex = 12
        Me.lblDorm.Text = "Dorm Building"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(302, 269)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(302, 269)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 336)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "ACME Student Registration System"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblDorm As System.Windows.Forms.Label
    Friend WithEvents txtDorm As System.Windows.Forms.TextBox
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
End Class
