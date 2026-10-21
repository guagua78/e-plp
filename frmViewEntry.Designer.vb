<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewEntry
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
        Me.lblTitleHeader = New System.Windows.Forms.Label()
        Me.txtTitleVal = New System.Windows.Forms.TextBox()
        Me.lblCategoryHeader = New System.Windows.Forms.Label()
        Me.cmbCategoryVal = New System.Windows.Forms.ComboBox()
        Me.lblTypeHeader = New System.Windows.Forms.Label()
        Me.cmbTypeVal = New System.Windows.Forms.ComboBox()
        Me.lblDateHeader = New System.Windows.Forms.Label()
        Me.dtpDateVal = New System.Windows.Forms.DateTimePicker()
        Me.lblDescHeader = New System.Windows.Forms.Label()
        Me.txtDescriptionVal = New System.Windows.Forms.TextBox()
        Me.lblFileHeader = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.btnViewFile = New System.Windows.Forms.Button()
        Me.btnChangeFile = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(325, 30)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Manage Accomplishment Details"
        '
        'lblTitleHeader
        '
        Me.lblTitleHeader.AutoSize = True
        Me.lblTitleHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTitleHeader.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitleHeader.Location = New System.Drawing.Point(22, 60)
        Me.lblTitleHeader.Name = "lblTitleHeader"
        Me.lblTitleHeader.Size = New System.Drawing.Size(188, 19)
        Me.lblTitleHeader.TabIndex = 1
        Me.lblTitleHeader.Text = "ACCOMPLISHMENT TITLE *"
        '
        'txtTitleVal
        '
        Me.txtTitleVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtTitleVal.Location = New System.Drawing.Point(25, 82)
        Me.txtTitleVal.Name = "txtTitleVal"
        Me.txtTitleVal.Size = New System.Drawing.Size(510, 29)
        Me.txtTitleVal.TabIndex = 2
        '
        'lblCategoryHeader
        '
        Me.lblCategoryHeader.AutoSize = True
        Me.lblCategoryHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblCategoryHeader.ForeColor = System.Drawing.Color.DimGray
        Me.lblCategoryHeader.Location = New System.Drawing.Point(22, 122)
        Me.lblCategoryHeader.Name = "lblCategoryHeader"
        Me.lblCategoryHeader.Size = Me.lblCategoryHeader.Size
        Me.lblCategoryHeader.TabIndex = 3
        Me.lblCategoryHeader.Text = "SKILL COMPETENCY *"
        '
        'cmbCategoryVal
        '
        Me.cmbCategoryVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoryVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbCategoryVal.FormattingEnabled = True
        Me.cmbCategoryVal.Location = New System.Drawing.Point(25, 144)
        Me.cmbCategoryVal.Name = "cmbCategoryVal"
        Me.cmbCategoryVal.Size = New System.Drawing.Size(240, 29)
        Me.cmbCategoryVal.TabIndex = 4
        '
        'lblTypeHeader
        '
        Me.lblTypeHeader.AutoSize = True
        Me.lblTypeHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTypeHeader.ForeColor = System.Drawing.Color.DimGray
        Me.lblTypeHeader.Location = New System.Drawing.Point(282, 122)
        Me.lblTypeHeader.Name = "lblTypeHeader"
        Me.lblTypeHeader.Size = New System.Drawing.Size(117, 19)
        Me.lblTypeHeader.TabIndex = 5
        Me.lblTypeHeader.Text = "ACTIVITY TYPE *"
        '
        'cmbTypeVal
        '
        Me.cmbTypeVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbTypeVal.FormattingEnabled = True
        Me.cmbTypeVal.Location = New System.Drawing.Point(285, 144)
        Me.cmbTypeVal.Name = "cmbTypeVal"
        Me.cmbTypeVal.Size = New System.Drawing.Size(250, 29)
        Me.cmbTypeVal.TabIndex = 6
        '
        'lblDateHeader
        '
        Me.lblDateHeader.AutoSize = True
        Me.lblDateHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDateHeader.ForeColor = System.Drawing.Color.DimGray
        Me.lblDateHeader.Location = New System.Drawing.Point(22, 185)
        Me.lblDateHeader.Name = "lblDateHeader"
        Me.lblDateHeader.Size = New System.Drawing.Size(139, 19)
        Me.lblDateHeader.TabIndex = 7
        Me.lblDateHeader.Text = "DATE COMPLETED *"
        '
        'dtpDateVal
        '
        Me.dtpDateVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpDateVal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateVal.Location = New System.Drawing.Point(25, 207)
        Me.dtpDateVal.Name = "dtpDateVal"
        Me.dtpDateVal.Size = New System.Drawing.Size(240, 29)
        Me.dtpDateVal.TabIndex = 8
        '
        'lblDescHeader
        '
        Me.lblDescHeader.AutoSize = True
        Me.lblDescHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDescHeader.ForeColor = System.Drawing.Color.DimGray
        Me.lblDescHeader.Location = New System.Drawing.Point(22, 248)
        Me.lblDescHeader.Name = "lblDescHeader"
        Me.lblDescHeader.Size = New System.Drawing.Size(175, 19)
        Me.lblDescHeader.TabIndex = 9
        Me.lblDescHeader.Text = "DESCRIPTION / DETAILS"
        '
        'txtDescriptionVal
        '
        Me.txtDescriptionVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtDescriptionVal.Location = New System.Drawing.Point(25, 270)
        Me.txtDescriptionVal.Multiline = True
        Me.txtDescriptionVal.Name = "txtDescriptionVal"
        Me.txtDescriptionVal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescriptionVal.Size = New System.Drawing.Size(510, 85)
        Me.txtDescriptionVal.TabIndex = 10
        '
        'lblFileHeader
        '
        Me.lblFileHeader.AutoSize = True
        Me.lblFileHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblFileHeader.ForeColor = System.Drawing.Color.DimGray
        Me.lblFileHeader.Location = New System.Drawing.Point(22, 368)
        Me.lblFileHeader.Name = "lblFileHeader"
        Me.lblFileHeader.Size = Me.lblFileHeader.Size
        Me.lblFileHeader.TabIndex = 11
        Me.lblFileHeader.Text = "ATTACHED EVIDENCE FILE"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblFileName.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblFileName.Location = New System.Drawing.Point(22, 392)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(173, 20)
        Me.lblFileName.TabIndex = 12
        Me.lblFileName.Text = "Checking for attachment..."
        '
        'btnViewFile
        '
        Me.btnViewFile.BackColor = System.Drawing.Color.LightGray
        Me.btnViewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewFile.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnViewFile.Location = New System.Drawing.Point(25, 418)
        Me.btnViewFile.Name = "btnViewFile"
        Me.btnViewFile.Size = New System.Drawing.Size(140, 32)
        Me.btnViewFile.TabIndex = 13
        Me.btnViewFile.Text = "Open Attachment"
        Me.btnViewFile.UseVisualStyleBackColor = False
        '
        'btnChangeFile
        '
        Me.btnChangeFile.BackColor = System.Drawing.Color.LightGray
        Me.btnChangeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeFile.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnChangeFile.Location = New System.Drawing.Point(175, 418)
        Me.btnChangeFile.Name = "btnChangeFile"
        Me.btnChangeFile.Size = New System.Drawing.Size(140, 32)
        Me.btnChangeFile.TabIndex = 14
        Me.btnChangeFile.Text = "Replace File..."
        Me.btnChangeFile.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(225, 475)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 38)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(355, 475)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 38)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(455, 475)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 38)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmViewEntry
        '
        Me.ClientSize = New System.Drawing.Size(560, 530)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnChangeFile)
        Me.Controls.Add(Me.btnViewFile)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.lblFileHeader)
        Me.Controls.Add(Me.txtDescriptionVal)
        Me.Controls.Add(Me.lblDescHeader)
        Me.Controls.Add(Me.dtpDateVal)
        Me.Controls.Add(Me.lblDateHeader)
        Me.Controls.Add(Me.cmbTypeVal)
        Me.Controls.Add(Me.lblTypeHeader)
        Me.Controls.Add(Me.cmbCategoryVal)
        Me.Controls.Add(Me.lblCategoryHeader)
        Me.Controls.Add(Me.txtTitleVal)
        Me.Controls.Add(Me.lblTitleHeader)
        Me.Controls.Add(Me.lblFormTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Accomplishment Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblTitleHeader As System.Windows.Forms.Label
    Friend WithEvents txtTitleVal As System.Windows.Forms.TextBox
    Friend WithEvents lblCategoryHeader As System.Windows.Forms.Label
    Friend WithEvents cmbCategoryVal As System.Windows.Forms.ComboBox
    Friend WithEvents lblTypeHeader As System.Windows.Forms.Label
    Friend WithEvents cmbTypeVal As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateHeader As System.Windows.Forms.Label
    Friend WithEvents dtpDateVal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDescHeader As System.Windows.Forms.Label
    Friend WithEvents txtDescriptionVal As System.Windows.Forms.TextBox
    Friend WithEvents lblFileHeader As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents btnViewFile As System.Windows.Forms.Button
    Friend WithEvents btnChangeFile As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class