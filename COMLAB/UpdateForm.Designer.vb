﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnUpdate = New ns1.BunifuThinButton2()
        Me.studentno = New System.Windows.Forms.Label()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtContactNo = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAddress = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMiddleInitial = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnBack = New ns1.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtYear = New MetroFramework.Controls.MetroComboBox()
        Me.txtCourse = New MetroFramework.Controls.MetroComboBox()
        Me.cmbUsertype = New MetroFramework.Controls.MetroComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(114, 513)
        Me.Panel1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(129, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 19)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Update Information"
        '
        'btnUpdate
        '
        Me.btnUpdate.ActiveBorderThickness = 2
        Me.btnUpdate.ActiveCornerRadius = 25
        Me.btnUpdate.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnUpdate.ActiveForecolor = System.Drawing.Color.White
        Me.btnUpdate.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.ButtonText = "Update"
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.IdleBorderThickness = 1
        Me.btnUpdate.IdleCornerRadius = 25
        Me.btnUpdate.IdleFillColor = System.Drawing.Color.White
        Me.btnUpdate.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(651, 443)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(138, 42)
        Me.btnUpdate.TabIndex = 83
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'studentno
        '
        Me.studentno.AutoSize = True
        Me.studentno.Location = New System.Drawing.Point(447, 26)
        Me.studentno.Name = "studentno"
        Me.studentno.Size = New System.Drawing.Size(54, 13)
        Me.studentno.TabIndex = 100
        Me.studentno.Text = "studentno"
        Me.studentno.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Depth = 0
        Me.txtPassword.Hint = ""
        Me.txtPassword.Location = New System.Drawing.Point(506, 322)
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(285, 23)
        Me.txtPassword.TabIndex = 118
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(502, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 21)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "Contact No"
        '
        'txtContactNo
        '
        Me.txtContactNo.Depth = 0
        Me.txtContactNo.Hint = ""
        Me.txtContactNo.Location = New System.Drawing.Point(506, 250)
        Me.txtContactNo.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactNo.SelectedText = ""
        Me.txtContactNo.SelectionLength = 0
        Me.txtContactNo.SelectionStart = 0
        Me.txtContactNo.Size = New System.Drawing.Size(285, 23)
        Me.txtContactNo.TabIndex = 116
        Me.txtContactNo.UseSystemPasswordChar = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(502, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 21)
        Me.Label14.TabIndex = 115
        Me.Label14.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Depth = 0
        Me.txtAddress.Hint = ""
        Me.txtAddress.Location = New System.Drawing.Point(506, 180)
        Me.txtAddress.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.Size = New System.Drawing.Size(285, 23)
        Me.txtAddress.TabIndex = 114
        Me.txtAddress.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(502, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 21)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Year"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(502, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 21)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(181, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(181, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 21)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Course"
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Depth = 0
        Me.txtMiddleInitial.Hint = ""
        Me.txtMiddleInitial.Location = New System.Drawing.Point(185, 322)
        Me.txtMiddleInitial.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddleInitial.SelectedText = ""
        Me.txtMiddleInitial.SelectionLength = 0
        Me.txtMiddleInitial.SelectionStart = 0
        Me.txtMiddleInitial.Size = New System.Drawing.Size(285, 23)
        Me.txtMiddleInitial.TabIndex = 107
        Me.txtMiddleInitial.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(181, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 21)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Middle Initial"
        '
        'txtLastName
        '
        Me.txtLastName.Depth = 0
        Me.txtLastName.Hint = ""
        Me.txtLastName.Location = New System.Drawing.Point(185, 250)
        Me.txtLastName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.SelectionLength = 0
        Me.txtLastName.SelectionStart = 0
        Me.txtLastName.Size = New System.Drawing.Size(285, 23)
        Me.txtLastName.TabIndex = 105
        Me.txtLastName.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(181, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Depth = 0
        Me.txtFirstName.Hint = ""
        Me.txtFirstName.Location = New System.Drawing.Point(184, 180)
        Me.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.SelectionLength = 0
        Me.txtFirstName.SelectionStart = 0
        Me.txtFirstName.Size = New System.Drawing.Size(285, 23)
        Me.txtFirstName.TabIndex = 103
        Me.txtFirstName.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(180, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "StudentID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Depth = 0
        Me.txtStudentID.Hint = ""
        Me.txtStudentID.Location = New System.Drawing.Point(184, 107)
        Me.txtStudentID.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.SelectionLength = 0
        Me.txtStudentID.SelectionStart = 0
        Me.txtStudentID.Size = New System.Drawing.Size(285, 23)
        Me.txtStudentID.TabIndex = 101
        Me.txtStudentID.UseSystemPasswordChar = False
        '
        'btnBack
        '
        Me.btnBack.ActiveBorderThickness = 2
        Me.btnBack.ActiveCornerRadius = 25
        Me.btnBack.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnBack.ActiveForecolor = System.Drawing.Color.White
        Me.btnBack.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.ButtonText = "Back"
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.IdleBorderThickness = 1
        Me.btnBack.IdleCornerRadius = 25
        Me.btnBack.IdleFillColor = System.Drawing.Color.White
        Me.btnBack.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnBack.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(506, 443)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(138, 42)
        Me.btnBack.TabIndex = 119
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(785, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(79, 47)
        Me.Panel2.TabIndex = 120
        '
        'txtYear
        '
        Me.txtYear.FormattingEnabled = True
        Me.txtYear.ItemHeight = 23
        Me.txtYear.Items.AddRange(New Object() {"", "1st", "2nd", "3rd", "4th"})
        Me.txtYear.Location = New System.Drawing.Point(503, 102)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(286, 29)
        Me.txtYear.TabIndex = 122
        Me.txtYear.UseSelectable = True
        '
        'txtCourse
        '
        Me.txtCourse.FormattingEnabled = True
        Me.txtCourse.ItemHeight = 23
        Me.txtCourse.Items.AddRange(New Object() {"", "BSIT", "BSCS", "BSEE", "BSCE", "BSME", "BSBA", "BSOA", "BSHRM", "BSA"})
        Me.txtCourse.Location = New System.Drawing.Point(185, 403)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(286, 29)
        Me.txtCourse.TabIndex = 121
        Me.txtCourse.UseSelectable = True
        '
        'cmbUsertype
        '
        Me.cmbUsertype.FormattingEnabled = True
        Me.cmbUsertype.ItemHeight = 23
        Me.cmbUsertype.Items.AddRange(New Object() {"", "ADMIN", "STUDENT"})
        Me.cmbUsertype.Location = New System.Drawing.Point(506, 401)
        Me.cmbUsertype.Name = "cmbUsertype"
        Me.cmbUsertype.Size = New System.Drawing.Size(286, 29)
        Me.cmbUsertype.TabIndex = 145
        Me.cmbUsertype.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(502, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 21)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "User Type"
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 511)
        Me.Controls.Add(Me.cmbUsertype)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMiddleInitial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.studentno)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "UpdateForm"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents btnUpdate As ns1.BunifuThinButton2
    Friend WithEvents studentno As System.Windows.Forms.Label
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMiddleInitial As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As MaterialSkin.Controls.MaterialSingleLineTextField
    Private WithEvents btnBack As ns1.BunifuThinButton2
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtYear As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtCourse As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbUsertype As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
