Public Class BMIForm
    Public Function buttons(z As String)
        txtResult.Text = txtResult.Text + z
        Return z
    End Function

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        Dim one As String
        one = "1"
        buttons(one)
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        Dim two As String
        two = "2"
        buttons(two)
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        Dim three As String
        three = "3"
        buttons(three)
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        Dim four As String
        four = "4"
        buttons(four)
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        Dim five As String
        five = "5"
        buttons(five)
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        Dim six As String
        six = "6"
        buttons(six)
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        Dim seven As String
        seven = "7"
        buttons(seven)
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        Dim eight As String
        eight = "8"
        buttons(eight)
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        Dim nine As String
        nine = "9"
        buttons(nine)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim zero As String
        zero = "0"
        buttons(zero)
    End Sub

    Private Sub btnTwozero_Click(sender As Object, e As EventArgs) Handles btnTwozero.Click
        Dim doubleZero As String
        doubleZero = "00"
        buttons(doubleZero)
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        Dim period As String
        period = "."
        buttons(period)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtResult.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtResult.Text = ""
        lblHeight.Text = ""
        lblWeight.Text = ""
        BMI.Text = ""
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click

        If lblHeight.Text = "" Then
            lblHeight.Text = txtResult.Text
            lblWeight.Text = ""
            txtResult.Text = ""
        ElseIf lblWeight.Text = "" Then
            lblWeight.Text = txtResult.Text
            txtResult.Text = ""
        Else
            BMI.Text = Val(lblWeight.Text) / Val((Val(lblHeight.Text) / 100) * (Val(lblHeight.Text) / 100))
            BMI.Text = Format(Val(BMI.Text), "0.00")
            txtResult.Text = ""
        End If

    End Sub

    Private Sub txtResult_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResult.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub StandardCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardCalculatorToolStripMenuItem.Click
        Calculator.Show()
        Me.Hide()
    End Sub

End Class