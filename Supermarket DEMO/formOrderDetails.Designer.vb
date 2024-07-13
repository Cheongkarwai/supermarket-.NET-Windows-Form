<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formOrderDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formOrderDetails))
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.btnOK = New FontAwesome.Sharp.IconButton()
        Me.lblReceipt = New System.Windows.Forms.RichTextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnPreview = New FontAwesome.Sharp.IconButton()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrint.IconColor = System.Drawing.Color.Black
        Me.btnPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrint.IconSize = 30
        Me.btnPrint.Location = New System.Drawing.Point(624, 231)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 33)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnOK.IconColor = System.Drawing.Color.Black
        Me.btnOK.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOK.IconSize = 30
        Me.btnOK.Location = New System.Drawing.Point(624, 288)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 33)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblReceipt
        '
        Me.lblReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReceipt.Location = New System.Drawing.Point(33, 29)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.ReadOnly = True
        Me.lblReceipt.Size = New System.Drawing.Size(543, 381)
        Me.lblReceipt.TabIndex = 5
        Me.lblReceipt.Text = ""
        '
        'PrintDocument1
        '
        '
        'btnPreview
        '
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnPreview.IconColor = System.Drawing.Color.Black
        Me.btnPreview.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPreview.IconSize = 30
        Me.btnPreview.Location = New System.Drawing.Point(624, 179)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(88, 33)
        Me.btnPreview.TabIndex = 6
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'formOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.lblReceipt)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "formOrderDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formOrderDetails"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOK As FontAwesome.Sharp.IconButton
    Friend WithEvents lblReceipt As RichTextBox
    Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
    Friend WithEvents btnPreview As FontAwesome.Sharp.IconButton
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
