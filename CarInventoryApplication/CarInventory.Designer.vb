<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lvwCarInventory = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.CarInventoryToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMake.Location = New System.Drawing.Point(12, 23)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(132, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblModel.Location = New System.Drawing.Point(12, 56)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(132, 23)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Mo&del:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblYear.Location = New System.Drawing.Point(12, 91)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(132, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPrice.Location = New System.Drawing.Point(12, 126)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(132, 23)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkNew.Location = New System.Drawing.Point(16, 158)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNew.Size = New System.Drawing.Size(150, 24)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTips.SetToolTip(Me.chkNew, "Check if Car is New")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Acura", "Audi", "Bentley", "BMW", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Ferrari", "Fiat", "Ford", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lexus", "Mazda", "Mercedes-Benz", "Mini", "Mitsubishi", "Porsche", "Nissan", "Rolls Royce", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo"})
        Me.cmbMake.Location = New System.Drawing.Point(150, 18)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(203, 28)
        Me.cmbMake.TabIndex = 1
        Me.CarInventoryToolTips.SetToolTip(Me.cmbMake, "Select Make of Car")
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980"})
        Me.cmbYear.Location = New System.Drawing.Point(150, 86)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(203, 28)
        Me.cmbYear.TabIndex = 5
        Me.CarInventoryToolTips.SetToolTip(Me.cmbYear, "Select Year of Car")
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtModel.Location = New System.Drawing.Point(151, 53)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(202, 26)
        Me.txtModel.TabIndex = 3
        Me.CarInventoryToolTips.SetToolTip(Me.txtModel, "Enter model of Car")
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPrice.Location = New System.Drawing.Point(150, 126)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(203, 26)
        Me.txtPrice.TabIndex = 7
        Me.CarInventoryToolTips.SetToolTip(Me.txtPrice, "Enter Price of Car")
        '
        'lvwCarInventory
        '
        Me.lvwCarInventory.CheckBoxes = True
        Me.lvwCarInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCarInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lvwCarInventory.FullRowSelect = True
        Me.lvwCarInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCarInventory.HideSelection = False
        Me.lvwCarInventory.Location = New System.Drawing.Point(12, 188)
        Me.lvwCarInventory.MultiSelect = False
        Me.lvwCarInventory.Name = "lvwCarInventory"
        Me.lvwCarInventory.Size = New System.Drawing.Size(608, 167)
        Me.lvwCarInventory.TabIndex = 9
        Me.CarInventoryToolTips.SetToolTip(Me.lvwCarInventory, "List of Car Inventory")
        Me.lvwCarInventory.UseCompatibleStateImageBehavior = False
        Me.lvwCarInventory.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(13, 358)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(607, 105)
        Me.lblResult.TabIndex = 10
        Me.CarInventoryToolTips.SetToolTip(Me.lblResult, "Success or Error message will appear here")
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnEnter.Location = New System.Drawing.Point(383, 478)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 30)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.CarInventoryToolTips.SetToolTip(Me.btnEnter, "Click to Enter a Car")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnReset.Location = New System.Drawing.Point(464, 478)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 30)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.CarInventoryToolTips.SetToolTip(Me.btnReset, "Click to clear screen")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnExit.Location = New System.Drawing.Point(545, 478)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.CarInventoryToolTips.SetToolTip(Me.btnExit, "Click to exit application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(632, 520)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lvwCarInventory)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents CarInventoryToolTips As ToolTip
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lvwCarInventory As ListView
    Friend WithEvents lblResult As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
End Class
