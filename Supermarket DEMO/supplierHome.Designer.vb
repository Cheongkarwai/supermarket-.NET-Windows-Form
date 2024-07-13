<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierHome
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
        Me.progressBarSales = New CircularProgressBar.CircularProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.timerTotalSales = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.progressBarProduct = New CircularProgressBar.CircularProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerNewProduct = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'progressBarSales
        '
        Me.progressBarSales.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.progressBarSales.AnimationSpeed = 1000
        Me.progressBarSales.BackColor = System.Drawing.Color.White
        Me.progressBarSales.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.progressBarSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.progressBarSales.InnerColor = System.Drawing.Color.White
        Me.progressBarSales.InnerMargin = 2
        Me.progressBarSales.InnerWidth = -1
        Me.progressBarSales.Location = New System.Drawing.Point(167, 44)
        Me.progressBarSales.MarqueeAnimationSpeed = 2000
        Me.progressBarSales.Name = "progressBarSales"
        Me.progressBarSales.OuterColor = System.Drawing.Color.White
        Me.progressBarSales.OuterMargin = -2
        Me.progressBarSales.OuterWidth = 2
        Me.progressBarSales.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progressBarSales.ProgressWidth = 2
        Me.progressBarSales.SecondaryFont = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.progressBarSales.Size = New System.Drawing.Size(120, 117)
        Me.progressBarSales.StartAngle = 270
        Me.progressBarSales.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.progressBarSales.SubscriptMargin = New System.Windows.Forms.Padding(6, -18, 0, 0)
        Me.progressBarSales.SubscriptText = ""
        Me.progressBarSales.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.progressBarSales.SuperscriptMargin = New System.Windows.Forms.Padding(10, 30, 0, 0)
        Me.progressBarSales.SuperscriptText = ""
        Me.progressBarSales.TabIndex = 0
        Me.progressBarSales.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.progressBarSales.Value = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(32, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 23)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Total Sales"
        '
        'timerTotalSales
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.progressBarSales)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(320, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 206)
        Me.Panel1.TabIndex = 65
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Supermarket_DEMO.My.Resources.Resources.sale
        Me.PictureBox1.Location = New System.Drawing.Point(41, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.progressBarProduct)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(722, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 206)
        Me.Panel2.TabIndex = 66
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Supermarket_DEMO.My.Resources.Resources.label
        Me.PictureBox2.Location = New System.Drawing.Point(41, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 74)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 65
        Me.PictureBox2.TabStop = False
        '
        'progressBarProduct
        '
        Me.progressBarProduct.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.progressBarProduct.AnimationSpeed = 1000
        Me.progressBarProduct.BackColor = System.Drawing.Color.White
        Me.progressBarProduct.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.progressBarProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.progressBarProduct.InnerColor = System.Drawing.Color.White
        Me.progressBarProduct.InnerMargin = 2
        Me.progressBarProduct.InnerWidth = -1
        Me.progressBarProduct.Location = New System.Drawing.Point(167, 44)
        Me.progressBarProduct.MarqueeAnimationSpeed = 2000
        Me.progressBarProduct.Name = "progressBarProduct"
        Me.progressBarProduct.OuterColor = System.Drawing.Color.White
        Me.progressBarProduct.OuterMargin = -2
        Me.progressBarProduct.OuterWidth = 2
        Me.progressBarProduct.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progressBarProduct.ProgressWidth = 2
        Me.progressBarProduct.SecondaryFont = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.progressBarProduct.Size = New System.Drawing.Size(120, 117)
        Me.progressBarProduct.StartAngle = 270
        Me.progressBarProduct.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.progressBarProduct.SubscriptMargin = New System.Windows.Forms.Padding(6, -18, 0, 0)
        Me.progressBarProduct.SubscriptText = ""
        Me.progressBarProduct.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.progressBarProduct.SuperscriptMargin = New System.Windows.Forms.Padding(10, 30, 0, 0)
        Me.progressBarProduct.SuperscriptText = ""
        Me.progressBarProduct.TabIndex = 0
        Me.progressBarProduct.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.progressBarProduct.Value = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(32, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "New Product"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(320, 65)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(84, 30)
        Me.lblTitle.TabIndex = 67
        Me.lblTitle.Text = "Statistic"
        '
        'dgvInventory
        '
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(320, 401)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowTemplate.Height = 25
        Me.dgvInventory.Size = New System.Drawing.Size(720, 214)
        Me.dgvInventory.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(320, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 30)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Inventory "
        '
        'timerNewProduct
        '
        '
        'supplierHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1388, 678)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "supplierHome"
        Me.Text = "supplierHome"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents progressBarSales As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents timerTotalSales As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents progressBarProduct As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents timerNewProduct As Timer
End Class
