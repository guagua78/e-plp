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
        Me.lblTitleVal = New System.Windows.Forms.Label()
        Me.lblCategoryHeader = New System.Windows.Forms.Label()
        Me.lblCategoryVal = New System.Windows.Forms.Label()
        Me.lblTypeHeader = New System.Windows.Forms.Label()
        Me.lblTypeVal = New System.Windows.Forms.Label()
        Me.lblDateHeader = New System.Windows.Forms.Label()
        Me.lblDateVal = New System.Windows.Forms.Label()
        Me.lblDescHeader = New System.Windows.Forms.Label()
        Me.txtDescriptionVal = New System.Windows.Forms.TextBox()
        Me.lblFileHeader = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.btnViewFile = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(296, 32)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Portfolio Entry Details"
        '
        'lblTitleHeader
        '
        Me.lblTitleHeader.AutoSize = True
        Me.lblTitleHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitleHeader.ForeColor = System.Drawing.Color.Gray
        Me.lblTitleHeader.Location = New System.Drawing.Point(22, 65)
        Me.lblTitleHeader.Name = "lblTitleHeader"
        Me.lblTitleHeader.Size = New System.Drawing.Size(193, 20)
        Me.lblTitleHeader.TabIndex = 1
        Me.lblTitleHeader.Text = "ACCOMPLISHMENT TITLE"
        '
        'lblTitleVal
        '
        Me.lblTitleVal.AutoSize = True
        Me.lblTitleVal.Font = New System.Drawing.Font("Segoe UI", 11.5!, System.Drawing.FontStyle.Bold)
        Me.lblTitleVal.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitleVal.Location = New System.Drawing.Point(22, 88)
        Me.lblTitleVal.Name = "lblTitleVal"
        Me.lblTitleVal.Size = New System.Drawing.Size(139, 28)
        Me.lblTitleVal.TabIndex = 2
        Me.lblTitleVal.Text = "Loading title..."
        '
        'lblCategoryHeader
        '
        Me.lblCategoryHeader.AutoSize = True
        Me.lblCategoryHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCategoryHeader.ForeColor = System.Drawing.Color.Gray
        Me.lblCategoryHeader.Location = New System.Drawing.Point(22, 130)
        Me.lblCategoryHeader.Name = "lblCategoryHeader"
        Me.lblCategoryHeader.Size = New System.Drawing.Size(155, 20)
        Me.lblCategoryHeader.TabIndex = 3
        Me.lblCategoryHeader.Text = "SKILL COMPETENCY"
        '
        'lblCategoryVal
        '
        Me.lblCategoryVal.AutoSize = True
        Me.lblCategoryVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCategoryVal.Location = New System.Drawing.Point(22, 153)
        Me.lblCategoryVal.Name = "lblCategoryVal"
        Me.lblCategoryVal.Size = New System.Drawing.Size(27, 23)
        Me.lblCategoryVal.TabIndex = 4
        Me.lblCategoryVal.Text = "---"
        '
        'lblTypeHeader
        '
        Me.lblTypeHeader.AutoSize = True
        Me.lblTypeHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTypeHeader.ForeColor = System.Drawing.Color.Gray
        Me.lblTypeHeader.Location = New System.Drawing.Point(280, 130)
        Me.lblTypeHeader.Name = "lblTypeHeader"
        Me.lblTypeHeader.Size = New System.Drawing.Size(116, 20)
        Me.lblTypeHeader.TabIndex = 5
        Me.lblTypeHeader.Text = "ACTIVITY TYPE"
        '
        'lblTypeVal
        '
        Me.lblTypeVal.AutoSize = True
        Me.lblTypeVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTypeVal.Location = New System.Drawing.Point(280, 153)
        Me.lblTypeVal.Name = "lblTypeVal"
        Me.lblTypeVal.Size = New System.Drawing.Size(27, 23)
        Me.lblTypeVal.TabIndex = 6
        Me.lblTypeVal.Text = "---"
        '
        'lblDateHeader
        '
        Me.lblDateHeader.AutoSize = True
        Me.lblDateHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDateHeader.ForeColor = System.Drawing.Color.Gray
        Me.lblDateHeader.Location = New System.Drawing.Point(22, 190)
        Me.lblDateHeader.Name = "lblDateHeader"
        Me.lblDateHeader.Size = New System.Drawing.Size(137, 20)
        Me.lblDateHeader.TabIndex = 7
        Me.lblDateHeader.Text = "DATE COMPLETED"
        '
        'lblDateVal
        '
        Me.lblDateVal.AutoSize = True
        Me.lblDateVal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblDateVal.Location = New System.Drawing.Point(22, 213)
        Me.lblDateVal.Name = "lblDateVal"
        Me.lblDateVal.Size = New System.Drawing.Size(27, 23)
        Me.lblDateVal.TabIndex = 8
        Me.lblDateVal.Text = "---"
        '
        'lblDescHeader
        '
        Me.lblDescHeader.AutoSize = True
        Me.lblDescHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescHeader.ForeColor = System.Drawing.Color.Gray
        Me.lblDescHeader.Location = New System.Drawing.Point(22, 250)
        Me.lblDescHeader.Name = "lblDescHeader"
        Me.lblDescHeader.Size = New System.Drawing.Size(176, 20)
        Me.lblDescHeader.TabIndex = 9
        Me.lblDescHeader.Text = "DESCRIPTION / DETAILS"
        '
        'txtDescriptionVal
        '
        Me.txtDescriptionVal.BackColor = System.Drawing.Color.White
        Me.txtDescriptionVal.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtDescriptionVal.Location = New System.Drawing.Point(25, 275)
        Me.txtDescriptionVal.Multiline = True
        Me.txtDescriptionVal.Name = "txtDescriptionVal"
        Me.txtDescriptionVal.ReadOnly = True
        Me.txtDescriptionVal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescriptionVal.Size = New System.Drawing.Size(510, 100)
        Me.txtDescriptionVal.TabIndex = 10
        '
        'lblFileHeader
        '
        Me.lblFileHeader.AutoSize = True
        Me.lblFileHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFileHeader.ForeColor = System.Drawing.Color.Gray
        Me.lblFileHeader.Location = New System.Drawing.Point(22, 390)
        Me.lblFileHeader.Name = "lblFileHeader"
        Me.lblFileHeader.Size = New System.Drawing.Size(199, 20)
        Me.lblFileHeader.TabIndex = 11
        Me.lblFileHeader.Text = "ATTACHED EVIDENCE FILE"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblFileName.Location = New System.Drawing.Point(22, 415)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(173, 20)
        Me.lblFileName.TabIndex = 12
        Me.lblFileName.Text = "Checking for attachment..."
        '
        'btnViewFile
        '
        Me.btnViewFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnViewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewFile.ForeColor = System.Drawing.Color.White
        Me.btnViewFile.Location = New System.Drawing.Point(25, 445)
        Me.btnViewFile.Name = "btnViewFile"
        Me.btnViewFile.Size = New System.Drawing.Size(160, 35)
        Me.btnViewFile.TabIndex = 13
        Me.btnViewFile.Text = "Open Attachment"
        Me.btnViewFile.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(425, 445)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 35)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmViewEntry
        '
        Me.ClientSize = New System.Drawing.Size(560, 505)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnViewFile)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.lblFileHeader)
        Me.Controls.Add(Me.txtDescriptionVal)
        Me.Controls.Add(Me.lblDescHeader)
        Me.Controls.Add(Me.lblDateVal)
        Me.Controls.Add(Me.lblDateHeader)
        Me.Controls.Add(Me.lblTypeVal)
        Me.Controls.Add(Me.lblTypeHeader)
        Me.Controls.Add(Me.lblCategoryVal)
        Me.Controls.Add(Me.lblCategoryHeader)
        Me.Controls.Add(Me.lblTitleVal)
        Me.Controls.Add(Me.lblTitleHeader)
        Me.Controls.Add(Me.lblFormTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Accomplishment Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblTitleHeader As System.Windows.Forms.Label
    Friend WithEvents lblTitleVal As System.Windows.Forms.Label
    Friend WithEvents lblCategoryHeader As System.Windows.Forms.Label
    Friend WithEvents lblCategoryVal As System.Windows.Forms.Label
    Friend WithEvents lblTypeHeader As System.Windows.Forms.Label
    Friend WithEvents lblTypeVal As System.Windows.Forms.Label
    Friend WithEvents lblDateHeader As System.Windows.Forms.Label
    Friend WithEvents lblDateVal As System.Windows.Forms.Label
    Friend WithEvents lblDescHeader As System.Windows.Forms.Label
    Friend WithEvents txtDescriptionVal As System.Windows.Forms.TextBox
    Friend WithEvents lblFileHeader As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents btnViewFile As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class