<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInfo
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lvwCarList = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNewStatus = New System.Windows.Forms.Label()
        Me.chkBoxNew = New System.Windows.Forms.CheckBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.ttpCarInventorTips = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(78, 405)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(82, 34)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ttpCarInventorTips.SetToolTip(Me.btnEnter, "Enter button to add the entry")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(264, 405)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(82, 34)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ttpCarInventorTips.SetToolTip(Me.btnReset, "Reset button to reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(450, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 34)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.ttpCarInventorTips.SetToolTip(Me.btnExit, "Exit button to exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lvwCarList
        '
        Me.lvwCarList.CheckBoxes = True
        Me.lvwCarList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCarList.FullRowSelect = True
        Me.lvwCarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCarList.HideSelection = False
        Me.lvwCarList.Location = New System.Drawing.Point(12, 165)
        Me.lvwCarList.MultiSelect = False
        Me.lvwCarList.Name = "lvwCarList"
        Me.lvwCarList.Size = New System.Drawing.Size(587, 171)
        Me.lvwCarList.TabIndex = 10
        Me.lvwCarList.UseCompatibleStateImageBehavior = False
        Me.lvwCarList.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New?"
        '
        'colId
        '
        Me.colId.Text = "ID"
        Me.colId.Width = 50
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 100
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 70
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 80
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 100
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(12, 339)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(587, 58)
        Me.lblMessage.TabIndex = 11
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(194, 11)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(54, 22)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make :"
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Volkswagen", "Hyundai", "Honda", "BMW", "Mercedes", "Jaguar", "Hero", "GMC"})
        Me.cmbMake.Location = New System.Drawing.Point(280, 7)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(120, 24)
        Me.cmbMake.TabIndex = 1
        Me.ttpCarInventorTips.SetToolTip(Me.cmbMake, "Enter the maker of Car")
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(194, 40)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(54, 17)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel :"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(194, 76)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(46, 17)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year :"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(194, 107)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(48, 17)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price :"
        '
        'lblNewStatus
        '
        Me.lblNewStatus.AutoSize = True
        Me.lblNewStatus.Location = New System.Drawing.Point(194, 142)
        Me.lblNewStatus.Name = "lblNewStatus"
        Me.lblNewStatus.Size = New System.Drawing.Size(43, 17)
        Me.lblNewStatus.TabIndex = 8
        Me.lblNewStatus.Text = "&New :"
        '
        'chkBoxNew
        '
        Me.chkBoxNew.AutoSize = True
        Me.chkBoxNew.Location = New System.Drawing.Point(280, 142)
        Me.chkBoxNew.Name = "chkBoxNew"
        Me.chkBoxNew.Size = New System.Drawing.Size(18, 17)
        Me.chkBoxNew.TabIndex = 9
        Me.ttpCarInventorTips.SetToolTip(Me.chkBoxNew, "Check the box if car is New")
        Me.chkBoxNew.UseVisualStyleBackColor = True
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(280, 37)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(120, 22)
        Me.txtModel.TabIndex = 3
        Me.ttpCarInventorTips.SetToolTip(Me.txtModel, "Enter the model of Car")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(280, 104)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(120, 22)
        Me.txtPrice.TabIndex = 7
        Me.ttpCarInventorTips.SetToolTip(Me.txtPrice, "Enter the price of Car")
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(280, 73)
        Me.nudYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(120, 22)
        Me.nudYear.TabIndex = 5
        Me.ttpCarInventorTips.SetToolTip(Me.nudYear, "Enter the year of Car")
        Me.nudYear.Value = New Decimal(New Integer() {1920, 0, 0, 0})
        '
        'frmCarInfo
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(611, 451)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.chkBoxNew)
        Me.Controls.Add(Me.lblNewStatus)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lvwCarList)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lvwCarList As ListView
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNewStatus As Label
    Friend WithEvents chkBoxNew As CheckBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents ttpCarInventorTips As ToolTip
End Class
