'project : CH04HandsOn
'programmer : Enoq
'Date: 27/02/2024
'Description : the project prompt picture from it's department with relevant member name and membership ID  



Imports System.Drawing.Printing
Public Class PromotionForm

    Private printDocument As New PrintDocument()
    Private Shared Property PrintAction As PrintAction


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles clothingRadioButton.CheckedChanged
        'Display the clothing image and show the special
        departmentPictureBox.Image = Image.FromFile("C:\Users\Students\Desktop\stella\enzo.png")
        promotionsTextBox.Text = "30% off clearance items."
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub signInButton_Click(sender As Object, e As EventArgs) Handles signInButton.Click

        ' Check if name and member ID are inputted
        If String.IsNullOrWhiteSpace(nameTextBox.Text) Or String.IsNullOrWhiteSpace(memberIDMaskedTextBox.Text) Then
            MessageBox.Show("Please enter your name and member ID before signing in.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the event handler if name or member ID is missing
        End If
        'Display the specials, set the visibility of the controls.
        welcomeRichTextBox.Text = "Welcome Member #" + memberIDMaskedTextBox.Text + Environment.NewLine + nameTextBox.Text

        'Set visibility properties.
        memberIDLabel.Visible = False
        memberIDMaskedTextBox.Visible = False
        nameLabel.Visible = False
        nameTextBox.Visible = False
        welcomeRichTextBox.Visible = True
        promotionsTextBox.Visible = True
        imageVisibleCheckBox.Visible = True
        departmentPictureBox.Visible = False

        'Enable the radio buttons.
        departmentGroupBox.Enabled = True

    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click

        ' Check if name and member ID are inputted
        If String.IsNullOrWhiteSpace(nameTextBox.Text) Or String.IsNullOrWhiteSpace(memberIDMaskedTextBox.Text) Then
            MessageBox.Show("Please enter your name and member ID before printing.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the event handler if name or member ID is missing
        End If

        ' Attach event handler for printing
        AddHandler PrintDocument.PrintPage, AddressOf PrintDocument_PrintPage

        ' Show print dialog
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument.Print()
        End If

        ' Remove event handler after printing
        RemoveHandler PrintDocument.PrintPage, AddressOf PrintDocument_PrintPage

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'End the project.
        Me.Close()
    End Sub

    Private Sub equipmentRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles equipmentRadioButton.CheckedChanged
        'Display the equipment image and show the special
        departmentPictureBox.Image = Image.FromFile("C:\Users\Students\Desktop\stella\tools.png")
        promotionsTextBox.Text = "25% off clearance items."
    End Sub

    Private Sub membershipRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles membershipRadioButton.CheckedChanged
        'Display the membership image and show the special
        departmentPictureBox.Image = Image.FromFile("C:\Users\Students\Desktop\stella\membership.png")
        promotionsTextBox.Text = "Free Personal Trainer for 1st month."
    End Sub

    Private Sub personalTrainingRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles personalTrainingRadioButton.CheckedChanged
        'Display the clothing image and show the special
        departmentPictureBox.Image = Image.FromFile("C:\Users\Students\Desktop\stella\trainer.png")
        promotionsTextBox.Text = "3 free sessions with membership renewal."
    End Sub

    Private Sub imageVisibleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles imageVisibleCheckBox.CheckedChanged
        'set the visibility of the department images
        departmentPictureBox.Visible = imageVisibleCheckBox.Checked
    End Sub

    Private Sub juiceBarRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles juiceBarRadioButton.CheckedChanged
        'Display the juice image and show the special
        departmentPictureBox.Image = Image.FromFile("C:\Users\Students\Desktop\stella\juice.png")
        promotionsTextBox.Text = "free serving of WheatBerry Shake."
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Get the size of the print area
        Dim printAreaWidth As Integer = e.MarginBounds.Width
        Dim printAreaHeight As Integer = e.MarginBounds.Height

        ' Get the size of the image
        Dim imageWidth As Integer = departmentPictureBox.Image.Width
        Dim imageHeight As Integer = departmentPictureBox.Image.Height

        ' Calculate the scaling factor
        Dim scaleFactorX As Single = printAreaWidth / imageWidth
        Dim scaleFactorY As Single = printAreaHeight / imageHeight
        Dim scaleFactor As Single = Math.Min(scaleFactorX, scaleFactorY)

        ' Calculate the size of the scaled image
        Dim scaledWidth As Integer = CInt(imageWidth * scaleFactor)
        Dim scaledHeight As Integer = CInt(imageHeight * scaleFactor)

        ' Calculate the position to draw the image
        Dim x As Integer = e.MarginBounds.Left + (printAreaWidth - scaledWidth) / 2
        Dim y As Integer = e.MarginBounds.Top + (printAreaHeight - scaledHeight) / 2

        ' Draw the scaled image on the print page
        e.Graphics.DrawImage(departmentPictureBox.Image, x, y, scaledWidth, scaledHeight)

        ' Print the name and member ID
        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)
        Dim nameMemberID As String = "Name: " & nameTextBox.Text & ", Member ID: " & memberIDMaskedTextBox.Text

        Dim stringSize As SizeF = e.Graphics.MeasureString(nameMemberID, font)

        ' Calculate the position to print the text
        Dim textX As Single = x
        Dim textY As Single = y + scaledHeight + 10

        ' Draw the text on the print page
        e.Graphics.DrawString(nameMemberID, font, brush, textX, textY)

        ' Print the promotion text
        Dim promotionText As String = "Promotion: " & promotionsTextBox.Text
        textY += stringSize.Height + 5 ' Adjust vertical position
        e.Graphics.DrawString(promotionText, font, brush, textX, textY)


    End Sub


    Private Sub departmentPictureBox_Click(sender As Object, e As EventArgs) Handles departmentPictureBox.Click
        ' Set the SizeMode property of the picture box to Zoom
        departmentPictureBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

  
End Class
