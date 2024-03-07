<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromotionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromotionForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.departmentGroupBox = New System.Windows.Forms.GroupBox()
        Me.personalTrainingRadioButton = New System.Windows.Forms.RadioButton()
        Me.membershipRadioButton = New System.Windows.Forms.RadioButton()
        Me.juiceBarRadioButton = New System.Windows.Forms.RadioButton()
        Me.equipmentRadioButton = New System.Windows.Forms.RadioButton()
        Me.clothingRadioButton = New System.Windows.Forms.RadioButton()
        Me.imageVisibleCheckBox = New System.Windows.Forms.CheckBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.memberIDLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.promotionsTextBox = New System.Windows.Forms.TextBox()
        Me.welcomeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.signInButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.memberIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Print = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.departmentPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.departmentGroupBox.SuspendLayout()
        CType(Me.departmentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(49, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Look Sharp Fitness Center"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(421, 439)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.DarkBlue
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 414
        Me.LineShape1.Y1 = 35
        Me.LineShape1.Y2 = 34
        '
        'departmentGroupBox
        '
        Me.departmentGroupBox.Controls.Add(Me.Label2)
        Me.departmentGroupBox.Controls.Add(Me.personalTrainingRadioButton)
        Me.departmentGroupBox.Controls.Add(Me.membershipRadioButton)
        Me.departmentGroupBox.Controls.Add(Me.juiceBarRadioButton)
        Me.departmentGroupBox.Controls.Add(Me.equipmentRadioButton)
        Me.departmentGroupBox.Controls.Add(Me.clothingRadioButton)
        Me.departmentGroupBox.Location = New System.Drawing.Point(3, 43)
        Me.departmentGroupBox.Name = "departmentGroupBox"
        Me.departmentGroupBox.Size = New System.Drawing.Size(200, 170)
        Me.departmentGroupBox.TabIndex = 2
        Me.departmentGroupBox.TabStop = False
        Me.departmentGroupBox.Text = "Department"
        '
        'personalTrainingRadioButton
        '
        Me.personalTrainingRadioButton.AutoSize = True
        Me.personalTrainingRadioButton.Location = New System.Drawing.Point(9, 147)
        Me.personalTrainingRadioButton.Name = "personalTrainingRadioButton"
        Me.personalTrainingRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.personalTrainingRadioButton.TabIndex = 4
        Me.personalTrainingRadioButton.TabStop = True
        Me.personalTrainingRadioButton.Text = "Personal &Training"
        Me.personalTrainingRadioButton.UseVisualStyleBackColor = True
        '
        'membershipRadioButton
        '
        Me.membershipRadioButton.AutoSize = True
        Me.membershipRadioButton.Location = New System.Drawing.Point(9, 124)
        Me.membershipRadioButton.Name = "membershipRadioButton"
        Me.membershipRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.membershipRadioButton.TabIndex = 3
        Me.membershipRadioButton.TabStop = True
        Me.membershipRadioButton.Text = "&Membership"
        Me.membershipRadioButton.UseVisualStyleBackColor = True
        '
        'juiceBarRadioButton
        '
        Me.juiceBarRadioButton.AutoSize = True
        Me.juiceBarRadioButton.Location = New System.Drawing.Point(9, 93)
        Me.juiceBarRadioButton.Name = "juiceBarRadioButton"
        Me.juiceBarRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.juiceBarRadioButton.TabIndex = 2
        Me.juiceBarRadioButton.TabStop = True
        Me.juiceBarRadioButton.Text = "&Juice Bar"
        Me.juiceBarRadioButton.UseVisualStyleBackColor = True
        '
        'equipmentRadioButton
        '
        Me.equipmentRadioButton.AutoSize = True
        Me.equipmentRadioButton.Location = New System.Drawing.Point(9, 70)
        Me.equipmentRadioButton.Name = "equipmentRadioButton"
        Me.equipmentRadioButton.Size = New System.Drawing.Size(137, 17)
        Me.equipmentRadioButton.TabIndex = 1
        Me.equipmentRadioButton.TabStop = True
        Me.equipmentRadioButton.Text = "&Equipment/Accessories"
        Me.equipmentRadioButton.UseVisualStyleBackColor = True
        '
        'clothingRadioButton
        '
        Me.clothingRadioButton.AutoSize = True
        Me.clothingRadioButton.Location = New System.Drawing.Point(9, 47)
        Me.clothingRadioButton.Name = "clothingRadioButton"
        Me.clothingRadioButton.Size = New System.Drawing.Size(63, 17)
        Me.clothingRadioButton.TabIndex = 0
        Me.clothingRadioButton.TabStop = True
        Me.clothingRadioButton.Text = "&Clothing"
        Me.clothingRadioButton.UseVisualStyleBackColor = True
        '
        'imageVisibleCheckBox
        '
        Me.imageVisibleCheckBox.AutoSize = True
        Me.imageVisibleCheckBox.Location = New System.Drawing.Point(12, 410)
        Me.imageVisibleCheckBox.Name = "imageVisibleCheckBox"
        Me.imageVisibleCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.imageVisibleCheckBox.TabIndex = 6
        Me.imageVisibleCheckBox.Text = "Image &Visible"
        Me.imageVisibleCheckBox.UseVisualStyleBackColor = True
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(242, 62)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(35, 13)
        Me.nameLabel.TabIndex = 7
        Me.nameLabel.Text = "&Name"
        '
        'memberIDLabel
        '
        Me.memberIDLabel.AutoSize = True
        Me.memberIDLabel.Location = New System.Drawing.Point(231, 101)
        Me.memberIDLabel.Name = "memberIDLabel"
        Me.memberIDLabel.Size = New System.Drawing.Size(59, 13)
        Me.memberIDLabel.TabIndex = 8
        Me.memberIDLabel.Text = "Member &ID"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(299, 61)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nameTextBox.TabIndex = 9
        '
        'promotionsTextBox
        '
        Me.promotionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.promotionsTextBox.Location = New System.Drawing.Point(253, 228)
        Me.promotionsTextBox.Name = "promotionsTextBox"
        Me.promotionsTextBox.Size = New System.Drawing.Size(146, 20)
        Me.promotionsTextBox.TabIndex = 12
        Me.promotionsTextBox.TabStop = False
        Me.promotionsTextBox.Visible = False
        '
        'welcomeRichTextBox
        '
        Me.welcomeRichTextBox.Location = New System.Drawing.Point(253, 135)
        Me.welcomeRichTextBox.Name = "welcomeRichTextBox"
        Me.welcomeRichTextBox.Size = New System.Drawing.Size(146, 78)
        Me.welcomeRichTextBox.TabIndex = 13
        Me.welcomeRichTextBox.Text = ""
        Me.welcomeRichTextBox.Visible = False
        '
        'signInButton
        '
        Me.signInButton.Location = New System.Drawing.Point(324, 254)
        Me.signInButton.Name = "signInButton"
        Me.signInButton.Size = New System.Drawing.Size(75, 23)
        Me.signInButton.TabIndex = 14
        Me.signInButton.Text = "&Sign In"
        Me.signInButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(324, 341)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 15
        Me.printButton.Text = "&Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(324, 395)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 16
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'memberIDMaskedTextBox
        '
        Me.memberIDMaskedTextBox.Location = New System.Drawing.Point(296, 101)
        Me.memberIDMaskedTextBox.Mask = "0000"
        Me.memberIDMaskedTextBox.Name = "memberIDMaskedTextBox"
        Me.memberIDMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.memberIDMaskedTextBox.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.memberIDMaskedTextBox, "Your 5 digit member number")
        '
        'Print
        '
        Me.Print.UseEXDialog = True
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
        'departmentPictureBox
        '
        Me.departmentPictureBox.Location = New System.Drawing.Point(9, 227)
        Me.departmentPictureBox.Name = "departmentPictureBox"
        Me.departmentPictureBox.Size = New System.Drawing.Size(224, 177)
        Me.departmentPictureBox.TabIndex = 5
        Me.departmentPictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Uighur", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(5, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Select Department of Your choice"
        '
        'PromotionForm
        '
        Me.AcceptButton = Me.signInButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(421, 439)
        Me.Controls.Add(Me.memberIDMaskedTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.signInButton)
        Me.Controls.Add(Me.welcomeRichTextBox)
        Me.Controls.Add(Me.promotionsTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.memberIDLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.imageVisibleCheckBox)
        Me.Controls.Add(Me.departmentPictureBox)
        Me.Controls.Add(Me.departmentGroupBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "PromotionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolTip1.SetToolTip(Me, "Your 5 digit member number.")
        Me.departmentGroupBox.ResumeLayout(False)
        Me.departmentGroupBox.PerformLayout()
        CType(Me.departmentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents departmentGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents personalTrainingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents membershipRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents juiceBarRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents equipmentRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents clothingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents imageVisibleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents memberIDLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents promotionsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents welcomeRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents signInButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents memberIDMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Print As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents departmentPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
