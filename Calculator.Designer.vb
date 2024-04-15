<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        btnOne = New Button()
        btnTwo = New Button()
        btnThree = New Button()
        btnFour = New Button()
        btnFive = New Button()
        btnSix = New Button()
        btnSeven = New Button()
        btnEight = New Button()
        btnNine = New Button()
        btnDot = New Button()
        btnAdd = New Button()
        btnDiff = New Button()
        btnMultiply = New Button()
        btnDivision = New Button()
        btnEqual = New Button()
        txtResult = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        btnTwozero = New Button()
        Label2 = New Label()
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        AreaToolStripMenuItem = New ToolStripMenuItem()
        BMIToolStripMenuItem = New ToolStripMenuItem()
        TimeToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnOne
        ' 
        btnOne.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnOne.Location = New Point(26, 131)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(78, 46)
        btnOne.TabIndex = 1
        btnOne.Text = "1"
        btnOne.UseVisualStyleBackColor = True
        ' 
        ' btnTwo
        ' 
        btnTwo.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnTwo.Location = New Point(110, 131)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(78, 46)
        btnTwo.TabIndex = 2
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = True
        ' 
        ' btnThree
        ' 
        btnThree.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnThree.Location = New Point(194, 131)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(78, 46)
        btnThree.TabIndex = 3
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = True
        ' 
        ' btnFour
        ' 
        btnFour.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnFour.Location = New Point(26, 183)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(78, 46)
        btnFour.TabIndex = 4
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = True
        ' 
        ' btnFive
        ' 
        btnFive.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnFive.Location = New Point(110, 183)
        btnFive.Name = "btnFive"
        btnFive.Size = New Size(78, 46)
        btnFive.TabIndex = 5
        btnFive.Text = "5"
        btnFive.UseVisualStyleBackColor = True
        ' 
        ' btnSix
        ' 
        btnSix.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSix.Location = New Point(194, 183)
        btnSix.Name = "btnSix"
        btnSix.Size = New Size(78, 46)
        btnSix.TabIndex = 6
        btnSix.Text = "6"
        btnSix.UseVisualStyleBackColor = True
        ' 
        ' btnSeven
        ' 
        btnSeven.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSeven.Location = New Point(26, 235)
        btnSeven.Name = "btnSeven"
        btnSeven.Size = New Size(78, 46)
        btnSeven.TabIndex = 7
        btnSeven.Text = "7"
        btnSeven.UseVisualStyleBackColor = True
        ' 
        ' btnEight
        ' 
        btnEight.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnEight.Location = New Point(110, 235)
        btnEight.Name = "btnEight"
        btnEight.Size = New Size(78, 46)
        btnEight.TabIndex = 8
        btnEight.Text = "8"
        btnEight.UseVisualStyleBackColor = True
        ' 
        ' btnNine
        ' 
        btnNine.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnNine.Location = New Point(194, 235)
        btnNine.Name = "btnNine"
        btnNine.Size = New Size(78, 46)
        btnNine.TabIndex = 9
        btnNine.Text = "9"
        btnNine.UseVisualStyleBackColor = True
        ' 
        ' btnDot
        ' 
        btnDot.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDot.Location = New Point(26, 287)
        btnDot.Name = "btnDot"
        btnDot.Size = New Size(78, 46)
        btnDot.TabIndex = 10
        btnDot.Text = "."
        btnDot.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Location = New Point(308, 131)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(78, 46)
        btnAdd.TabIndex = 11
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDiff
        ' 
        btnDiff.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDiff.Location = New Point(392, 131)
        btnDiff.Name = "btnDiff"
        btnDiff.Size = New Size(78, 46)
        btnDiff.TabIndex = 12
        btnDiff.Text = "-"
        btnDiff.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnMultiply.Location = New Point(392, 183)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(78, 46)
        btnMultiply.TabIndex = 13
        btnMultiply.Text = "X"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnDivision
        ' 
        btnDivision.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDivision.Location = New Point(308, 183)
        btnDivision.Name = "btnDivision"
        btnDivision.Size = New Size(78, 46)
        btnDivision.TabIndex = 14
        btnDivision.Text = "÷"
        btnDivision.UseVisualStyleBackColor = True
        ' 
        ' btnEqual
        ' 
        btnEqual.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnEqual.Location = New Point(308, 287)
        btnEqual.Name = "btnEqual"
        btnEqual.Size = New Size(162, 46)
        btnEqual.TabIndex = 15
        btnEqual.Text = "="
        btnEqual.UseVisualStyleBackColor = True
        ' 
        ' txtResult
        ' 
        txtResult.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtResult.Location = New Point(26, 59)
        txtResult.Multiline = True
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(444, 52)
        txtResult.TabIndex = 16
        txtResult.TextAlign = HorizontalAlignment.Right
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(392, 235)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 46)
        Button1.TabIndex = 13
        Button1.Text = "CE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(308, 235)
        Button2.Name = "Button2"
        Button2.Size = New Size(78, 46)
        Button2.TabIndex = 14
        Button2.Text = "C"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(110, 287)
        Button3.Name = "Button3"
        Button3.Size = New Size(78, 46)
        Button3.TabIndex = 10
        Button3.Text = "0"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnTwozero
        ' 
        btnTwozero.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnTwozero.Location = New Point(194, 287)
        btnTwozero.Name = "btnTwozero"
        btnTwozero.Size = New Size(78, 46)
        btnTwozero.TabIndex = 10
        btnTwozero.Text = "00"
        btnTwozero.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(392, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 21)
        Label2.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(476, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 21)
        Label3.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(499, 29)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AreaToolStripMenuItem, BMIToolStripMenuItem, TimeToolStripMenuItem})
        MenuToolStripMenuItem.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(62, 25)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' AreaToolStripMenuItem
        ' 
        AreaToolStripMenuItem.Name = "AreaToolStripMenuItem"
        AreaToolStripMenuItem.Size = New Size(180, 26)
        AreaToolStripMenuItem.Text = "Area"
        ' 
        ' BMIToolStripMenuItem
        ' 
        BMIToolStripMenuItem.Name = "BMIToolStripMenuItem"
        BMIToolStripMenuItem.Size = New Size(180, 26)
        BMIToolStripMenuItem.Text = "BMI "
        ' 
        ' TimeToolStripMenuItem
        ' 
        TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        TimeToolStripMenuItem.Size = New Size(180, 26)
        TimeToolStripMenuItem.Text = "Time"
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(499, 361)
        Controls.Add(txtResult)
        Controls.Add(btnEqual)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnDivision)
        Controls.Add(btnMultiply)
        Controls.Add(btnDiff)
        Controls.Add(btnAdd)
        Controls.Add(btnTwozero)
        Controls.Add(Button3)
        Controls.Add(btnDot)
        Controls.Add(btnNine)
        Controls.Add(btnEight)
        Controls.Add(btnSeven)
        Controls.Add(btnSix)
        Controls.Add(btnFive)
        Controls.Add(btnFour)
        Controls.Add(btnThree)
        Controls.Add(btnTwo)
        Controls.Add(btnOne)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "Calculator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Standard Calculator"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDiff As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnTwozero As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BMIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem

End Class
