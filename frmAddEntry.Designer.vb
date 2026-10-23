<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEntry
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFormHeader = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblActivityType = New System.Windows.Forms.Label()
        Me.cmbActivityType = New System.Windows.Forms.ComboBox()
        Me.lblCourseCode = New System.Windows.Forms.Label()
        Me.cmbCourseCode = New System.Windows.Forms.ComboBox()
        Me.lblDateCompleted = New System.Windows.Forms.Label()
        Me.dtpDateCompleted = New System.Windows.Forms.DateTimePicker()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblProofHeader = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFormHeader
        '
        Me.lblFormHeader.AutoSize = True
        Me.lblFormHeader.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFormHeader.Location = New System.Drawing.Point(18, 10)
        Me.lblFormHeader.Name = "lblFormHeader"
        Me.lblFormHeader.Size = New System.Drawing.Size(243, 35)
        Me.lblFormHeader.TabIndex = 0
        Me.lblFormHeader.Text = "Add Portfolio Entry"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(19, 58)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(173, 20)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Accomplishment Title *"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTitle.Location = New System.Drawing.Point(23, 82)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(718, 30)
        Me.txtTitle.TabIndex = 2
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(19, 123)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(139, 20)
        Me.lblCategory.TabIndex = 3
        Me.lblCategory.Text = "Skill Competency *"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(24, 146)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(254, 29)
        Me.cmbCategory.TabIndex = 4
        '
        'lblActivityType
        '
        Me.lblActivityType.AutoSize = True
        Me.lblActivityType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblActivityType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblActivityType.Location = New System.Drawing.Point(386, 123)
        Me.lblActivityType.Name = "lblActivityType"
        Me.lblActivityType.Size = New System.Drawing.Size(111, 20)
        Me.lblActivityType.TabIndex = 5
        Me.lblActivityType.Text = "Activity Type *"
        '
        'cmbActivityType
        '
        Me.cmbActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActivityType.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbActivityType.FormattingEnabled = True
        Me.cmbActivityType.Location = New System.Drawing.Point(390, 146)
        Me.cmbActivityType.Name = "cmbActivityType"
        Me.cmbActivityType.Size = New System.Drawing.Size(351, 29)
        Me.cmbActivityType.TabIndex = 6
        '
        'lblCourseCode
        '
        Me.lblCourseCode.AutoSize = True
        Me.lblCourseCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCourseCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblCourseCode.Location = New System.Drawing.Point(19, 188)
        Me.lblCourseCode.Name = "lblCourseCode"
        Me.lblCourseCode.Size = New System.Drawing.Size(199, 20)
        Me.lblCourseCode.TabIndex = 7
        Me.lblCourseCode.Text = "Academic Subject / Course:"
        '
        'cmbCourseCode
        '
        Me.cmbCourseCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourseCode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbCourseCode.FormattingEnabled = True
        Me.cmbCourseCode.Location = New System.Drawing.Point(23, 211)
        Me.cmbCourseCode.Name = "cmbCourseCode"
        Me.cmbCourseCode.Size = New System.Drawing.Size(525, 29)
        Me.cmbCourseCode.TabIndex = 8
        '
        'lblDateCompleted
        '
        Me.lblDateCompleted.AutoSize = True
        Me.lblDateCompleted.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDateCompleted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblDateCompleted.Location = New System.Drawing.Point(566, 188)
        Me.lblDateCompleted.Name = "lblDateCompleted"
        Me.lblDateCompleted.Size = New System.Drawing.Size(126, 20)
        Me.lblDateCompleted.TabIndex = 9
        Me.lblDateCompleted.Text = "Date Completed:"
        '
        'dtpDateCompleted
        '
        Me.dtpDateCompleted.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpDateCompleted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateCompleted.Location = New System.Drawing.Point(570, 211)
        Me.dtpDateCompleted.Name = "dtpDateCompleted"
        Me.dtpDateCompleted.Size = New System.Drawing.Size(171, 29)
        Me.dtpDateCompleted.TabIndex = 10
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(19, 253)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(152, 20)
        Me.lblDescription.TabIndex = 11
        Me.lblDescription.Text = "Description / Details"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtDescription.Location = New System.Drawing.Point(23, 276)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(721, 80)
        Me.txtDescription.TabIndex = 12
        '
        'lblProofHeader
        '
        Me.lblProofHeader.AutoSize = True
        Me.lblProofHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProofHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblProofHeader.Location = New System.Drawing.Point(19, 370)
        Me.lblProofHeader.Name = "lblProofHeader"
        Me.lblProofHeader.Size = New System.Drawing.Size(152, 20)
        Me.lblProofHeader.TabIndex = 13
        Me.lblProofHeader.Text = "Proof / Evidence File"
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBrowse.Location = New System.Drawing.Point(23, 393)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(213, 32)
        Me.btnBrowse.TabIndex = 14
        Me.btnBrowse.Text = "Browse File..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lblFilePath.ForeColor = System.Drawing.Color.Gray
        Me.lblFilePath.Location = New System.Drawing.Point(242, 400)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(134, 20)
        Me.lblFilePath.TabIndex = 15
        Me.lblFilePath.Text = "No file attached yet"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(361, 445)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(187, 38)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save Entry"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(570, 445)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(174, 38)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmAddEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 515)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblProofHeader)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.dtpDateCompleted)
        Me.Controls.Add(Me.lblDateCompleted)
        Me.Controls.Add(Me.cmbCourseCode)
        Me.Controls.Add(Me.lblCourseCode)
        Me.Controls.Add(Me.cmbActivityType)
        Me.Controls.Add(Me.lblActivityType)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblFormHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log Accomplishment - Portfolioboxd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormHeader As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblActivityType As System.Windows.Forms.Label
    Friend WithEvents cmbActivityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCourseCode As System.Windows.Forms.Label
    Friend WithEvents cmbCourseCode As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateCompleted As System.Windows.Forms.Label
    Friend WithEvents dtpDateCompleted As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblProofHeader As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class