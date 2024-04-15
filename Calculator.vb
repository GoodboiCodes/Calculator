Public Class Calculator
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Label2.Text = txtResult.Text
        Label3.Text = "+"
        txtResult.Text = ""
    End Sub

    Private Sub btnDiff_Click(sender As Object, e As EventArgs) Handles btnDiff.Click
        Label2.Text = txtResult.Text
        Label3.Text = "-"
        txtResult.Text = ""
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Label2.Text = txtResult.Text
        Label3.Text = "/"
        txtResult.Text = ""
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Label2.Text = txtResult.Text
        Label3.Text = "x"
        txtResult.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtResult.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtResult.Text = ""
        Label3.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If Label3.Text = "+" Then
            txtResult.Text = Val(Label2.Text) + Val(txtResult.Text)
            Label2.Text = ""
            Label3.Text = ""
        ElseIf Label3.Text = "-" Then
            txtResult.Text = Val(Label2.Text) - Val(txtResult.Text)
            Label2.Text = ""
            Label3.Text = ""
        ElseIf Label3.Text = "/" Then
            txtResult.Text = Val(Label2.Text) / Val(txtResult.Text)
            If txtResult.Text = "∞" Then
                txtResult.Text = "Syntax Error"
                Label2.Text = ""
                Label3.Text = ""
            End If

        ElseIf Label3.Text = "x" Then
            txtResult.Text = Val(Label2.Text) * Val(txtResult.Text)
            Label2.Text = ""
            Label3.Text = ""

        End If
    End Sub


    Private Sub BMIToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BMIToolStripMenuItem.Click
        BMIForm.Show()

        Me.Hide()
    End Sub

    Private Sub txtResult_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResult.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

End Class
