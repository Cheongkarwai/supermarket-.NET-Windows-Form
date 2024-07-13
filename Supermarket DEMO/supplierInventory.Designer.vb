<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class supplierInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.overviewTable = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOverviewName = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbxMode = New System.Windows.Forms.ComboBox()
        Me.panelOverview = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.panelEdit = New System.Windows.Forms.Panel()
        Me.txtEditDesc = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnUploadImage = New System.Windows.Forms.Button()
        Me.picEditImg = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtEditCategory = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEditQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEditPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEditName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.editTable = New System.Windows.Forms.DataGridView()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.panelAddProduct = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAddDesc = New System.Windows.Forms.RichTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnUploadImg = New System.Windows.Forms.Button()
        Me.picAddImg = New System.Windows.Forms.PictureBox()
        Me.txtAddCategory = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddQuantity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddPrice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAddName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.addTable = New System.Windows.Forms.DataGridView()
        Me.btnAddReset = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.overviewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOverview.SuspendLayout()
        Me.panelEdit.SuspendLayout()
        CType(Me.picEditImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAddProduct.SuspendLayout()
        CType(Me.picAddImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'overviewTable
        '
        Me.overviewTable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.overviewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.overviewTable.Location = New System.Drawing.Point(244, 25)
        Me.overviewTable.Name = "overviewTable"
        Me.overviewTable.ReadOnly = True
        Me.overviewTable.RowHeadersVisible = False
        Me.overviewTable.RowTemplate.Height = 25
        Me.overviewTable.Size = New System.Drawing.Size(779, 354)
        Me.overviewTable.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 500)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Name:"
        '
        'txtOverviewName
        '
        Me.txtOverviewName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOverviewName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOverviewName.Location = New System.Drawing.Point(347, 500)
        Me.txtOverviewName.Name = "txtOverviewName"
        Me.txtOverviewName.Size = New System.Drawing.Size(212, 22)
        Me.txtOverviewName.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.Location = New System.Drawing.Point(889, 484)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(134, 43)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbxMode
        '
        Me.cbxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMode.FormattingEnabled = True
        Me.cbxMode.Items.AddRange(New Object() {"Overview", "Edit Mode", "Add Mode"})
        Me.cbxMode.Location = New System.Drawing.Point(932, 23)
        Me.cbxMode.Name = "cbxMode"
        Me.cbxMode.Size = New System.Drawing.Size(121, 23)
        Me.cbxMode.TabIndex = 7
        '
        'panelOverview
        '
        Me.panelOverview.BackColor = System.Drawing.Color.White
        Me.panelOverview.Controls.Add(Me.Panel6)
        Me.panelOverview.Controls.Add(Me.overviewTable)
        Me.panelOverview.Controls.Add(Me.btnSearch)
        Me.panelOverview.Controls.Add(Me.Label1)
        Me.panelOverview.Controls.Add(Me.txtOverviewName)
        Me.panelOverview.Location = New System.Drawing.Point(79, 56)
        Me.panelOverview.Name = "panelOverview"
        Me.panelOverview.Size = New System.Drawing.Size(1111, 614)
        Me.panelOverview.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(347, 521)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(212, 1)
        Me.Panel6.TabIndex = 8
        '
        'panelEdit
        '
        Me.panelEdit.Controls.Add(Me.txtEditDesc)
        Me.panelEdit.Controls.Add(Me.Label2)
        Me.panelEdit.Controls.Add(Me.Panel9)
        Me.panelEdit.Controls.Add(Me.Panel8)
        Me.panelEdit.Controls.Add(Me.Panel7)
        Me.panelEdit.Controls.Add(Me.Panel5)
        Me.panelEdit.Controls.Add(Me.btnUploadImage)
        Me.panelEdit.Controls.Add(Me.picEditImg)
        Me.panelEdit.Controls.Add(Me.btnDelete)
        Me.panelEdit.Controls.Add(Me.txtEditCategory)
        Me.panelEdit.Controls.Add(Me.Label6)
        Me.panelEdit.Controls.Add(Me.txtEditQuantity)
        Me.panelEdit.Controls.Add(Me.Label5)
        Me.panelEdit.Controls.Add(Me.txtEditPrice)
        Me.panelEdit.Controls.Add(Me.Label4)
        Me.panelEdit.Controls.Add(Me.txtEditName)
        Me.panelEdit.Controls.Add(Me.Label3)
        Me.panelEdit.Controls.Add(Me.editTable)
        Me.panelEdit.Controls.Add(Me.btnReset)
        Me.panelEdit.Controls.Add(Me.btnUpdate)
        Me.panelEdit.Location = New System.Drawing.Point(76, 56)
        Me.panelEdit.Name = "panelEdit"
        Me.panelEdit.Size = New System.Drawing.Size(1114, 617)
        Me.panelEdit.TabIndex = 9
        '
        'txtEditDesc
        '
        Me.txtEditDesc.Location = New System.Drawing.Point(370, 459)
        Me.txtEditDesc.Name = "txtEditDesc"
        Me.txtEditDesc.Size = New System.Drawing.Size(176, 83)
        Me.txtEditDesc.TabIndex = 22
        Me.txtEditDesc.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(272, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Description"
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Location = New System.Drawing.Point(370, 432)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(176, 1)
        Me.Panel9.TabIndex = 20
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(370, 389)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(176, 1)
        Me.Panel8.TabIndex = 19
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(370, 345)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(176, 1)
        Me.Panel7.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(759, 345)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 1)
        Me.Panel5.TabIndex = 17
        '
        'btnUploadImage
        '
        Me.btnUploadImage.BackColor = System.Drawing.Color.White
        Me.btnUploadImage.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadImage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUploadImage.Location = New System.Drawing.Point(648, 371)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(110, 27)
        Me.btnUploadImage.TabIndex = 16
        Me.btnUploadImage.Text = "Upload Image"
        Me.btnUploadImage.UseVisualStyleBackColor = False
        '
        'picEditImg
        '
        Me.picEditImg.BackColor = System.Drawing.Color.White
        Me.picEditImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEditImg.Location = New System.Drawing.Point(759, 371)
        Me.picEditImg.Name = "picEditImg"
        Me.picEditImg.Size = New System.Drawing.Size(176, 125)
        Me.picEditImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEditImg.TabIndex = 15
        Me.picEditImg.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.Location = New System.Drawing.Point(710, 558)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 37)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtEditCategory
        '
        Me.txtEditCategory.BackColor = System.Drawing.Color.White
        Me.txtEditCategory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEditCategory.Location = New System.Drawing.Point(759, 324)
        Me.txtEditCategory.Name = "txtEditCategory"
        Me.txtEditCategory.Size = New System.Drawing.Size(176, 22)
        Me.txtEditCategory.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(671, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Category"
        '
        'txtEditQuantity
        '
        Me.txtEditQuantity.BackColor = System.Drawing.Color.White
        Me.txtEditQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEditQuantity.Location = New System.Drawing.Point(370, 411)
        Me.txtEditQuantity.Name = "txtEditQuantity"
        Me.txtEditQuantity.Size = New System.Drawing.Size(176, 22)
        Me.txtEditQuantity.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(272, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Quantity"
        '
        'txtEditPrice
        '
        Me.txtEditPrice.BackColor = System.Drawing.Color.White
        Me.txtEditPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEditPrice.Location = New System.Drawing.Point(370, 368)
        Me.txtEditPrice.Name = "txtEditPrice"
        Me.txtEditPrice.Size = New System.Drawing.Size(176, 22)
        Me.txtEditPrice.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(272, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Price"
        '
        'txtEditName
        '
        Me.txtEditName.BackColor = System.Drawing.Color.White
        Me.txtEditName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEditName.Location = New System.Drawing.Point(370, 324)
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(176, 22)
        Me.txtEditName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(272, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Product Name"
        '
        'editTable
        '
        Me.editTable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.editTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.editTable.Location = New System.Drawing.Point(244, 25)
        Me.editTable.MultiSelect = False
        Me.editTable.Name = "editTable"
        Me.editTable.ReadOnly = True
        Me.editTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.editTable.RowHeadersVisible = False
        Me.editTable.RowTemplate.Height = 25
        Me.editTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.editTable.Size = New System.Drawing.Size(730, 239)
        Me.editTable.TabIndex = 3
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(565, 558)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(121, 37)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.Location = New System.Drawing.Point(853, 558)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 37)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'panelAddProduct
        '
        Me.panelAddProduct.BackColor = System.Drawing.Color.White
        Me.panelAddProduct.Controls.Add(Me.Panel4)
        Me.panelAddProduct.Controls.Add(Me.Panel1)
        Me.panelAddProduct.Controls.Add(Me.txtAddDesc)
        Me.panelAddProduct.Controls.Add(Me.Panel3)
        Me.panelAddProduct.Controls.Add(Me.Panel2)
        Me.panelAddProduct.Controls.Add(Me.Label12)
        Me.panelAddProduct.Controls.Add(Me.btnUploadImg)
        Me.panelAddProduct.Controls.Add(Me.picAddImg)
        Me.panelAddProduct.Controls.Add(Me.txtAddCategory)
        Me.panelAddProduct.Controls.Add(Me.Label7)
        Me.panelAddProduct.Controls.Add(Me.txtAddQuantity)
        Me.panelAddProduct.Controls.Add(Me.Label8)
        Me.panelAddProduct.Controls.Add(Me.txtAddPrice)
        Me.panelAddProduct.Controls.Add(Me.Label9)
        Me.panelAddProduct.Controls.Add(Me.txtAddName)
        Me.panelAddProduct.Controls.Add(Me.Label10)
        Me.panelAddProduct.Controls.Add(Me.addTable)
        Me.panelAddProduct.Controls.Add(Me.btnAddReset)
        Me.panelAddProduct.Controls.Add(Me.btnAddProduct)
        Me.panelAddProduct.Location = New System.Drawing.Point(79, 56)
        Me.panelAddProduct.Name = "panelAddProduct"
        Me.panelAddProduct.Size = New System.Drawing.Size(1111, 595)
        Me.panelAddProduct.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(389, 422)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(176, 1)
        Me.Panel4.TabIndex = 69
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(389, 373)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 1)
        Me.Panel1.TabIndex = 68
        '
        'txtAddDesc
        '
        Me.txtAddDesc.Location = New System.Drawing.Point(389, 458)
        Me.txtAddDesc.Name = "txtAddDesc"
        Me.txtAddDesc.Size = New System.Drawing.Size(176, 102)
        Me.txtAddDesc.TabIndex = 68
        Me.txtAddDesc.Text = ""
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(389, 327)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(176, 1)
        Me.Panel3.TabIndex = 67
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(756, 324)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 1)
        Me.Panel2.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(278, 461)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 17)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Description:"
        '
        'btnUploadImg
        '
        Me.btnUploadImg.BackColor = System.Drawing.Color.White
        Me.btnUploadImg.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUploadImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadImg.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUploadImg.Location = New System.Drawing.Point(645, 352)
        Me.btnUploadImg.Name = "btnUploadImg"
        Me.btnUploadImg.Size = New System.Drawing.Size(110, 27)
        Me.btnUploadImg.TabIndex = 14
        Me.btnUploadImg.Text = "Upload Image"
        Me.btnUploadImg.UseVisualStyleBackColor = False
        '
        'picAddImg
        '
        Me.picAddImg.BackColor = System.Drawing.Color.White
        Me.picAddImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAddImg.Location = New System.Drawing.Point(756, 352)
        Me.picAddImg.Name = "picAddImg"
        Me.picAddImg.Size = New System.Drawing.Size(176, 125)
        Me.picAddImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAddImg.TabIndex = 12
        Me.picAddImg.TabStop = False
        '
        'txtAddCategory
        '
        Me.txtAddCategory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddCategory.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAddCategory.Location = New System.Drawing.Point(756, 305)
        Me.txtAddCategory.Name = "txtAddCategory"
        Me.txtAddCategory.Size = New System.Drawing.Size(176, 20)
        Me.txtAddCategory.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(645, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Category"
        '
        'txtAddQuantity
        '
        Me.txtAddQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAddQuantity.Location = New System.Drawing.Point(389, 401)
        Me.txtAddQuantity.Name = "txtAddQuantity"
        Me.txtAddQuantity.Size = New System.Drawing.Size(176, 22)
        Me.txtAddQuantity.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(278, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Quantity"
        '
        'txtAddPrice
        '
        Me.txtAddPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAddPrice.Location = New System.Drawing.Point(389, 352)
        Me.txtAddPrice.Name = "txtAddPrice"
        Me.txtAddPrice.Size = New System.Drawing.Size(176, 22)
        Me.txtAddPrice.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(278, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Price"
        '
        'txtAddName
        '
        Me.txtAddName.BackColor = System.Drawing.Color.White
        Me.txtAddName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAddName.Location = New System.Drawing.Point(389, 308)
        Me.txtAddName.Name = "txtAddName"
        Me.txtAddName.Size = New System.Drawing.Size(176, 20)
        Me.txtAddName.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(278, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Product Name"
        '
        'addTable
        '
        Me.addTable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.addTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.addTable.Location = New System.Drawing.Point(244, 25)
        Me.addTable.Name = "addTable"
        Me.addTable.ReadOnly = True
        Me.addTable.RowHeadersVisible = False
        Me.addTable.RowTemplate.Height = 25
        Me.addTable.Size = New System.Drawing.Size(730, 239)
        Me.addTable.TabIndex = 3
        '
        'btnAddReset
        '
        Me.btnAddReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddReset.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddReset.Location = New System.Drawing.Point(645, 523)
        Me.btnAddReset.Name = "btnAddReset"
        Me.btnAddReset.Size = New System.Drawing.Size(121, 37)
        Me.btnAddReset.TabIndex = 2
        Me.btnAddReset.Text = "Reset"
        Me.btnAddReset.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduct.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddProduct.Location = New System.Drawing.Point(817, 523)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(121, 37)
        Me.btnAddProduct.TabIndex = 0
        Me.btnAddProduct.Text = "Add"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(323, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(84, 30)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Label11"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'supplierInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1388, 678)
        Me.Controls.Add(Me.panelAddProduct)
        Me.Controls.Add(Me.panelEdit)
        Me.Controls.Add(Me.panelOverview)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cbxMode)
        Me.Name = "supplierInventory"
        Me.Text = "supplierInventory"
        CType(Me.overviewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOverview.ResumeLayout(False)
        Me.panelOverview.PerformLayout()
        Me.panelEdit.ResumeLayout(False)
        Me.panelEdit.PerformLayout()
        CType(Me.picEditImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAddProduct.ResumeLayout(False)
        Me.panelAddProduct.PerformLayout()
        CType(Me.picAddImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents overviewTable As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOverviewName As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cbxMode As ComboBox
    Friend WithEvents panelOverview As Panel
    Friend WithEvents panelEdit As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtEditCategory As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEditQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEditPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEditName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents editTable As DataGridView
    Friend WithEvents btnReset As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents panelAddProduct As Panel
    Friend WithEvents txtAddCategory As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddQuantity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAddPrice As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAddName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents addTable As DataGridView
    Friend WithEvents btnAddReset As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnUploadImg As Button
    Friend WithEvents picAddImg As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAddDesc As RichTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents picEditImg As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents txtEditDesc As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
