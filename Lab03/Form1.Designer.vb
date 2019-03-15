<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.AverageUnitsShippedByEmployeeTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.txtEmployeeOne = New System.Windows.Forms.TextBox()
        Me.txtEmployeeTwo = New System.Windows.Forms.TextBox()
        Me.txtEmployeeThree = New System.Windows.Forms.TextBox()
        Me.lblAverageOne = New System.Windows.Forms.Label()
        Me.lblAverageTwo = New System.Windows.Forms.Label()
        Me.lblAverageThree = New System.Windows.Forms.Label()
        Me.lblDayAverage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployeeOne = New System.Windows.Forms.Label()
        Me.lblEmployeeTwo = New System.Windows.Forms.Label()
        Me.lblEmployeeThree = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDays
        '
        Me.lblDays.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDays.Location = New System.Drawing.Point(18, 18)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(77, 23)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "&Day 1"
        '
        'txtUserInput
        '
        Me.txtUserInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserInput.Location = New System.Drawing.Point(62, 44)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(77, 20)
        Me.txtUserInput.TabIndex = 2
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.txtUserInput, "Please enter the units")
        '
        'txtEmployeeOne
        '
        Me.txtEmployeeOne.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmployeeOne.Location = New System.Drawing.Point(21, 106)
        Me.txtEmployeeOne.Multiline = True
        Me.txtEmployeeOne.Name = "txtEmployeeOne"
        Me.txtEmployeeOne.ReadOnly = True
        Me.txtEmployeeOne.Size = New System.Drawing.Size(111, 111)
        Me.txtEmployeeOne.TabIndex = 6
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.txtEmployeeOne, "Units entered for Employee 1")
        '
        'txtEmployeeTwo
        '
        Me.txtEmployeeTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmployeeTwo.Location = New System.Drawing.Point(171, 106)
        Me.txtEmployeeTwo.Multiline = True
        Me.txtEmployeeTwo.Name = "txtEmployeeTwo"
        Me.txtEmployeeTwo.ReadOnly = True
        Me.txtEmployeeTwo.Size = New System.Drawing.Size(111, 111)
        Me.txtEmployeeTwo.TabIndex = 7
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.txtEmployeeTwo, "Units entered for Employee 2")
        '
        'txtEmployeeThree
        '
        Me.txtEmployeeThree.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmployeeThree.Location = New System.Drawing.Point(324, 106)
        Me.txtEmployeeThree.Multiline = True
        Me.txtEmployeeThree.Name = "txtEmployeeThree"
        Me.txtEmployeeThree.ReadOnly = True
        Me.txtEmployeeThree.Size = New System.Drawing.Size(111, 111)
        Me.txtEmployeeThree.TabIndex = 8
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.txtEmployeeThree, "Units entered for Employee 3")
        '
        'lblAverageOne
        '
        Me.lblAverageOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageOne.Location = New System.Drawing.Point(21, 226)
        Me.lblAverageOne.Name = "lblAverageOne"
        Me.lblAverageOne.Size = New System.Drawing.Size(111, 29)
        Me.lblAverageOne.TabIndex = 9
        Me.lblAverageOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblAverageOne, "Displays the average of Employee 1")
        '
        'lblAverageTwo
        '
        Me.lblAverageTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageTwo.Location = New System.Drawing.Point(171, 226)
        Me.lblAverageTwo.Name = "lblAverageTwo"
        Me.lblAverageTwo.Size = New System.Drawing.Size(111, 29)
        Me.lblAverageTwo.TabIndex = 10
        Me.lblAverageTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblAverageTwo, "Displays the average of Employee 2")
        '
        'lblAverageThree
        '
        Me.lblAverageThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageThree.Location = New System.Drawing.Point(324, 226)
        Me.lblAverageThree.Name = "lblAverageThree"
        Me.lblAverageThree.Size = New System.Drawing.Size(111, 29)
        Me.lblAverageThree.TabIndex = 11
        Me.lblAverageThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblAverageThree, "Displays the average of Employee 3")
        '
        'lblDayAverage
        '
        Me.lblDayAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDayAverage.Location = New System.Drawing.Point(21, 268)
        Me.lblDayAverage.Name = "lblDayAverage"
        Me.lblDayAverage.Size = New System.Drawing.Size(414, 25)
        Me.lblDayAverage.TabIndex = 12
        Me.lblDayAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblDayAverage, "Displays the average per day")
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(324, 299)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnExit, "Exits application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(171, 299)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(111, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnReset, "Resets the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(21, 299)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(111, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnEnter, "Enters the information")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnits.Location = New System.Drawing.Point(18, 47)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(77, 23)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        '
        'lblEmployeeOne
        '
        Me.lblEmployeeOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeOne.Location = New System.Drawing.Point(21, 80)
        Me.lblEmployeeOne.Name = "lblEmployeeOne"
        Me.lblEmployeeOne.Size = New System.Drawing.Size(111, 23)
        Me.lblEmployeeOne.TabIndex = 3
        Me.lblEmployeeOne.Text = "Employee 1"
        Me.lblEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeTwo
        '
        Me.lblEmployeeTwo.Location = New System.Drawing.Point(171, 80)
        Me.lblEmployeeTwo.Name = "lblEmployeeTwo"
        Me.lblEmployeeTwo.Size = New System.Drawing.Size(111, 23)
        Me.lblEmployeeTwo.TabIndex = 4
        Me.lblEmployeeTwo.Text = "Employee 2"
        Me.lblEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeThree
        '
        Me.lblEmployeeThree.Location = New System.Drawing.Point(324, 80)
        Me.lblEmployeeThree.Name = "lblEmployeeThree"
        Me.lblEmployeeThree.Size = New System.Drawing.Size(111, 23)
        Me.lblEmployeeThree.TabIndex = 5
        Me.lblEmployeeThree.Text = "Employee 3"
        Me.lblEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(456, 345)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblDayAverage)
        Me.Controls.Add(Me.lblAverageThree)
        Me.Controls.Add(Me.lblAverageTwo)
        Me.Controls.Add(Me.lblAverageOne)
        Me.Controls.Add(Me.txtEmployeeThree)
        Me.Controls.Add(Me.txtEmployeeTwo)
        Me.Controls.Add(Me.txtEmployeeOne)
        Me.Controls.Add(Me.lblEmployeeThree)
        Me.Controls.Add(Me.lblEmployeeTwo)
        Me.Controls.Add(Me.lblEmployeeOne)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDays)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDays As Label
    Friend WithEvents AverageUnitsShippedByEmployeeTips As ToolTip
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblEmployeeOne As Label
    Friend WithEvents lblEmployeeTwo As Label
    Friend WithEvents lblEmployeeThree As Label
    Friend WithEvents txtEmployeeOne As TextBox
    Friend WithEvents txtEmployeeTwo As TextBox
    Friend WithEvents txtEmployeeThree As TextBox
    Friend WithEvents lblAverageOne As Label
    Friend WithEvents lblAverageTwo As Label
    Friend WithEvents lblAverageThree As Label
    Friend WithEvents lblDayAverage As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
End Class
