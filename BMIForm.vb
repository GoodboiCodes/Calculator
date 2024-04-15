Public Class BMIForm


    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtResult.Text = txtResult.Text + "1"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtResult.Text = txtResult.Text + "2"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtResult.Text = txtResult.Text + "3"
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtResult.Text = txtResult.Text + "4"
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtResult.Text = txtResult.Text + "5"
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtResult.Text = txtResult.Text + "6"
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtResult.Text = txtResult.Text + "7"
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtResult.Text = txtResult.Text + "8"
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtResult.Text = txtResult.Text + "9"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtResult.Text = txtResult.Text + "0"
    End Sub

    Private Sub btnTwozero_Click(sender As Object, e As EventArgs) Handles btnTwozero.Click
        txtResult.Text = txtResult.Text + "00"
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        txtResult.Text = txtResult.Text + "."
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