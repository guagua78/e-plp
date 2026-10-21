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
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblActivityType = New System.Windows.Forms.Label()
        Me.cmbActivityType = New System.Windows.Forms.ComboBox()
        Me.lblDateCompleted = New System.Windows.Forms.Label()
        Me.dtpDateCompleted = New System.Windows.Forms.DateTimePicker()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblAttachment = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFormTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(280, 32)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Add Portfolio Entry"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(24, 68)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(182, 21)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Accomplishment Title *"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTitle.Location = New System.Drawing.Point(25, 95)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(530, 30)
        Me.txtTitle.TabIndex = 2
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.Location = New System.Drawing.Point(24, 138)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(155, 21)
        Me.lblCategory.TabIndex = 3
        Me.lblCategory.Text = "Skill Competency *"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(25, 165)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(250, 31)
        Me.cmbCategory.TabIndex = 4
        '
        'lblActivityType
        '
        Me.lblActivityType.AutoSize = True
        Me.lblActivityType.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblActivityType.Location = New System.Drawing.Point(300, 138)
        Me.lblActivityType.Name = "lblActivityType"
        Me.lblActivityType.Size = New System.Drawing.Size(120, 21)
        Me.lblActivityType.TabIndex = 5
        Me.lblActivityType.Text = "Activity Type *"
        '
        'cmbActivityType
        '
        Me.cmbActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActivityType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbActivityType.FormattingEnabled = True
        Me.cmbActivityType.Location = New System.Drawing.Point(305, 165)
        Me.cmbActivityType.Name = "cmbActivityType"
        Me.cmbActivityType.Size = New System.Drawing.Size(250, 31)
        Me.cmbActivityType.TabIndex = 6
        '
        'lblDateCompleted
        '
        Me.lblDateCompleted.AutoSize = True
        Me.lblDateCompleted.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblDateCompleted.Location = New System.Drawing.Point(24, 210)
        Me.lblDateCompleted.Name = "lblDateCompleted"
        Me.lblDateCompleted.Size = New System.Drawing.Size(142, 21)
        Me.lblDateCompleted.TabIndex = 7
        Me.lblDateCompleted.Text = "Date Completed *"
        '
        'dtpDateCompleted
        '
        Me.dtpDateCompleted.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpDateCompleted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateCompleted.Location = New System.Drawing.Point(25, 235)
        Me.dtpDateCompleted.Name = "dtpDateCompleted"
        Me.dtpDateCompleted.Size = New System.Drawing.Size(250, 30)
        Me.dtpDateCompleted.TabIndex = 8
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.Location = New System.Drawing.Point(24, 280)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(176, 21)
        Me.lblDescription.TabIndex = 9
        Me.lblDescription.Text = "Description / Details"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDescription.Location = New System.Drawing.Point(25, 305)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(530, 90)
        Me.txtDescription.TabIndex = 10
        '
        'lblAttachment
        '
        Me.lblAttachment.AutoSize = True
        Me.lblAttachment.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblAttachment.Location = New System.Drawing.Point(24, 410)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(200, 21)
        Me.lblAttachment.TabIndex = 11
        Me.lblAttachment.Text = "Proof / Evidence File"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.LightGray
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.Location = New System.Drawing.Point(25, 435)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(130, 32)
        Me.btnBrowse.TabIndex = 12
        Me.btnBrowse.Text = "Browse File..."
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblFilePath.ForeColor = System.Drawing.Color.DimGray
        Me.lblFilePath.Location = New System.Drawing.Point(165, 440)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(145, 20)
        Me.lblFilePath.TabIndex = 13
        Me.lblFilePath.Text = "No file attached yet"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(305, 495)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 40)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save Entry"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(435, 495)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 40)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmAddEntry
        '
        Me.ClientSize = New System.Drawing.Size(580, 560)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblAttachment)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.dtpDateCompleted)
        Me.Controls.Add(Me.lblDateCompleted)
        Me.Controls.Add(Me.cmbActivityType)
        Me.Controls.Add(Me.lblActivityType)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblFormTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log Accomplishment - Portfolioboxd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblActivityType As System.Windows.Forms.Label
    Friend WithEvents cmbActivityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateCompleted As System.Windows.Forms.Label
    Friend WithEvents dtpDateCompleted As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblAttachment As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class